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
using System.Diagnostics.CodeAnalysis;

namespace GeoSik.Ogc.WebCatalog.Csw.V202
{

    public sealed class CoreQueryable:
        CswQueryable
    {

        [SuppressMessage("Microsoft.Performance", "CA1810:InitializeReferenceTypeStaticFieldsInline")]
        static CoreQueryable()
        {
            AddQueryable(Subject.Name, Subject);
            AddQueryable(Title.Name, Title);
            AddQueryable(Abstract.Name, Abstract);
            AddQueryable(AnyText.Name, AnyText);
            AddQueryable(Format.Name, Format);
            AddQueryable(Identifier.Name, Identifier);
            AddQueryable(Modified.Name, Modified);
            AddQueryable(Type.Name, Type);
            AddQueryable(BoundingBox.Name, BoundingBox);
            AddQueryable(Crs.Name, Crs);
            AddQueryable(Association.Name, Association);
        }

        private CoreQueryable(string name, Type type) :
            base(name, type)
        { }

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
