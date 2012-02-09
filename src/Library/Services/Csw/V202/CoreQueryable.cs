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
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Linq;
using System.Text;

namespace GeoSik.Services.Csw.V202
{

    public class CoreQueryable
    {

        [SuppressMessage("Microsoft.Performance", "CA1810:InitializeReferenceTypeStaticFieldsInline")]
        static CoreQueryable()
        {
            _Queryables=new Dictionary<string, CoreQueryable>(11);
            _Queryables.Add(Subject.Name, Subject);
            _Queryables.Add(Title.Name, Title);
            _Queryables.Add(Abstract.Name, Abstract);
            _Queryables.Add(AnyText.Name, AnyText);
            _Queryables.Add(Format.Name, Format);
            _Queryables.Add(Identifier.Name, Identifier);
            _Queryables.Add(Modified.Name, Modified);
            _Queryables.Add(Type.Name, Type);
            _Queryables.Add(BoundingBox.Name, BoundingBox);
            _Queryables.Add(Crs.Name, Crs);
            _Queryables.Add(Association.Name, Association);
        }

        private CoreQueryable()
        {
        }

        internal CoreQueryable(string name, Type type):
            base()
        {
            Name=name;
            QueryableType=type;
        }

        public static CoreQueryable GetFromName(string name)
        {
            return _Queryables[name];
        }

        public static bool IsValidName(string name)
        {
            return _Queryables.ContainsKey(name);
        }

        public string Name
        {
            get;
            private set;
        }

        public Type QueryableType
        {
            get;
            private set;
        }

        private static Dictionary<string, CoreQueryable> _Queryables;

        [SuppressMessage("Microsoft.Security", "CA2104:DoNotDeclareReadOnlyMutableReferenceTypes", Justification="This is an immutable type")]
        public static readonly CoreQueryable Subject=new CoreQueryable(CoreQueryableNames.Subject, typeof(string));
        [SuppressMessage("Microsoft.Security", "CA2104:DoNotDeclareReadOnlyMutableReferenceTypes", Justification="This is an immutable type")]
        public static readonly CoreQueryable Title=new CoreQueryable(CoreQueryableNames.Title, typeof(string));
        [SuppressMessage("Microsoft.Security", "CA2104:DoNotDeclareReadOnlyMutableReferenceTypes", Justification="This is an immutable type")]
        public static readonly CoreQueryable Abstract=new CoreQueryable(CoreQueryableNames.Abstract, typeof(string));
        [SuppressMessage("Microsoft.Security", "CA2104:DoNotDeclareReadOnlyMutableReferenceTypes", Justification="This is an immutable type")]
        public static readonly CoreQueryable AnyText=new CoreQueryable(CoreQueryableNames.AnyText, typeof(string));
        [SuppressMessage("Microsoft.Security", "CA2104:DoNotDeclareReadOnlyMutableReferenceTypes", Justification="This is an immutable type")]
        public static readonly CoreQueryable Format=new CoreQueryable(CoreQueryableNames.Format, typeof(string));
        [SuppressMessage("Microsoft.Security", "CA2104:DoNotDeclareReadOnlyMutableReferenceTypes", Justification="This is an immutable type")]
        public static readonly CoreQueryable Identifier=new CoreQueryable(CoreQueryableNames.Identifier, typeof(Uri));
        [SuppressMessage("Microsoft.Security", "CA2104:DoNotDeclareReadOnlyMutableReferenceTypes", Justification="This is an immutable type")]
        public static readonly CoreQueryable Modified=new CoreQueryable(CoreQueryableNames.Modified, typeof(DateTime));
        [SuppressMessage("Microsoft.Security", "CA2104:DoNotDeclareReadOnlyMutableReferenceTypes", Justification="This is an immutable type")]
        public static readonly CoreQueryable Type=new CoreQueryable(CoreQueryableNames.Type, typeof(string));
        [SuppressMessage("Microsoft.Security", "CA2104:DoNotDeclareReadOnlyMutableReferenceTypes", Justification="This is an immutable type")]
        public static readonly CoreQueryable BoundingBox=new CoreQueryable(CoreQueryableNames.BoundingBox, typeof(IGeometry));
        [SuppressMessage("Microsoft.Security", "CA2104:DoNotDeclareReadOnlyMutableReferenceTypes", Justification="This is an immutable type")]
        public static readonly CoreQueryable Crs=new CoreQueryable(CoreQueryableNames.Crs, typeof(string));
        [SuppressMessage("Microsoft.Security", "CA2104:DoNotDeclareReadOnlyMutableReferenceTypes", Justification="This is an immutable type")]
        public static readonly CoreQueryable Association=new CoreQueryable(CoreQueryableNames.Association, typeof(string));
    }

    public static class CoreQueryableNames
    {

        public const string Subject="Subject";
        public const string Title="Title";
        public const string Abstract="Abstract";
        public const string AnyText="AnyText";
        public const string Format="Format";
        public const string Identifier="Identifier";
        public const string Modified="Modified";
        public const string Type="Type";
        public const string BoundingBox="BoundingBox";
        public const string Crs="CRS";
        public const string Association="Association";
    }
}
