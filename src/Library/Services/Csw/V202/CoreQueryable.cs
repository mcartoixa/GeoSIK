using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Linq;
using System.Text;
using Microsoft.SqlServer.Types;

namespace OgcToolkit.Services.Csw.V202
{

    public class CoreQueryable
    {

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

        private static Dictionary<string, CoreQueryable> InitQueryables()
        {
            var ret=new Dictionary<string, CoreQueryable>(11);
            ret.Add(Subject.Name, Subject);
            ret.Add(Title.Name, Title);
            ret.Add(Abstract.Name, Abstract);
            ret.Add(AnyText.Name, AnyText);
            ret.Add(Format.Name, Format);
            ret.Add(Identifier.Name, Identifier);
            ret.Add(Modified.Name, Modified);
            ret.Add(Type.Name, Type);
            ret.Add(BoundingBox.Name, BoundingBox);
            ret.Add(Crs.Name, Crs);
            ret.Add(Association.Name, Association);
            return ret;
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

        private static Dictionary<string, CoreQueryable> _Queryables=InitQueryables();

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
        public static readonly CoreQueryable BoundingBox=new CoreQueryable(CoreQueryableNames.BoundingBox, typeof(SqlGeometry));
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
