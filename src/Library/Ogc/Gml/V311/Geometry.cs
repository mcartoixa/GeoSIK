using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using Microsoft.SqlServer.Types;

namespace OgcToolkit.Ogc.Gml.V311
{

#pragma warning disable 3008, 3009
    partial class _Geometry:
        IGeometryProvider
    {

        internal protected abstract void Populate(IGeometrySink sink);

        public virtual SqlGeometry Geometry
        {
            get
            {
                var builder=new SqlGeometryBuilder();
                if (srsName!=null)
                    builder.SetSrid(Srid.CreateFromCrs(srsName).Value);
                else
                    builder.SetSrid(0);

                Populate(builder);

                return builder.ConstructedGeometry;
            }
            set
            {
                Untyped=XElement.Parse(value.AsGml().Value, LoadOptions.None);
            }
        }
    }
#pragma warning restore 3008, 3009
}
