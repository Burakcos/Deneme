<%@ Page Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeFile="Hierarchy.aspx.cs" Inherits="Pages_Hierarchy"  Title="Hierarchy" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageTitleContentPlaceHolder" runat="Server">Hierarchy</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" runat="Server">
  <div data-flow="NewRow">
    <div id="view1" runat="server"></div>
    <aquarium:DataViewExtender id="view1Extender" runat="server" TargetControlID="view1" Controller="Locations" view="" />
  </div>
</asp:Content>