using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace OgcToolkit.Ogc.WebCatalog.Cql.Ast
{

    public interface IExpressionBuilder
    {

        Expression CreateExpression(ExpressionBuilderParameters parameters, Type expectedStaticType);
        Type GetExpressionStaticType(ExpressionBuilderParameters parameters);
    }
}
