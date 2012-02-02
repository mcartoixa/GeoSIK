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
using System.Linq;
using System.Text;
using Irony.Interpreter;
using Irony.Interpreter.Ast;
using Irony.Parsing;

namespace GeoSik.Ogc.WebCatalog.Cql.Ast
{

#pragma warning disable 3001, 3009
    public class DateTimePeriodNode:
        AstNode
    {

        public override void Init(ParsingContext context, ParseTreeNode treeNode)
        {
            base.Init(context, treeNode);

            AstNode sn=AddChild("from", treeNode.MappedChildNodes[0]);
            AstNode en=AddChild("to", treeNode.MappedChildNodes[2]);

            var dtsn=sn as DateTimeLiteralNode;
            var dten=en as DateTimeLiteralNode;
            if (dtsn!=null)
            {
                _StartDate=dtsn.Value;

                if (dten!=null)
                    _EndDate=dten.Value;
                else
                    _EndDate=_StartDate+((DurationLiteralNode)en).Value;
            } else
            {
                _EndDate=dten.Value;
                _StartDate=_EndDate-((DurationLiteralNode)sn).Value;
            }

            AsString="period";
        }

        public DateTime StartDate
        {
            get
            {
                return _StartDate;
            }
        }

        public DateTime EndDate
        {
            get
            {
                return _EndDate;
            }
        }

        private DateTime _StartDate;
        private DateTime _EndDate;
    }
#pragma warning restore 3001, 3009
}
