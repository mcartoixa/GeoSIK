using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace OgcToolkit.Ogc.WebCatalog.Cql.Ast
{

    internal class CombinedExpressionCreator:
        IExpressionCreator
    {

        public CombinedExpressionCreator(IEnumerable<IExpressionCreator> creators, ExpressionType combinator)
        {
            Debug.Assert(creators!=null);
            if (creators==null)
                throw new ArgumentNullException("creators");

            _Creators=creators;
            _Combinator=combinator;
        }

        public Expression CreateExpression(ExpressionBuilderParameters parameters)
        {
            Expression ret=null;

            foreach (IExpressionCreator c in _Creators)
                if (ret!=null)
                    ret=Expression.MakeBinary(
                        _Combinator,
                        ret,
                        c.CreateExpression(parameters)
                    );
                else
                    ret=c.CreateExpression(parameters);

            return ret;
        }

        public IEnumerator<IExpressionBuilder> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        private IEnumerable<IExpressionCreator> _Creators;
        private ExpressionType _Combinator;
    }
}
