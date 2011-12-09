using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Data.Objects.DataClasses;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Web;
using Microsoft.SqlServer.Types;

namespace OgcToolkit.WebSample.Models.LinqToSql
{

    public class OperatorsImplementationProvider:
        IOperatorImplementationProvider
    {

        public OperatorsImplementationProvider(RecordsDataContext context)
        {
            Debug.Assert(context!=null);
            if (context==null)
                throw new ArgumentNullException("context");

            _Context=context;
        }

        MethodInfo IOperatorImplementationProvider.GetImplementation(string operatorName, Type[] arguments, ref object[] values, out object instance)
        {
            MethodInfo ret=null;
            instance=_Context;

            switch (operatorName)
            {
            case "STDisjoint":
                values=values.Select<object, object>(v => v!=null ? new Binary((byte[])v) : null).ToArray<object>();
                return typeof(RecordsDataContext).GetMethod("Geometry_STDisjoint", new Type[] { typeof(Binary), typeof(Binary) });
            }

            return ret;
        }

        private RecordsDataContext _Context;
    }
}