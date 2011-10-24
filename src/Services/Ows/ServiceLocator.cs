﻿using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Xml.Serialization;

namespace OgcToolkit.Services.Ows
{

    /// <summary>This type can be used to invoke OWS services dynamically.</summary>
    public sealed class ServiceLocator
    {

        private ServiceLocator() { }

        public static ServiceLocator Instance
        {
            get
            {
                if (_Instance==null)
                    lock (syncRoot)
                        if (_Instance==null)
                        {
                            _Instance=new ServiceLocator();
                            _Instance.FindServices();
                        }

                return _Instance;
            }
        }

        /// <summary>Invokes the OWS service referenced in the specified <paramref name="parameters" />.</summary>
        /// <param name="parameters">The key/value pairs </param>
        /// <returns></returns>
        public IXmlSerializable InvokeService(NameValueCollection parameters)
        {
            Debug.Assert(parameters!=null);
            if (parameters==null)
                throw new ArgumentNullException("parameters");

            parameters=NormalizeParameters(parameters);

            string request=parameters[OgcService.RequestParameter];
            if (string.IsNullOrEmpty(request))
                throw new OwsException(OwsExceptionCode.MissingParameterValue) {
                    Locator=OgcService.RequestParameter
                };

            string service=parameters[OgcService.ServiceParameter];
            if (string.IsNullOrEmpty(service))
                throw new OwsException(OwsExceptionCode.MissingParameterValue) {
                    Locator=OgcService.ServiceParameter
                };

            string version=parameters[OgcService.VersionParameter];
            if ((request!="GetCapabilities") && string.IsNullOrEmpty(version))
                throw new OwsException(OwsExceptionCode.MissingParameterValue) {
                    Locator=OgcService.VersionParameter
                };

            return InvokeService(parameters, service, version, request);
        }

        public IXmlSerializable InvokeService(IOwsRequest request)
        {
            Debug.Assert(request!=null);
            if (request==null)
                throw new OwsException(OwsExceptionCode.MissingParameterValue) {
                    Locator=OgcService.RequestParameter
                };

            string operation=request.GetType().Name;

            if (string.IsNullOrEmpty(request.Service))
                throw new OwsException(OwsExceptionCode.MissingParameterValue) {
                    Locator=OgcService.ServiceParameter
                };

            if ((operation!="GetCapabilities") && string.IsNullOrEmpty(request.Version))
                throw new OwsException(OwsExceptionCode.MissingParameterValue) {
                    Locator=OgcService.VersionParameter
                };

            return InvokeService(request, request.Service, request.Version, operation);
        }

        private IXmlSerializable InvokeService(object input, string service, string version, string request)
        {
            if (!_Services.ContainsKey(service))
                throw new OwsException(OwsExceptionCode.OperationNotSupported) {
                    Locator=OgcService.ServiceParameter // should be service ?
                };
            var s=_Services[service];

            Type t=null;
            if (!string.IsNullOrEmpty(version))
            {
                if (!s.ContainsKey(version))
                    throw new OwsException(OwsExceptionCode.InvalidParameterValue) {
                        Locator=OgcService.VersionParameter
                    };
                t=s[version];
            } else
                t=s[s.Keys.Max<string>()]; // latest version

            IEnumerable<MethodInfo> requests=t.
                FindMembers(MemberTypes.Method, BindingFlags.Instance | BindingFlags.Public, _ServiceRequestFilter, request.ToUpperInvariant()).
                Cast<MethodInfo>();
            foreach (MethodInfo r in requests)
            {
                ParameterInfo[] pia=r.GetParameters();
                if ((pia.Length==1) && (pia[0].ParameterType==input.GetType()))
                    try
                    {
                        return r.Invoke(Activator.CreateInstance(t), new object[] { input }) as IXmlSerializable;
                    } catch (TargetInvocationException tiex)
                    {
                        var oex=tiex.InnerException as OwsException;
                        if (oex!=null)
                            throw oex;
                    }
            }

            throw new OwsException(OwsExceptionCode.OperationNotSupported) {
                Locator=request
            };
        }

        /// <summary>Initializes the list of services that can be <see cref="InvokeService">invoked</see> by the current <see cref="ServiceLocator" />.</summary>
        private void FindServices()
        {
            if (_Services==null)
            {
                _Services=new Dictionary<string, Dictionary<string, Type>>();
                Assembly assembly=Assembly.GetExecutingAssembly();
                foreach (Type t in assembly.GetExportedTypes())
                    foreach (OwsDescriptionAttribute a in t.GetCustomAttributes(typeof(OwsDescriptionAttribute), false)) {
                        if (!_Services.ContainsKey(a.Service))
                            _Services.Add(a.Service, new Dictionary<string, Type>());
                        _Services[a.Service].Add(a.Version, t);
                        break;
                    }
            }
        }

        private void FindRequestTypes()
        {
            if (_RequestTypes==null)
            {
                _RequestTypes=new List<Type>();
                Assembly assembly=Assembly.GetAssembly(typeof(IOwsRequest));
                foreach (Type t in assembly.GetExportedTypes())
                    if (t.GetInterface(typeof(IOwsRequest).FullName)!=null)
                        _RequestTypes.Add(t);
            }
        }

        public static Type[] GetRequestTypes(ICustomAttributeProvider knownTypeAttributeTarget)
        {
            Instance.FindRequestTypes();
            return Instance._RequestTypes.ToArray();
        }

        /// <summary>Normalizes all the specified <paramref name="parameters" />.</summary>
        /// <param name="parameters">The parameters to normalize.</param>
        /// <returns>The normalized parameters.</returns>
        /// <remarks>
        ///   <para>After normalization, the parameters have the following properties:
        /// <list type="bullet">
        ///   <item><description>all the keys are lower cased.</description></item>
        /// </list>
        /// </para></remarks>
        internal static NameValueCollection NormalizeParameters(NameValueCollection parameters)
        {
            var ret=new NameValueCollection(parameters.Count);

            for (int i=0; i<parameters.Count; ++i)
            {
                string key=parameters.GetKey(i).ToLowerInvariant();
                foreach (string value in parameters.GetValues(i))
                    ret.Add(key, value);
            }

            return ret;
        }

        private static bool _ServiceRequestFilter(MemberInfo objMemberInfo, object objSearch)
        {
            if (objMemberInfo.Name.ToUpperInvariant()==objSearch.ToString())
                return true;

            return false;
        }

        private Dictionary<string, Dictionary<string, Type>> _Services;
        private List<Type> _RequestTypes;

        private static volatile ServiceLocator _Instance;
        private static object syncRoot=new object();
    }
}
