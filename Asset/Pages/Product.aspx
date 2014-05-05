<%@ Page Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeFile="Product.aspx.cs" Inherits="Pages_Product"  Title="Product" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageTitleContentPlaceHolder" runat="Server">Product</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" runat="Server">
  <div data-flow="NewRow">
    <div id="view1" runat="server"></div>
    <aquarium:DataViewExtender id="view1Extender" runat="server" TargetControlID="view1" Controller="Product" view="grid1" ShowInSummary="True" SelectionMode="Multiple" SearchOnStart="True" />
  </div>
  <div data-flow="NewRow" style="padding-top:8px">
    <div data-activator="Tab|Product">
      <div id="view2" runat="server"></div>
      <aquarium:DataViewExtender id="view2Extender" runat="server" TargetControlID="view2" Controller="Product" view="grid1" FilterSource="view1Extender" FilterFields="ParrentId" PageSize="5" SelectionMode="Multiple" AutoHide="Container" ShowModalForms="True" />
    </div>
  </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="SideBarPlaceHolder" runat="Server">
  <div class="TaskBox About">
    <div class="Inner">
      <div class="Header">About</div>
      <div class="Value">This page allows product management.</div>
    </div>
  </div>
</asp:Content>