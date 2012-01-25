using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Xml;

namespace OgcToolkit.Ogc.Filter.V110
{

#pragma warning disable 3009
    partial class Function
    {

        internal protected override IExpressionCreator GetExpressionCreator()
        {
            throw new NotSupportedException(
                string.Format(
                    CultureInfo.CurrentCulture,
                    SR.UnsupportedFilterElement,
                    GetType().Name
                )
            );
        }
    }
#pragma warning restore 3009
}
