using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Xml;
using Microsoft.SqlServer.Types;
using Xml.Schema.Linq;

namespace OgcToolkit.Ogc.Filter.V110
{

    partial class spatialOps:
        IExpressionBuilder
    {

        protected virtual Expression CreateExpression(ExpressionBuilderParameters parameters, Type expectedStaticType)
        {
            var bsop=this as IBinarySpatialOperator;
            if (bsop!=null)
            {
                Expression pnex=((IExpressionBuilder)bsop.PropertyName).CreateExpression(parameters, typeof(SqlGeometry));

                if (bsop.Envelope!=null)
                {

                }
            }

            throw new NotSupportedException();
        }

        protected virtual Type GetExpressionStaticType(ExpressionBuilderParameters parameters)
        {
            return typeof(bool);
        }

        Expression IExpressionBuilder.CreateExpression(ExpressionBuilderParameters parameters, Type expectedStaticType)
        {
            return CreateExpression(parameters, expectedStaticType);
        }

        Type IExpressionBuilder.GetExpressionStaticType(ExpressionBuilderParameters parameters)
        {
            return GetExpressionStaticType(parameters);
        }
    }
}
