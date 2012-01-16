using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.SqlServer.Types;

namespace OgcToolkit
{

    public interface IGeometryProvider
    {

        SqlGeometry Geometry { get; }
    }
}
