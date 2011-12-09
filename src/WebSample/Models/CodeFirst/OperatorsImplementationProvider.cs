using System;
using System.Collections.Generic;
using System.Data.Objects.DataClasses;
using System.Linq;
using System.Reflection;
using System.Web;
using Microsoft.SqlServer.Types;

namespace OgcToolkit.WebSample.Models.CodeFirst
{

    public class OperatorsImplementationProvider:
        IOperatorImplementationProvider
    {

        public OperatorsImplementationProvider()
        {
        }

        MethodInfo IOperatorImplementationProvider.GetImplementation(string operatorName, Type[] arguments, ref object[] values, out object instance)
        {
            MethodInfo ret=null;
            instance=null;

            switch (operatorName)
            {
            case "STDisjoint":
                return typeof(OperatorsImplementationProvider).GetMethod("GeometryDisjoint", arguments);
            }

            return ret;
        }

        [EdmFunction("OgcToolkit.WebSample.Models", "Geometry_STDisjoint")]
        public static int GeometryDisjoint(byte[] geometry1, byte[] geometry2)
        {
            throw new NotSupportedException();
        }
    }
}