<%@ Page Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeFile="Department.aspx.cs" Inherits="Pages_Department"  Title="Department" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageTitleContentPlaceHolder" runat="Server">Department</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" runat="Server">
  <div data-flow="NewRow">
    <div id="view1" runat="server"></div>
    <aquarium:DataViewExtender id="view1Extender" runat="server" TargetControlID="view1" Controller="Department" view="grid1" ShowInSummary="True" SelectionMode="Multiple" SearchOnStart="True" />
  </div>
  <div data-flow="NewRow" style="padding-top:8px">
    <div data-activator="Tab|Department">
      <div id="view2" runat="server"></div>
      <aquarium:DataViewExtender id="view2Extender" runat="server" TargetControlID="view2" Controller="Department" view="grid1" FilterSource="view1Extender" FilterFields="ParrentId" PageSize="5" SelectionMode="Multiple" AutoHide="Container" ShowModalForms="True" />
    </div>
    <div data-activator="Tab|Employee">
      <div id="view3" runat="server"></div>
      <aquarium:DataViewExtender id="view3Extender" runat="server" TargetControlID="view3" Controller="Employee" view="grid1" FilterSource="view1Extender" FilterFields="DepartmentId" PageSize="5" SelectionMode="Multiple" AutoHide="Container" ShowModalForms="True" />
    </div>
  </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="SideBarPlaceHolder" runat="Server">
  <div class="TaskBox About">
    <div class="Inner">
      <div class="Header">About</div>
      <div class="Value">This page allows department management.</div>
    </div>
  </div>
</asp:Content>