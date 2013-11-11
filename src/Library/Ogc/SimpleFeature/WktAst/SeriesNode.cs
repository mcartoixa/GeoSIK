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
    /// <summary>AST node for a series of nodes.</summary>
    ///
    ////////////////////////////////////////////////////////////////////////////

#pragma warning disable 3009
    public sealed class SeriesNode:
        AstNode,
        IEnumerable<ParseTreeNode>
    {

        /// <summary>Initializes the current AST node with the specified <paramref name="context" /> and <paramref name="treeNode" />.</summary>
        /// <param name="context">The AST context.</param>
        /// <param name="treeNode">The parse tree node associated with the current AST node.</param>
        public override void Init(AstContext context, ParseTreeNode treeNode)
        {
            base.Init(context, treeNode);

            _Nodes=treeNode.ChildNodes;

            foreach (ParseTreeNode n in _Nodes)
                AddChild("", n);
        }

        private IEnumerator<ParseTreeNode> GetEnumerator()
        {
            return _Nodes.GetEnumerator();
        }

        IEnumerator<ParseTreeNode> IEnumerable<ParseTreeNode>.GetEnumerator()
        {
            return GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        private List<ParseTreeNode> _Nodes;
    }
#pragma warning restore 3009
}
