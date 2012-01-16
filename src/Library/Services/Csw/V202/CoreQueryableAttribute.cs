using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OgcToolkit.Services.Csw.V202
{

    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, Inherited=true, AllowMultiple=true)]
    public sealed class CoreQueryableAttribute:
        Attribute
    {

        private CoreQueryableAttribute(CoreQueryable queryable)
        {
            Queryable=queryable;
        }

        public CoreQueryableAttribute(string queryableName)
        {
            Queryable=CoreQueryable.GetFromName(queryableName);
        }

        public CoreQueryable Queryable
        {
            get;
            private set;
        }
    }
}
