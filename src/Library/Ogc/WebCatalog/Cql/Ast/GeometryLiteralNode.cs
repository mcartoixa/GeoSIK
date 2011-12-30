using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Globalization;
using System.Linq;
using System.Text;
using Microsoft.SqlServer.Types;
using Irony.Interpreter;
using Irony.Interpreter.Ast;
using Irony.Parsing;

namespace OgcToolkit.Ogc.WebCatalog.Cql.Ast
{

#pragma warning disable 3001, 3009
    public class GeometryLiteralNode:
        AstNode
    {

        public override void Init(ParsingContext context, ParseTreeNode treeNode)
        {
            base.Init(context, treeNode);

            _Value=SqlGeometry.STGeomFromText(new SqlChars(treeNode.Token.Text), 4326); //TODO: right SRID ?

            AsString=_Value.ToString();
        }

        protected override object DoEvaluate(ScriptThread thread)
        {
            return _Value;
        }

        public override bool IsConstant()
        {
            return true;
        }

        public SqlGeometry Value
        {
            get
            {
                return _Value;
            }
        }

        private SqlGeometry _Value;
    }
#pragma warning restore 3001, 3009
}
