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
        LiteralNode<SqlGeometry>
    {

        protected override SqlGeometry InitValue(ParsingContext context, ParseTreeNode treeNode)
        {
            return SqlGeometry.STGeomFromText(new SqlChars(treeNode.Token.Text), 4326); //TODO: right SRID ?
        }
    }
#pragma warning restore 3001, 3009
}
