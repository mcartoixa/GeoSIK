PREREQUISITES
-------------

-Build:
	* Microsoft .NET Framework 4.0
	* Microsoft Windows SDK 7.1
	* MSBuild.Community.Tasks 1.3
	* FxCop 10.0
	* PartCover .NET4 <https://github.com/sawilde/partcover.net4>

- Development:
	* SQL Server Express 2008 R2



BUILD
-----

- Run the following command from this directory :
build.bat



DEVELOPMENT
-----------

- Build the project once (build.bat) before any development: NuGet packages will automatically be updated in your repository.

- Serialization:
	* Serialization objects found in the Library project have been generated with LinqToXsd <http://linqtoxsd.codeplex.com/> with a command line like the following:
LinqToXsd.exe iso\19139\20070417\gmd\gmd.xsd /config:LinqToXsd.config.xml /enableServiceReference
	* Original XML schemas can be found online at <http://schemas.opengis.net/>.
	* LinqToXsd configuration looks like the following:
<Configuration xmlns="http://www.microsoft.com/xml/schema/linq">
  <Namespaces>
    <Namespace Schema="http://www.opengis.net/gml" Clr="OgcToolkit.Ogc.Gml.V311" />
    <Namespace Schema="http://www.opengis.net/gml/3.2" Clr="OgcToolkit.Ogc.Gml.V321" />
    <Namespace Schema="http://www.opengis.net/ows" Clr="OgcToolkit.Ogc.Ows.V100" />
    <Namespace Schema="http://www.opengis.net/ogc" Clr="OgcToolkit.Ogc.Filter.V110" />
    <Namespace Schema="http://www.opengis.net/cat/csw/2.0.2" Clr="OgcToolkit.Ogc.WebCatalog.Csw.V202" />
    <Namespace Schema="http://www.isotc211.org/2005/gco" Clr="OgcToolkit.Iso.Ts19139.Gco" />
    <Namespace Schema="http://www.isotc211.org/2005/gmd" Clr="OgcToolkit.Iso.Ts19139.Gmd" />
    <Namespace Schema="http://www.isotc211.org/2005/gmx" Clr="OgcToolkit.Iso.Ts19139.Gmx" />
    <Namespace Schema="http://www.isotc211.org/2005/gsr" Clr="OgcToolkit.Iso.Ts19139.Gsr" />
    <Namespace Schema="http://www.isotc211.org/2005/gss" Clr="OgcToolkit.Iso.Ts19139.Gss" />
    <Namespace Schema="http://www.isotc211.org/2005/gts" Clr="OgcToolkit.Iso.Ts19139.Gts" />
    <Namespace Schema="http://www.w3.org/2001/SMIL20/" Clr="OgcToolkit.W3.Smil20" />
    <Namespace Schema="http://www.w3.org/2001/SMIL20/Language" Clr="OgcToolkit.W3.Smil20.Language" />
    <Namespace Schema="http://purl.org/dc/elements/1.1/" Clr="OgcToolkit.DublinCore.Elements.V11" />
    <Namespace Schema="http://purl.org/dc/terms/" Clr="OgcToolkit.DublinCore.Terms" />
  </Namespaces>
</Configuration>
	* Code generation has not been made part of the build as:
		. Generation is somewhat buggy and some generated objects have been manually tweaked.
		. Sometimes the schemas themselves have been tweaked for the generation to work...