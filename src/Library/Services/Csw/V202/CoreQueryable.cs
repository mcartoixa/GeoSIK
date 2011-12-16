﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using Microsoft.SqlServer.Types;

namespace OgcToolkit.Services.Csw.V202
{

    public class CoreQueryable
    {
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

        private static readonly Dictionary<string, CoreQueryable> _Queryables;

        public static readonly CoreQueryable Subject=new CoreQueryable(CoreQueryableNames.Subject, typeof(string));
        public static readonly CoreQueryable Title=new CoreQueryable(CoreQueryableNames.Title, typeof(string));
        public static readonly CoreQueryable Abstract=new CoreQueryable(CoreQueryableNames.Abstract, typeof(string));
        public static readonly CoreQueryable AnyText=new CoreQueryable(CoreQueryableNames.AnyText, typeof(string));
        public static readonly CoreQueryable Format=new CoreQueryable(CoreQueryableNames.Format, typeof(string));
        public static readonly CoreQueryable Identifier=new CoreQueryable(CoreQueryableNames.Identifier, typeof(Uri));
        public static readonly CoreQueryable Modified=new CoreQueryable(CoreQueryableNames.Modified, typeof(DateTime));
        public static readonly CoreQueryable Type=new CoreQueryable(CoreQueryableNames.Type, typeof(string));
        public static readonly CoreQueryable BoundingBox=new CoreQueryable(CoreQueryableNames.BoundingBox, typeof(SqlGeometry));
        public static readonly CoreQueryable Crs=new CoreQueryable(CoreQueryableNames.Crs, typeof(string));
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