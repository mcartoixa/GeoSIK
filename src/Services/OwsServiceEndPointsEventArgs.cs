using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OgcToolkit.Services
{

    public class OwsServiceEndPointsEventArgs:
        EventArgs
    {
        public OwsServiceEndPointsEventArgs()
        {
            EndPoints=new List<OwsEndPoint>();
        }

        public IList<OwsEndPoint> EndPoints
        {
            get;
            private set;
        }
    }

    public class OwsEndPoint
    {
        public Uri BaseUri
        {
            get;
            set;
        }

        public bool AddOperationName
        {
            get;
            set;
        }

        public OwsMethod Method
        {
            get;
            set;
        }
    }

    public enum OwsMethod
    {
        Get,
        Xml,
        Soap
    }
}
