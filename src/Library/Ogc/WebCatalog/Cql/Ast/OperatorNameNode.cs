using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using Irony.Interpreter;
using Irony.Interpreter.Ast;
using Irony.Parsing;

namespace OgcToolkit.Ogc.WebCatalog.Cql.Ast
{

#pragma warning disable 3009
    public class OperatorNameNode:
        AstNode
    {

        [SuppressMessage("Microsoft.Globalization", "CA1308:NormalizeStringsToUppercase")]
        public override void Init(ParsingContext context, ParseTreeNode treeNode)
        {
            base.Init(context, treeNode);

            string n=treeNode.Term.ToString();
            Name=string.Concat(n.Substring(0, 1).ToUpperInvariant(), n.Substring(1).ToLowerInvariant());

            AsString=Name;
        }

        public string Name
        {
            get;
            private set;
        }
    }
#pragma warning restore 3009
}
