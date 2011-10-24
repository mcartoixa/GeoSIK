using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OgcToolkit.Services
{

    public class OwsDescriptionAttribute:
        Attribute
    {

        public OwsDescriptionAttribute(string service, string version)
        {
            Service=service;
            Version=version;
        }

        public string Service
        {
            get;
            set;
        }

        public string Version
        {
            get;
            set;
        }
    }
}
