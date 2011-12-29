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
    public class DurationLiteralNode:
        AstNode
    {

        public override void Init(ParsingContext context, ParseTreeNode treeNode)
        {
            base.Init(context, treeNode);

            _Value=XmlConvert.ToTimeSpan(treeNode.Token.ValueString);
            AsString=string.Format(
                CultureInfo.InvariantCulture,
                "{0:G} (duration)",
                _Value
            );
        }

        protected override object DoEvaluate(ScriptThread thread)
        {
            return _Value;
        }

        public override bool IsConstant()
        {
            return true;
        }

        public TimeSpan Value
        {
            get
            {
                return _Value;
            }
        }

        private TimeSpan _Value;
    }
#pragma warning restore 3001, 3009
}
