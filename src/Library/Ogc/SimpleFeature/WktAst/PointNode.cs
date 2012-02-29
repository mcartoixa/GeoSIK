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
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using Irony.Ast;
using Irony.Interpreter;
using Irony.Interpreter.Ast;
using Irony.Parsing;

namespace GeoSik.Ogc.SimpleFeature.WktAst
{



    ////////////////////////////////////////////////////////////////////////////
    ///
    /// <summary>AST node for a point.</summary>
    ///
    ////////////////////////////////////////////////////////////////////////////

#pragma warning disable 3009
    public class PointNode:
        AstNode
    {

        /// <summary>Initializes the current AST node with the specified <paramref name="context" /> and <paramref name="treeNode" />.</summary>
        /// <param name="context">The AST context.</param>
        /// <param name="treeNode">The parse tree node associated with the current AST node.</param>
        public override void Init(AstContext context, ParseTreeNode treeNode)
        {
            base.Init(context, treeNode);

            X=Convert.ToDouble(((LiteralValueNode)treeNode.ChildNodes[0].AstNode).Value, CultureInfo.InvariantCulture);
            Y=Convert.ToDouble(((LiteralValueNode)treeNode.ChildNodes[1].AstNode).Value, CultureInfo.InvariantCulture);
            AsString=string.Format(
                CultureInfo.InvariantCulture,
                "{0} {1}",
                X,
                Y
            );
        }

        /// <summary>Gets the easting of the current point.</summary>
        public double X
        {
            get;
            private set;
        }

        /// <summary>Gets the northing of the current point.</summary>
        public double Y
        {
            get;
            private set;
        }
    }
#pragma warning restore 3009
}
