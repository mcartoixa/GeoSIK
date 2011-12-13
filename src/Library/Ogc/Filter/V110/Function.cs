using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Xml;

namespace OgcToolkit.Ogc.Filter.V110
{

#pragma warning disable 3009
    partial class Function
    {

        protected override Expression CreateExpression(ExpressionBuilderParameters parameters, Type expectedStaticType)
        {
            throw new NotSupportedException();
        }
    }
#pragma warning restore 3009
}
