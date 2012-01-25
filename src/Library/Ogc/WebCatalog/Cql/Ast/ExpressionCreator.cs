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

namespace OgcToolkit.Ogc.WebCatalog.Cql.Ast
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
                        LinkedList<Expression> opparams=new LinkedList<Expression>();

                        while (v.MoveNext() && t.MoveNext())
                        {
                            children.MoveNext();
                            if (v.Current==null)
                                subexpr.AddLast(
                                    children.Current.CreateExpression(parameters, (Type)t.Current, e => CustomCallback(children, t, v, opparams.AddLast(e), method, instance, parameters))
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
                    LinkedList<Expression> opparams=new LinkedList<Expression>();

                    // This algorithm will not work for operators that take more than 2 parameters (?) and mix collection references with plain parameters...
                    while (children.MoveNext())
                        subexpr.AddLast(
                            children.Current.CreateExpression(parameters, subtype, e => StandardCallback(children, opparams.AddLast(e), parameters, subtype))
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

        private Expression CustomCallback(IEnumerator<IExpressionBuilder> children, IEnumerator types, IEnumerator vals, LinkedListNode<Expression> inparam, MethodInfo method, object instance, ExpressionBuilderParameters parameters)
        {
            Expression ret=inparam.Value;

            if (ret is ParameterExpression)
            {
                if (vals.MoveNext() && types.MoveNext())
                {
                    children.MoveNext();
                    if (vals.Current==null)
                        ret=children.Current.CreateExpression(parameters, (Type)types.Current, e => CustomCallback(children, types, vals, inparam.List.AddLast(e), method, instance, parameters));
                    else
                        ret=CustomCallback(children, types, vals, inparam.List.AddLast(Expression.Constant(vals.Current, (Type)types.Current)), method, instance, parameters);
                } else
                    ret=CreateCustomExpression(method, instance, inparam.List, parameters, (Type)types.Current);
            }

            return ret;
        }

        private Expression StandardCallback(IEnumerator<IExpressionBuilder> children, LinkedListNode<Expression> inparam, ExpressionBuilderParameters parameters, Type expectedStaticType)
        {
            Expression ret=inparam.Value;

            if (ret is ParameterExpression)
            {
                if (children.MoveNext())
                    ret=children.Current.CreateExpression(parameters, expectedStaticType, e => StandardCallback(children, inparam.List.AddLast(e), parameters, expectedStaticType));
                else
                    ret=CreateStandardExpression(inparam.List, parameters, expectedStaticType);
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
