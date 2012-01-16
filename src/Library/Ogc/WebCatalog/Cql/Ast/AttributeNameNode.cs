using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
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

#pragma warning disable 3001, 3003, 3009
    public class AttributeNameNode:
        AstNode,
        IExpressionBuilder
    {

        public override void Init(ParsingContext context, ParseTreeNode treeNode)
        {
            base.Init(context, treeNode);

            _Identifier=AddChild("Id", treeNode.MappedChildNodes[0]) as IdentifierNode;
        }

        public Expression CreateExpression(ExpressionBuilderParameters parameters, Type expectedStaticType)
        {
            return GetNavigator(parameters)
                .CreateExpression(parameters.Parameters[0], expectedStaticType);
        }

        public Type GetExpressionStaticType(ExpressionBuilderParameters parameters)
        {
            return GetNavigator(parameters).Type;
        }

        protected override object DoEvaluate(ScriptThread thread)
        {
            thread.CurrentNode=this;

            object ret=_Identifier.Evaluate(thread);

            thread.CurrentNode=Parent;
            return ret;
        }

        private Csw202.XPathQueryableNavigator GetNavigator(ExpressionBuilderParameters parameters)
        {
            if (_Navigator==null)
            {
                Csw202.XPathQueryableNavigator xptn=new Csw202.XPathQueryableNavigator(parameters.ElementType);
                XPathNodeIterator xpni=xptn.Select(_Identifier.Symbol, parameters.NamespaceResolver, true);
                while (xpni.MoveNext())
                    _Navigator=xpni.Current as Csw202.XPathQueryableNavigator;

                Debug.Assert(_Navigator!=null);
                if (_Navigator==null)
                    throw new InvalidOperationException(
                        string.Format(
                            CultureInfo.CurrentCulture,
                            SR.InvalidPropertyNameExpressionException,
                            _Identifier.Symbol
                        )
                    );
            }

            return _Navigator;
        }

        public IdentifierNode Identifier
        {
            get
            {
                return _Identifier;
            }
        }

        private IdentifierNode _Identifier;
        private Csw202.XPathQueryableNavigator _Navigator;
    }
#pragma warning restore 3001, 3003, 3009
}
