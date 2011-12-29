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
    public class DateTimeLiteralNode:
        AstNode
    {

        public override void Init(ParsingContext context, ParseTreeNode treeNode)
        {
            base.Init(context, treeNode);

            _Value=XmlConvert.ToDateTime(treeNode.Token.ValueString, XmlDateTimeSerializationMode.RoundtripKind);
            AsString=string.Format(
                CultureInfo.InvariantCulture,
                "{0:G} (date time)",
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

        public DateTime Value
        {
            get
            {
                return _Value;
            }
        }

        private DateTime _Value;
    }
#pragma warning restore 3001, 3009
}
