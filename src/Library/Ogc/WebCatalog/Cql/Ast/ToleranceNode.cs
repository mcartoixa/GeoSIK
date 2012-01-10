﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using Irony.Interpreter;
using Irony.Interpreter.Ast;
using Irony.Parsing;

namespace OgcToolkit.Ogc.WebCatalog.Cql.Ast
{

#pragma warning disable 3001, 3009
    public class ToleranceNode:
        AstNode
    {

        public override void Init(ParsingContext context, ParseTreeNode treeNode)
        {
            base.Init(context, treeNode);

            //TODO: units conversion
            _Value=decimal.Parse(treeNode.FindTokenAndGetText(), CultureInfo.InvariantCulture);
            AsString=string.Format(
                CultureInfo.InvariantCulture,
                "{0:G}m",
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

        public decimal Value
        {
            get
            {
                return _Value;
            }
        }

        private decimal _Value;
    }
#pragma warning restore 3001, 3009
}