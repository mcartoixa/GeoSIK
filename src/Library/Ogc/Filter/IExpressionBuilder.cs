using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Xml;

namespace OgcToolkit.Ogc.Filter
{

    public interface IExpressionBuilder
    {

        Expression CreateExpression(ExpressionBuilderParameters parameters, Type expectedStaticType, Func<Expression, Expression> operatorCreator);
        Type GetExpressionStaticType(ExpressionBuilderParameters parameters);
    }
}
