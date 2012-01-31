<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeBehind="Default.aspx.cs" Inherits="OgcToolkit.WebSample._Default" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <h2>
        Queries
    </h2>
    <h3>GetCapabilities</h3>
    <asp:HyperLink ID="_Query1" runat="server" NavigateUrl="~/Services/Ows.svc/?service=CSW&version=2.0.2&request=GetCapabilities" 
      Target="_blank">Capabilities</asp:HyperLink>
    <h3>GetRecords</h3>
    <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Services/Ows.svc/?service=CSW&version=2.0.2&request=GetRecords&namespace=xmlns(csw=http%3A%2F%2Fwww.opengis.net%2Fcat%2Fcsw%2F2.0.2)&typeNames=csw%3ARecord&resultType=results" 
      Target="_blank">All</asp:HyperLink><br />
    <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/Services/Ows.svc/?service=CSW&version=2.0.2&request=GetRecords&namespace=xmlns(csw=http%3A%2F%2Fwww.opengis.net%2Fcat%2Fcsw%2F2.0.2),xmlns(dc=http%3A%2F%2Fpurl.org%2Fdc%2Felements%2F1.1%2F),xmlns(ogc=http%3A%2F%2Fwww.opengis.net%2Fogc)&typeNames=csw%3ARecord&resultType=results&constraintLanguage=FILTER&constraint=%3Cogc%3AFilter%3E%3Cogc%3APropertyIsEqualTo%3E%3Cogc%3APropertyName%3EType%3C%2Fogc%3APropertyName%3E%3Cogc%3ALiteral%3Ehttp%3A%2F%2Fpurl.org%2Fdc%2Fdcmitype%2FImage%3C%2Fogc%3ALiteral%3E%3C%2Fogc%3APropertyIsEqualTo%3E%3C%2Fogc%3AFilter%3E" 
      Target="_blank">Filter Type = http://purl.org/dc/dcmitype/Image</asp:HyperLink><br />
    <asp:HyperLink ID="HyperLink4" runat="server" NavigateUrl="~/Services/Ows.svc/?service=CSW&version=2.0.2&request=GetRecords&namespace=xmlns(csw=http%3A%2F%2Fwww.opengis.net%2Fcat%2Fcsw%2F2.0.2),xmlns(dc=http%3A%2F%2Fpurl.org%2Fdc%2Felements%2F1.1%2F),xmlns(ogc=http%3A%2F%2Fwww.opengis.net%2Fogc)&typeNames=csw%3ARecord&resultType=results&constraintLanguage=CQL_TEXT&constraint=Type%3D'http%3A%2F%2Fpurl.org%2Fdc%2Fdcmitype%2FImage'" 
      Target="_blank">CQL Type = http://purl.org/dc/dcmitype/Image</asp:HyperLink><br />
    <asp:HyperLink ID="HyperLink5" runat="server" NavigateUrl="~/Services/Ows.svc/?service=CSW&version=2.0.2&request=GetRecords&namespace=xmlns(csw=http%3A%2F%2Fwww.opengis.net%2Fcat%2Fcsw%2F2.0.2),xmlns(dc=http%3A%2F%2Fpurl.org%2Fdc%2Felements%2F1.1%2F),xmlns(ogc=http%3A%2F%2Fwww.opengis.net%2Fogc)&typeNames=csw%3ARecord&resultType=results&constraintLanguage=FILTER&constraint=%3Cogc%3AFilter%3E%3Cogc%3APropertyIsEqualTo%20matchCase=%22true%22%3E%3Cogc%3APropertyName%3ESubject%3C%2Fogc%3APropertyName%3E%3Cogc%3ALiteral%3Ephysiography%3C%2Fogc%3ALiteral%3E%3C%2Fogc%3APropertyIsEqualTo%3E%3C%2Fogc%3AFilter%3E" 
      Target="_blank">Filter Subject = physiography (case sensitive)</asp:HyperLink><br />
    <asp:HyperLink ID="HyperLink8" runat="server" NavigateUrl="~/Services/Ows.svc/?service=CSW&version=2.0.2&request=GetRecords&namespace=xmlns(csw=http%3A%2F%2Fwww.opengis.net%2Fcat%2Fcsw%2F2.0.2),xmlns(dc=http%3A%2F%2Fpurl.org%2Fdc%2Felements%2F1.1%2F),xmlns(ogc=http%3A%2F%2Fwww.opengis.net%2Fogc)&typeNames=csw%3ARecord&resultType=results&constraintLanguage=FILTER&constraint=%3Cogc%3AFilter%3E%3Cogc%3APropertyIsEqualTo%20matchCase=%22false%22%3E%3Cogc%3APropertyName%3ESubject%3C%2Fogc%3APropertyName%3E%3Cogc%3ALiteral%3Ephysiography%3C%2Fogc%3ALiteral%3E%3C%2Fogc%3APropertyIsEqualTo%3E%3C%2Fogc%3AFilter%3E" 
      Target="_blank">Filter Subject = physiography (case insensitive)</asp:HyperLink><br />
    <asp:HyperLink ID="HyperLink6" runat="server" NavigateUrl="~/Services/Ows.svc/?service=CSW&version=2.0.2&request=GetRecords&namespace=xmlns(csw=http%3A%2F%2Fwww.opengis.net%2Fcat%2Fcsw%2F2.0.2),xmlns(dc=http%3A%2F%2Fpurl.org%2Fdc%2Felements%2F1.1%2F),xmlns(ogc=http%3A%2F%2Fwww.opengis.net%2Fogc)&typeNames=csw%3ARecord&resultType=results&constraintLanguage=FILTER&constraint=%3Cogc%3AFilter%3E%3Cogc%3APropertyIsEqualTo%3E%3Cogc%3APropertyName%3E%2Fcsw%3ARecord%2Fdc%3Asubject%2F@scheme%3C%2Fogc%3APropertyName%3E%3Cogc%3ALiteral%3Ehttp%3A%2F%2Fwww.digest.org%2F2.1%3C%2Fogc%3ALiteral%3E%3C%2Fogc%3APropertyIsEqualTo%3E%3C%2Fogc%3AFilter%3E" 
      Target="_blank">Filter /csw:Record/dc:subject/@scheme = http://www.digest.org/2.1</asp:HyperLink><br />
    <asp:HyperLink ID="HyperLink7" runat="server" NavigateUrl="~/Services/Ows.svc/?service=CSW&version=2.0.2&request=GetRecords&namespace=xmlns(csw=http%3A%2F%2Fwww.opengis.net%2Fcat%2Fcsw%2F2.0.2),xmlns(dc=http%3A%2F%2Fpurl.org%2Fdc%2Felements%2F1.1%2F),xmlns(ogc=http%3A%2F%2Fwww.opengis.net%2Fogc),xmlns(ows=http%3A%2F%2Fwww.opengis.net%2Fows),xmlns(gml=http%3A%2F%2Fwww.opengis.net%2Fgml)&typeNames=csw%3ARecord&resultType=results&constraintLanguage=FILTER&constraint=%3Cogc%3AFilter%3E%3Cogc%3ABBOX%3E%3Cogc%3APropertyName%3E%2Fcsw%3ARecord%2Fows%3ABoundingBox%3C%2Fogc%3APropertyName%3E%3Cgml%3AEnvelope srsName=%22urn%3Ax-ogc%3Adef%3Acrs%3AEPSG%3A6.11%3A4326%22%3E%3Cgml%3AlowerCorner%3E47.0 -4.5%3C%2Fgml%3AlowerCorner%3E%3Cgml%3AupperCorner%3E52.0 1.0%3C%2Fgml%3AupperCorner%3E%3C%2Fgml%3AEnvelope%3E%3C%2Fogc%3ABBOX%3E%3C%2Fogc%3AFilter%3E" 
      Target="_blank">Filter /csw:Record/ows:BoundingBox BBOX LINESTRING(47.0 -4.5, 52.0 1.0)</asp:HyperLink>
    <h3>GetRecordById</h3>
    <asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="~/Services/Ows.svc/?service=CSW&version=2.0.2&request=GetRecordById&id=urn:uuid:88247b56-4cbc-4df9-9860-db3f8042e357" 
      Target="_blank">urn:uuid:88247b56-4cbc-4df9-9860-db3f8042e357</asp:HyperLink>
</asp:Content>
