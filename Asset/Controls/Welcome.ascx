﻿<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Welcome.ascx.cs" Inherits="Controls_Welcome"  %>
                
<div style="padding-left:8px"><div class="ParaInfo">
        ^SignInInstruction^Sign in to access the protected site content.^SignInInstruction^</div>
<div class="ParaHeader">
    ^SignInHeader^Instructions^SignInHeader^
</div>
<div class="ParaText">
    ^SignInPara1^Two standard user accounts are automatically created when application is initialized
    if membership option has been selected for this application.^SignInPara1^
</div>
                  
<div class="ParaText">
    ^SignInPara2^The administrative account <b>admin</b> is authorized to access all areas of the
    web site and membership manager. The standard <b>user</b> account is allowed to
    access all areas of the web site with the exception of membership manager.^SignInPara2^</div>
                
                  
<div class="ParaText">
    ^SignInPara3^Move the mouse pointer over the link <i>Login to this web site</i> on the right-hand side
    at the top of the page and sign in with one of the accounts listed below.^SignInPara3^</div>
                
<div class="ParaText">
    <div style="border: solid 1px black; background-color: InfoBackground; padding: 8px;
        float: left;">
        ^AdminDesc^Administrative account^AdminDesc^:<br />
        <b title="User Name">admin</b> / <b title="Password">admin123%</b>
        <br />
        <br />
        ^UserDesc^Standard user account^UserDesc^:<br />
        <b title="User Name">user</b> / <b title="Password">user123%</b>
    </div>
    <div style="clear:both;margin-bottom:8px"></div>
    </div>
</div>


<div id="app-welcome" data-app-role="page" data-theme="a" data-app-toolbar="false" data-activator="Button|^SignInHeader^Instructions^SignInHeader^" data-activator-description="^SignInInstruction^Sign in to access the protected site content.^SignInInstruction^">
    <div data-role="header" data-position="fixed" class="ui-shadow">
        <a href="#app-back" data-role="button" data-iconpos="notext" data-icon="back"></a>
        <h1>^TocHeader^Site Map^TocHeader^</h1>
        <a href="#app-context" data-role="button" data-iconpos="notext" data-icon="bars" class="ui-btn-right app-btn-context" ></a>
    </div>
    <div data-role="content">
        <p>^SignInInstruction^Sign in to access the protected site content.^SignInInstruction^</p>
        <p>
            ^SignInPara1^Two standard user accounts are automatically created when application is initialized
    if membership option has been selected for this application.^SignInPara1^
        </p>

        <p>
            ^SignInPara2^The administrative account <b>admin</b> is authorized to access all areas of the
    web site and membership manager. The standard <b>user</b> account is allowed to
    access all areas of the web site with the exception of membership manager.^SignInPara2^
        </p>
        <p>
            ^AdminDesc^Administrative account^AdminDesc^:<br />
            <b title="User Name">admin</b> / <b title="Password">admin123%</b>
        </p>
        <p>
            ^UserDesc^Standard user account^UserDesc^:<br />
            <b title="User Name">user</b> / <b title="Password">user123%</b>
        </p>
        <p><a href="#" data-role="button" data-inline="true" data-theme="b" data-app-role="loginstatus" data-icon="lock">Login Status</a></p>

    </div>
</div>

              