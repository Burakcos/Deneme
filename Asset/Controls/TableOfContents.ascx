﻿<%@ Control Language="C#" AutoEventWireup="true" CodeFile="TableOfContents.ascx.cs" Inherits="Controls_TableOfContents"  %>
            
<div class="ParaInfo">
        ^TocInstruction^Please select a page link in the table of contents below.^TocInstruction^</div>
<div class="ParaHeader">
    ^TocHeader^Site Map^TocHeader^
</div>
<asp:SiteMapDataSource ID="SiteMapDataSource1" runat="server" ShowStartingNode="false" />
<asp:TreeView ID="TreeView1" runat="server" DataSourceID="SiteMapDataSource1" CssClass="TreeView">
</asp:TreeView>

<div id="app-sitemap" data-app-role="page" data-theme="a" 
            
              data-app-toolbar="false"
             data-activator="Button|^TocHeader^Site Map^TocHeader^">

            
              
  <div data-role="header" data-position="fixed" class="ui-shadow">
      <a href="#app-back" data-role="button" data-iconpos="notext" data-icon="back"></a>
      <h1>^TocHeader^Site Map^TocHeader^</h1>
      <a href="#app-context" data-role="button" data-iconpos="notext" data-icon="bars" class="ui-btn-right app-btn-context" ></a>
  </div>
            
            
  <div data-role="content">
    <p>
      <span>^TocInstruction^Please select a page link in the table of contents below.^TocInstruction^</span>
      <br />
      <br />
    </p>
    <div data-app-role="sitemap"></div>
    <p>
      <br />
    </p>
  </div>
</div>
          