////////////////////////////////////////////////////////////////////////////////
//
// This file is part of GeoSIK.
// Copyright (C) 2012 Isogeo
//
// GeoSIK is free software: you can redistribute it and/or modify
// it under the terms of the GNU Lesser General Public License as published by
// the Free Software Foundation, either version 2 of the License, or
// (at your option) any later version.
//
// GeoSIK is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU Lesser General Public License for more details.
//
// You should have received a copy of the GNU Lesser General Public License
// along with GeoSIK. If not, see <http://www.gnu.org/licenses/>.
//
////////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace GeoSik.Ogc.Ows
{

    /// <summary>This type can be used to invoke OWS services dynamically.</summary>
    public sealed class ServiceLocator
    {

        /// <summary>Creates a new instance of the <see cref="ServiceLocator" /> class.</summary>
        public ServiceLocator():
            this(Assembly.GetExecutingAssembly())
        {
        }

        /// <summary>Creates a new instance of the <see cref="ServiceLocator" /> class.</summary>
        /// <param name="assembly">The assembly to scan for OWS services.</param>
        public ServiceLocator(Assembly assembly)
        {
            Debug.Assert(assembly!=null);
            if (assembly==null)
                throw new ArgumentNullException("assembly");

            _Assembly=assembly;
        }

        /// <summary>Invokes the OWS service referenced in the specified <paramref name="parameters" />.</summary>
        /// <param name="parameters">The key/value pairs that are used as parameters of the service call.</param>
        /// <returns>The result of the call.</returns>
        public async Task<IXmlSerializable> InvokeServiceAsync(NameValueCollection parameters)
        {
            return await InvokeServiceAsync(null, parameters);
        }

        /// <summary>Invokes the OWS service referenced in the specified <paramref name="parameters" />.</summary>
        /// <param name="arguments">The arguments to use for the service instantiation. Can be <c>null</c>.</param>
        /// <param name="parameters">The key/value pairs that are used as parameters of the service call.</param>
        /// <returns>The result of the call.</returns>
        public async Task<IXmlSerializable> InvokeServiceAsync(object[] arguments, NameValueCollection parameters)
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

            return await InvokeServiceAsync(arguments, parameters, service, version, request);
        }

        /// <summary>Invokes the OWS service corresponding to the specified <paramref name="request" />.</summary>
        /// <param name="request">The request that is used for the service call.</param>
        /// <returns>The result of the call.</returns>
        public async Task<IXmlSerializable> InvokeServiceAsync(IRequest request)
        {
            return await InvokeServiceAsync(null, request);
        }

        /// <summary>Invokes the OWS service corresponding to the specified <paramref name="request" />.</summary>
        /// <param name="arguments">The arguments to use for the service instantiation. Can be <c>null</c>.</param>
        /// <param name="request">The request that is used for the service call.</param>
        /// <returns>The result of the call.</returns>
        public async Task<IXmlSerializable> InvokeServiceAsync(object[] arguments, IRequest request)
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

            return await InvokeServiceAsync(arguments, request, request.Service, request.Version, operation);
        }

        private async Task<IXmlSerializable> InvokeServiceAsync(object[] arguments, object input, string service, string version, string request)
        {
            FindServices();

            if (!_Services.ContainsKey(service))
                throw new OwsException(
                    OwsExceptionCode.OperationNotSupported,
                    string.Format(
                        CultureInfo.CurrentCulture,
                        SR.InvalidParameterException,
                        OgcService.ServiceParameter,
                        service ?? string.Empty
                    )
                ) {
                    Locator=OgcService.ServiceParameter // should be service ?
                };
            var s=_Services[service];

            Type t=null;
            if (!string.IsNullOrEmpty(version))
            {
                if (!s.ContainsKey(version))
                    throw new OwsException(
                        OwsExceptionCode.InvalidParameterValue,
                        string.Format(
                            CultureInfo.CurrentCulture,
                            SR.InvalidParameterException,
                            OgcService.VersionParameter,
                            version
                        )
                    ) {
                        Locator=OgcService.VersionParameter
                    };
                t=s[version];
            } else
                t=s[s.Keys.Max()]; // latest version

            var requests=t
                .FindMembers(MemberTypes.Method, BindingFlags.Instance | BindingFlags.Public | BindingFlags.FlattenHierarchy, _ServiceRequestFilter, string.Concat(request, "Async").ToUpperInvariant())
                .Cast<MethodInfo>()
                .Union(
                    t.FindMembers(MemberTypes.Method, BindingFlags.Instance | BindingFlags.Public | BindingFlags.FlattenHierarchy, _ServiceRequestFilter, request.ToUpperInvariant())
                );
            foreach (MethodInfo r in requests)
            {
                ParameterInfo[] pia=r.GetParameters();
                if ((pia.Length==1) && (pia[0].ParameterType==input.GetType()))
                    try
                    {
                        var rop=new Func<dynamic>(() => r.Invoke(Activator.CreateInstance(t, arguments), new object[] { input }));
                        if (r.ReturnType.IsGenericType && r.ReturnType.IsSubclassOf(typeof(Task)))
                            return (await rop()) as IXmlSerializable;
                        return rop() as IXmlSerializable;
                    } catch (TargetInvocationException tiex)
                    {
                        var oex=tiex.InnerException as OwsException;
                        if (oex!=null)
                            throw new OwsException(oex.Code, oex) {
                                Locator=oex.Locator
                            };

                        if (tiex.InnerException!=null)
                            throw new OwsException(OwsExceptionCode.NoApplicableCode, tiex.InnerException);

                        throw new OwsException(OwsExceptionCode.NoApplicableCode, tiex);
                    } catch (NotSupportedException nsex)
                    {
                        throw new OwsException(OwsExceptionCode.OperationNotSupported, nsex) {
                            Locator=request
                        };
                    } catch (OwsException)
                    {
                        throw;
                    } catch (Exception ex)
                    {
                        throw new OwsException(OwsExceptionCode.NoApplicableCode, ex);
                    }
            }

            throw new OwsException(
                OwsExceptionCode.OperationNotSupported,
                string.Format(
                    CultureInfo.CurrentCulture,
                    SR.InvalidParameterException,
                    OgcService.RequestParameter,
                    request ?? string.Empty
                )
            ) {
                Locator=request
            };
        }

        /// <summary>Initializes the list of services that can be invoked by the current <see cref="ServiceLocator" />.</summary>
        private void FindServices()
        {
            if (_Services==null)
            {
                _Services=new Dictionary<string, Dictionary<string, Type>>();
                foreach (Type t in _Assembly.GetExportedTypes())
                    foreach (OwsDescriptionAttribute a in t.GetCustomAttributes(typeof(OwsDescriptionAttribute), false)) {
                        if (!_Services.ContainsKey(a.Service))
                            _Services.Add(a.Service, new Dictionary<string, Type>());
                        _Services[a.Service].Add(a.Version, t);
                        break;
                    }
            }
        }

        /// <summary>Gets all the request types used in registered OWS services.</summary>
        /// <param name="knownTypeAttributeTarget">Unused.</param>
        /// <returns>The request types used in registered OWS services.</returns>
        /// <remarks>
        ///   <para>Can be used as a helper method for the <see cref="System.ServiceModel.ServiceKnownTypeAttribute" /> attribute.</para>
        /// </remarks>
        [SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", MessageId="knownTypeAttributeTarget", Justification="Required to be used as a ServiceKnownTypeAttribute parameter")]
        public static Type[] GetRequestTypes(ICustomAttributeProvider knownTypeAttributeTarget)
        {
            if (_RequestTypes==null)
            {
                _RequestTypes=new List<Type>();
                Assembly assembly=Assembly.GetAssembly(typeof(IRequest));
                foreach (Type t in assembly.GetExportedTypes())
                    if (t.GetInterface(typeof(IRequest).FullName)!=null)
                        _RequestTypes.Add(t);
            }

            return _RequestTypes.ToArray();
        }

        /// <summary>Normalizes all the specified <paramref name="parameters" />.</summary>
        /// <param name="parameters">The parameters to normalize.</param>
        /// <returns>The normalized parameters.</returns>
        /// <remarks>
        ///   <para>After normalization, the parameters have the following properties:
        /// <list type="bullet">
        ///   <item><description>all the keys are lower cased.</description></item>
        /// </list>
        /// </para>
        /// </remarks>
        [SuppressMessage("Microsoft.Globalization", "CA1308:NormalizeStringsToUppercase")]
        internal static NameValueCollection NormalizeParameters(NameValueCollection parameters)
        {
            var ret=new NameValueCollection(parameters.Count);

            for (int i=0; i<parameters.Count; ++i)
            {
                string key=parameters.GetKey(i).ToLowerInvariant();
                ret.Add(key, string.Join(",", parameters.GetValues(i)));
            }

            return ret;
        }

        private static bool _ServiceRequestFilter(MemberInfo objMemberInfo, object objSearch)
        {
            if (objMemberInfo.Name.ToUpperInvariant()==objSearch.ToString())
                return true;

            return false;
        }

        internal static ServiceLocator Instance
        {
            get
            {
                if (_Instance==null)
                    lock (_SyncRoot)
                        if (_Instance==null)
                        {
                            _Instance=new ServiceLocator();
                            _Instance.FindServices();
                        }

                return _Instance;
            }
        }

        private Assembly _Assembly;
        private Dictionary<string, Dictionary<string, Type>> _Services;

        private static List<Type> _RequestTypes;
        private static volatile ServiceLocator _Instance;
        private static object _SyncRoot=new object();
    }
}
