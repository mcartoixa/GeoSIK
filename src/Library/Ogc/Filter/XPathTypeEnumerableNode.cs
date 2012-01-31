using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;

namespace OgcToolkit.Ogc.Filter
{

    internal class XPathTypeEnumerableNode:
        XPathTypeNode
    {

        protected XPathTypeEnumerableNode()
        {
        }

        internal XPathTypeEnumerableNode(Type node, MemberInfo memberInfo, XPathTypeNode parent, XPathTypeContext context):
            base(node, memberInfo, parent, context)
        {
        }

        internal protected override Expression CreateNodeExpression(Expression baseExpression, LinkedList<XPathTypeNode> path, Type expectedType, Func<Expression, ParameterExpression, Expression> expressionCreator, Stack<ParameterExpression> innerParams)
        {
            Expression enuex=Expression.PropertyOrField(baseExpression, MemberInfo.Name);
            LambdaExpression oplex=null;
            ParameterExpression param=Expression.Parameter(Type);

            if (path.First==null)
            {
                if ((expressionCreator==null) && (innerParams.Count>0))
                    throw new InvalidOperationException("Trying to create an expression to an element that is inside a collection.");

                Expression select=(expressionCreator!=null ? param : baseExpression);
                if (ValueMemberInfo!=null)
                    select=Expression.PropertyOrField(param, ValueMemberInfo.Name);

                //select=GetSynonymExpression((MemberExpression)select, expectedType);

                // We only want an expression to the collection
                if (expressionCreator==null)
                    return select;

                oplex=Expression.Lambda(expressionCreator(select, param), param);
            } else
            {
                innerParams.Push(param);

                XPathTypeNode node=path.First.Value;
                path.RemoveFirst();

                oplex=Expression.Lambda(node.CreateNodeExpression(param, path, expectedType, expressionCreator, innerParams), param);
            }

            return Expression.Call(
                typeof(Enumerable),
                "Any",
                new Type[] { Type },
                enuex,
                oplex
            );
        }

        protected override Type GetMemberType(MemberInfo member)
        {
            Type ret=base.GetMemberType(member);

            if ((ret!=null) && (ret!=typeof(string))) // string implements IEnumerable<char>
            {
                Type entype=ret.GetInterface("IEnumerable`1");
                if (entype!=null)
                    return entype.GetGenericArguments()[0];
            }

            return ret;
        }
    }
}
