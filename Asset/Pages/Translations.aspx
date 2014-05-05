<%@ Page Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeFile="Translations.aspx.cs" Inherits="Pages_Translations"  Title="Translations" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageTitleContentPlaceHolder" runat="Server">Translations</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" runat="Server">
  <div data-flow="NewRow">
    <div id="view1" runat="server"></div>
    <aquarium:DataViewExtender id="view1Extender" runat="server" TargetControlID="view1" Controller="Translations" view="grid1" ShowInSummary="True" SelectionMode="Multiple" ShowModalForms="True" SearchOnStart="True" />
  </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="SideBarPlaceHolder" runat="Server">
  <div class="TaskBox About">
    <div class="Inner">
      <div class="Header">About</div>
      <div class="Value">This page allows translations management.</div>
    </div>
  </div>
</asp:Content>