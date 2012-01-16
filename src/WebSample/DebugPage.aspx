<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DebugPage.aspx.cs" Inherits="OgcToolkit.WebSample.DebugPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
  <asp:Button ID="Button1" runat="server" onclick="Button1_Click" 
    Text="Recycle" />
  <br />
  <asp:Label ID="_Label1" runat="server"></asp:Label>
</asp:Content>
