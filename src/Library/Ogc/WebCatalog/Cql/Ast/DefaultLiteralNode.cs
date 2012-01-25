using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Irony.Interpreter;
using Irony.Interpreter.Ast;
using Irony.Parsing;

namespace OgcToolkit.Ogc.WebCatalog.Cql.Ast
{

#pragma warning disable 3009
    public class DefaultLiteralNode:
        LiteralNode<object>
    {

        protected override object InitValue(ParsingContext context, ParseTreeNode treeNode)
        {
            return treeNode.Token.Value;
        }

        internal protected override Type GetExpressionStaticType(ExpressionBuilderParameters parameters)
        {
            if (Value!=null)
                return Value.GetType();

            return typeof(object);
        }
    }
#pragma warning restore 3009
}
