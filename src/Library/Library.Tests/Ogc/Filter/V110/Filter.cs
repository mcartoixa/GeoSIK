////////////////////////////////////////////////////////////////////////////////
//
// This file is part of OgcToolkit.
// Copyright (C) 2012 Isogeo
//
// OgcToolkit is free software: you can redistribute it and/or modify
// it under the terms of the GNU Lesser General Public License as published by
// the Free Software Foundation, either version 2 of the License, or
// (at your option) any later version.
//
// OgcToolkit is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU Lesser General Public License for more details.
//
// You should have received a copy of the GNU Lesser General Public License
// along with OgcToolkit. If not, see <http://www.gnu.org/licenses/>.
//
////////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Linq;
using Xunit;
using Xunit.Extensions;

namespace OgcToolkit.Ogc.Filter.V110.Tests
{

    public class FilterTests
    {

        internal static Filter CreateFilter(string constraint)
        {
            var namespaceManager=new XmlNamespaceManager(new NameTable());
            namespaceManager.AddNamespace(string.Empty, "http://www.opengis.net/ogc");
            namespaceManager.AddNamespace("ogc", "http://www.opengis.net/ogc");

            var ret=new Filter();
            ret.Untyped.Add(
                new XAttribute(XNamespace.Xmlns+"ogc", "http://www.opengis.net/ogc")
            );
            XmlParserContext context=new XmlParserContext(null, namespaceManager, null, XmlSpace.None);
            using (var r=new XmlTextReader(constraint, XmlNodeType.Element, context))
            {
                var c=XElement.Load(r);
                ret.Untyped.AddFirst(c);
            }

            return ret;
        }

        /// <summary>Creates a collection of <see cref="SimpleType" /> elements to be used in tests.</summary>
        /// <param name="number">The number of elements in the collection.</param>
        /// <returns>The collection of <see cref="SimpleType" /> elements to be used in tests.</returns>
        /// <remarks>
        ///   <para>There will be <paramref name="number" /> elements in the returned collection.
        /// Each <see cref="SimpleType" /> element is initialized according to its position <c>p</c> in the collection:
        /// <list type="bullet">
        ///   <item><description><see cref="SimpleType.Integer" /> is <c>p</c> represented as an <see cref="Int32" />.</description></item>
        ///   <item><description><see cref="SimpleType.String" /> is <c>p</c> represented as a <see cref="String" />.</description></item>
        ///   <item><description><see cref="SimpleType.IntegerList" /> is a collection of <see cref="Int32" /> elements, from <c>0</c> to <c>p</c>. It thus contains <c>p+1</c> elements.</description></item>
        ///   <item><description><see cref="SimpleType.PreviousList" /> is a collection of the <c>p-1</c> previous elements. For the first element (<c>p=0</c>), this list is empty.</description></item>
        /// </list>
        /// </para>
        /// </remarks>
        internal static IEnumerable<SimpleType> CreateCollection(int number)
        {
            var ret=new List<SimpleType>(number);
            for (int i=0; i<number; ++i)
            {
                var st=new SimpleType() {
                    String=i.ToString(CultureInfo.InvariantCulture),
                    Integer=i,
                    IntegerList=new int[i+1],
                    PreviousList=new List<SimpleType>(ret)
                };

                for (int j=0; j<=i; ++j)
                    st.IntegerList[j]=j;

                ret.Add(st);
            }
            return ret;
        }

        public class SimpleType
        {

            public string String { get; set; }
            public int Integer { get; set; }
            public IList<int> IntegerList { get; set; }
            public IList<SimpleType> PreviousList { get; set; }
        }
    }
}
