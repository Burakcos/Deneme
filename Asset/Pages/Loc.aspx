<%@ Page Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeFile="Loc.aspx.cs" Inherits="Pages_Loc"  Title="Loc" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageTitleContentPlaceHolder" runat="Server">Loc</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" runat="Server">
  <div data-flow="NewRow">
    <div id="view1" runat="server"></div>
    <aquarium:DataViewExtender id="view1Extender" runat="server" TargetControlID="view1" Controller="Locations" view="" />
  </div>
</asp:Content>