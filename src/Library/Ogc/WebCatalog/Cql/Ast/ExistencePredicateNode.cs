using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Xml.XPath;
using Irony.Interpreter;
using Irony.Interpreter.Ast;
using Irony.Parsing;
using Csw202=OgcToolkit.Services.Csw.V202;

namespace OgcToolkit.Ogc.WebCatalog.Cql.Ast
{

#pragma warning disable 3001, 3009
    public sealed class ExistencePredicateNode:
        AstNode,
        IExpressionBuilder
    {

        public override void Init(ParsingContext context, ParseTreeNode treeNode)
        {
            base.Init(context, treeNode);

            _AttributeName=(AttributeNameNode)AddChild("", treeNode.MappedChildNodes[0]);
            _Negated=treeNode.MappedChildNodes[1].Term.Name.Contains("NOT");

        }

        public Expression CreateExpression(ExpressionBuilderParameters parameters, Type expectedStaticType)
        {
            if (!_Result.HasValue)
            {
                Csw202.XPathQueryableNavigator xptn=new Csw202.XPathQueryableNavigator(parameters.ElementType);
                XPathNodeIterator xpni=xptn.Select(_AttributeName.Identifier.Symbol, parameters.NamespaceResolver, true);
                _Result=xpni.MoveNext();
                if (_Negated)
                    _Result=!_Result;
            }

            return Expression.Constant(_Result.Value, typeof(bool));
        }

        public override bool IsConstant()
        {
            return true;
        }

        protected override object DoEvaluate(ScriptThread thread)
        {
            //TODO: Initialize _Result...
            return _Result.Value;
        }

        Type IExpressionBuilder.GetExpressionStaticType(ExpressionBuilderParameters parameters)
        {
            return typeof(bool);
        }

        private AttributeNameNode _AttributeName;
        private bool _Negated;
        private bool? _Result;
    }
#pragma warning restore 3001, 3009
}
