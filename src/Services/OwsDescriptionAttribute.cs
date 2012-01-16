using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OgcToolkit.Services
{

    [AttributeUsage(AttributeTargets.Class)]
    public sealed class OwsDescriptionAttribute:
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
            private set;
        }

        public string Version
        {
            get;
            private set;
        }
    }
}
