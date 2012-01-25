﻿using System;
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
        LiteralNode<DateTime>
    {

        public override void Init(ParsingContext context, ParseTreeNode treeNode)
        {
            base.Init(context, treeNode);

            AsString=string.Format(
                CultureInfo.InvariantCulture,
                "{0:G} (date time)",
                Value
            );
        }

        protected override DateTime InitValue(ParsingContext context, ParseTreeNode treeNode)
        {
            return XmlConvert.ToDateTime(treeNode.Token.ValueString, XmlDateTimeSerializationMode.RoundtripKind);
        }
    }
#pragma warning restore 3001, 3009
}
