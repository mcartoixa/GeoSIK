using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace OgcToolkit
{

    public interface IOperatorImplementationProvider
    {

        MethodInfo GetImplementation(string operatorName, Type[] arguments, ref object[] values, out object instance);
    }
}
