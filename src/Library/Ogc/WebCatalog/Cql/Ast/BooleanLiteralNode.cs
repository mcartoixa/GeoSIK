using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Xml;
using Irony.Interpreter;
using Irony.Interpreter.Ast;
using Irony.Parsing;

namespace OgcToolkit.Ogc.WebCatalog.Cql.Ast
{

#pragma warning disable 3001, 3009
    public class BooleanLiteralNode:
        LiteralNode<bool?>
    {

        public override void Init(ParsingContext context, ParseTreeNode treeNode)
        {
            base.Init(context, treeNode);

            if (Value.HasValue)
                AsString=string.Format(
                    CultureInfo.InvariantCulture,
                    "{0} (boolean)",
                    Value.Value
                );
        }

        protected override bool? InitValue(ParsingContext context, ParseTreeNode treeNode)
        {
            switch (treeNode.Token.ValueString)
            {
            case "UNKNOWN":
                return null;
            default:
                return bool.Parse(treeNode.Token.ValueString);
            }
        }
    }
#pragma warning restore 3001, 3009
}
