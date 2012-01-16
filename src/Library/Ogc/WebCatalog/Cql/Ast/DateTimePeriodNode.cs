using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Irony.Interpreter;
using Irony.Interpreter.Ast;
using Irony.Parsing;

namespace OgcToolkit.Ogc.WebCatalog.Cql.Ast
{

#pragma warning disable 3001, 3009
    public class DateTimePeriodNode:
        AstNode
    {

        public override void Init(ParsingContext context, ParseTreeNode treeNode)
        {
            base.Init(context, treeNode);

            AstNode sn=AddChild("from", treeNode.MappedChildNodes[0]);
            AstNode en=AddChild("to", treeNode.MappedChildNodes[2]);

            var dtsn=sn as DateTimeLiteralNode;
            var dten=en as DateTimeLiteralNode;
            if (dtsn!=null)
            {
                _StartDate=dtsn.Value;

                if (dten!=null)
                    _EndDate=dten.Value;
                else
                    _EndDate=_StartDate+((DurationLiteralNode)en).Value;
            } else
            {
                _EndDate=dten.Value;
                _StartDate=_EndDate-((DurationLiteralNode)sn).Value;
            }

            AsString="period";
        }

        public DateTime StartDate
        {
            get
            {
                return _StartDate;
            }
        }

        public DateTime EndDate
        {
            get
            {
                return _EndDate;
            }
        }

        private DateTime _StartDate;
        private DateTime _EndDate;
    }
#pragma warning restore 3001, 3009
}
