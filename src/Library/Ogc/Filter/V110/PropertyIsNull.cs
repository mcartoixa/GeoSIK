using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Xml;
using System.Xml.XPath;

namespace OgcToolkit.Ogc.Filter.V110
{

#pragma warning disable 3009
    partial class PropertyIsNull
    {

        protected override Expression CreateExpression(ExpressionBuilderParameters parameters, Type expectedStaticType)
        {
            Debug.Assert(PropertyName!=null);

            Type st=((IExpressionBuilder)PropertyName).GetExpressionStaticType(parameters);
            return Expression.Equal(
                ((IExpressionBuilder)PropertyName).CreateExpression(parameters, st),
                Expression.Constant(
                    null,
                    st
                )
            );
        }
    }
#pragma warning restore 3009
}
