using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Reflection;
using System.Text;

namespace OgcToolkit
{

    public interface IOperatorImplementationProvider
    {

        [SuppressMessage("Microsoft.Design", "CA1045:DoNotPassTypesByReference", MessageId="1#")]
        [SuppressMessage("Microsoft.Design", "CA1045:DoNotPassTypesByReference", MessageId="2#")]
        [SuppressMessage("Microsoft.Design", "CA1021:AvoidOutParameters", MessageId="3#")]
        MethodInfo GetImplementation(string operatorName, ref Type[] arguments, ref object[] values, out object instance);
    }
}
