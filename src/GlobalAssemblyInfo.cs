using System;
using System.Reflection;
using System.Runtime.InteropServices;

[assembly: CLSCompliant(true)]

[assembly: AssemblyProduct("OGC Toolkit")]
[assembly: AssemblyCompany("Isogeo")]

#if DEBUG
[assembly: AssemblyConfiguration("Debug")]
#else
[assembly: AssemblyConfiguration("Release")]
#endif
[assembly: AssemblyCopyright("Copyright © 2011 Isogeo")]
[assembly: AssemblyTrademark("")]
