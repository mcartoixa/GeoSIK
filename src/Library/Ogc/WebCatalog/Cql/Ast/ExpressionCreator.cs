////////////////////////////////////////////////////////////////////////////////
//
// This file is part of GeoSIK.
// Copyright (C) 2012 Isogeo
//
// GeoSIK is free software: you can redistribute it and/or modify
// it under the terms of the GNU Lesser General Public License as published by
// the Free Software Foundation, either version 2 of the License, or
// (at your option) any later version.
//
// GeoSIK is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU Lesser General Public License for more details.
//
// You should have received a copy of the GNU Lesser General Public License
// along with GeoSIK. If not, see <http://www.gnu.org/licenses/>.
//
////////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using LinqExpressionType=System.Linq.Expressions.ExpressionType;
using Irony;
using Irony.Interpreter.Ast;

namespace GeoSik.Ogc.WebCatalog.Cql.Ast
{

    public interface IExpressionCreator:
        IEnumerable<IExpressionBuilder>
    {

        Expression CreateExpression(ExpressionBuilderParameters parameters);
    }



    internal abstract class ExpressionCreator<TNode>:
        IExpressionCreator
        where TNode:
            AstNode,
            IExpressionBuilder
    {

        protected ExpressionCreator(TNode node)
        {
            Debug.Assert(node!=null);
            if (node==null)
                throw new ArgumentNullException("node");

            _Node=node;
        }

        public virtual Expression CreateExpression(ExpressionBuilderParameters parameters)
        {
            Expression ret=null;

            List<Type> subTypes=GetSubTypes(parameters).ToList<Type>();
            Type subtype=subTypes.FirstOrDefault<Type>(t => t!=null);
            subTypes=subTypes.Select<Type, Type>(t => t==null ? subtype : t).ToList<Type>();

            // Custom implementation
            if (parameters.OperatorImplementationProvider!=null)
            {
                List<object> paramValues=GetConstants(parameters).ToList<object>();
                string opname=GetCustomImplementationName(subTypes, paramValues);

                Type[] types=subTypes.ToArray();
                object[] values=paramValues.ToArray();
                object instance;
                MethodInfo method=parameters.OperatorImplementationProvider.GetImplementation(opname, ref types, ref values, out instance);
                if (method!=null)
                {
                    Debug.Assert(types.Length==values.Length);
                    using (IEnumerator<IExpressionBuilder> children=GetEnumerator())
                    {
                        IEnumerator v=values.GetEnumerator();
                        IEnumerator t=types.GetEnumerator();
                        LinkedList<Expression> subexpr=new LinkedList<Expression>();

                        while (v.MoveNext() && t.MoveNext())
                        {
                            children.MoveNext();
                            if (v.Current==null)
                                subexpr.AddLast(
                                    children.Current.CreateExpression(parameters, (Type)t.Current, (e, p) => CustomCallback(children, subexpr, t, v, e, p, method, instance, parameters))
                                );
                            else
                                subexpr.AddLast(Expression.Constant(v.Current, (Type)t.Current));
                        }

                        if (subexpr.First!=subexpr.Last)
                            ret=CreateCustomExpression(method, instance, subexpr, parameters, subtype);
                        else
                            ret=subexpr.First.Value;
                    }
                }
            }

            // Standard implementation
            if (ret==null)
                using (IEnumerator<IExpressionBuilder> children=GetEnumerator())
                {
                    LinkedList<Expression> subexpr=new LinkedList<Expression>();

                    while (children.MoveNext())
                        subexpr.AddLast(
                            children.Current.CreateExpression(parameters, subtype, (e, p) => StandardCallback(children, subexpr, e, p, parameters, subtype))
                        );

                    if (subexpr.First!=subexpr.Last)
                        ret=CreateStandardExpression(subexpr, parameters, subtype);
                    else
                        ret=subexpr.First.Value;
                }

            return ret;
        }

        protected abstract Expression CreateStandardExpression(IEnumerable<Expression> subexpr, ExpressionBuilderParameters parameters, Type subType);
        protected abstract string GetCustomImplementationName(List<Type> paramTypes, List<object> paramValues);

        protected virtual IEnumerator<IExpressionBuilder> GetEnumerator()
        {
            return Node.ChildNodes.Cast<IExpressionBuilder>().GetEnumerator();
        }

        protected virtual Expression CreateCustomExpression(MethodInfo method, object instance, IEnumerable<Expression> subexpr, ExpressionBuilderParameters parameters, Type subType)
        {
            Expression op=null;
            if (instance!=null)
                op=Expression.Call(
                    Expression.Constant(instance),
                    method,
                    subexpr
                );
            else
                op=Expression.Call(
                    method,
                    subexpr
                );
            return op;
        }

        protected IEnumerable<Type> GetSubTypes(ExpressionBuilderParameters parameters)
        {
            using (IEnumerator<IExpressionBuilder> children=GetEnumerator())
                while (children.MoveNext())
                    yield return children.Current.GetExpressionStaticType(parameters);
        }

        protected IEnumerable<object> GetConstants(ExpressionBuilderParameters parameters)
        {
            using (IEnumerator<IExpressionBuilder> children=GetEnumerator())
                while (children.MoveNext())
                {
                    object ret=null;

                    Expression exp=children.Current.CreateExpression(parameters, null, null);
                    if ((exp!=null) && (exp.NodeType==LinqExpressionType.Constant))
                        ret=((ConstantExpression)exp).Value;

                    yield return ret;
                }
        }

        private Expression CustomCallback(IEnumerator<IExpressionBuilder> children, LinkedList<Expression> subexpr, IEnumerator types, IEnumerator vals, Expression basexp, ParameterExpression pexp, MethodInfo method, object instance, ExpressionBuilderParameters parameters)
        {
            Expression ret=basexp;

            if (pexp!=null)
            {
                Expression sub=null;
                bool hasNext=vals.MoveNext() && types.MoveNext();
                if (hasNext)
                {
                    children.MoveNext();
                    if (vals.Current==null)
                        sub=children.Current.CreateExpression(parameters, (Type)types.Current, (e, p) => CustomCallback(children, subexpr, types, vals, e, p, method, instance, parameters));
                    else
                        sub=CustomCallback(children, subexpr, types, vals, Expression.Constant(vals.Current, (Type)types.Current), null, method, instance, parameters);
                } else
                {
                    sub=subexpr.Last.Value;
                    subexpr.RemoveLast();
                }
                ret=CreateCustomExpression(method, instance, new Expression[] { ret, sub }, parameters, (Type)types.Current);
                if (!hasNext)
                    subexpr.AddLast(ret);
            }

            return ret;
        }

        private Expression StandardCallback(IEnumerator<IExpressionBuilder> children, LinkedList<Expression> subexpr, Expression basexp, ParameterExpression pexp, ExpressionBuilderParameters parameters, Type expectedStaticType)
        {
            Expression ret=basexp;

            if (pexp!=null)
            {
                Expression sub=null;
                bool hasNext=children.MoveNext();
                if (hasNext)
                {
                    sub=children.Current.CreateExpression(parameters, expectedStaticType, (e, p) => StandardCallback(children, subexpr, e, p, parameters, expectedStaticType));
                } else
                {
                    sub=subexpr.Last.Value;
                    subexpr.RemoveLast();
                }
                ret=CreateStandardExpression(new Expression[] { ret, sub }, parameters, expectedStaticType);
                if (!hasNext)
                    subexpr.AddLast(ret);
            }

            return ret;
        }

        IEnumerator<IExpressionBuilder> IEnumerable<IExpressionBuilder>.GetEnumerator()
        {
            return GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        protected TNode Node
        {
            get
            {
                return _Node;
            }
        }

        private TNode _Node;
    }
}
