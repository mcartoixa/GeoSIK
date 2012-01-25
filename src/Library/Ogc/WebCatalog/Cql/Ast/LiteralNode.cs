using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using Irony.Interpreter;
using Irony.Interpreter.Ast;
using Irony.Parsing;

namespace OgcToolkit.Ogc.WebCatalog.Cql.Ast
{

#pragma warning disable 3001, 3009
    public abstract class LiteralNode<T>:
        AstNode,
        IExpressionBuilder
    {

        public override void Init(ParsingContext context, ParseTreeNode treeNode)
        {
            base.Init(context, treeNode);

            _Value=InitValue(context, treeNode);
            if (_Value!=null)
                AsString=string.Format(
                    CultureInfo.InvariantCulture,
                    "{0}",
                    _Value
                );
            else
                AsString="<null>";
        }

        protected abstract T InitValue(ParsingContext context, ParseTreeNode treeNode);

        protected override object DoEvaluate(ScriptThread thread)
        {
            return _Value;
        }

        public override bool IsConstant()
        {
            return true;
        }

        public T Value
        {
            get
            {
                return _Value;
            }
        }

        private T _Value;

        public Expression CreateExpression(ExpressionBuilderParameters parameters, Type expectedStaticType, Func<Expression, Expression> operatorCreator)
        {
            Expression ret=Expression.Constant(_Value, GetExpressionStaticType(parameters));

            if (operatorCreator!=null)
                ret=operatorCreator(ret);

            return ret;
        }

        internal protected virtual Type GetExpressionStaticType(ExpressionBuilderParameters parameters)
        {
            return typeof(T);
        }

        Type IExpressionBuilder.GetExpressionStaticType(ExpressionBuilderParameters parameters)
        {
            return GetExpressionStaticType(parameters);
        }
    }
#pragma warning restore 3001, 3009
}
