﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using AssetManagment.Data;
using AssetManagment.Services;

namespace AssetManagment.Web
{
	public partial class PageBase : System.Web.UI.Page
    {
        
        public string[] AllowedUrlParameters = new string[] {
                "ReturnUrl",
                "_link",
                "l"};
        
        public virtual string Device
        {
            get
            {
                return null;
            }
        }
        
        protected override void InitializeCulture()
        {
            CultureManager.Initialize();
            base.InitializeCulture();
        }
        
        protected override void OnInit(EventArgs e)
        {
            base.OnInit(e);
            ValidateUrlParameters();
            if (Thread.CurrentThread.CurrentUICulture.TextInfo.IsRightToLeft)
            	foreach (Control c in Controls)
                	ChangeCurrentCultureTextFlowDirection(c);
            string mobileSwitch = Request.Params["_mobile"];
            if (mobileSwitch != null)
            {
                HttpCookie cookie = new HttpCookie("appfactorymobile", ((mobileSwitch == "true")).ToString().ToLower());
                if (String.IsNullOrEmpty(mobileSwitch))
                	cookie.Expires = DateTime.Today.AddDays(-1);
                else
                	cookie.Expires = DateTime.Now.AddDays(30);
                Response.AppendCookie(cookie);
                Response.Redirect("~/");
            }
            if (((Device == "Mobile") && !(ApplicationServices.IsMobileClient)) || ((Device == "Desktop") && ApplicationServices.IsMobileClient))
            	Response.Redirect("~/");
        }
        
        private bool ChangeCurrentCultureTextFlowDirection(Control c)
        {
            if (c is HtmlGenericControl)
            {
                HtmlGenericControl gc = ((HtmlGenericControl)(c));
                if (gc.TagName == "body")
                {
                    gc.Attributes["dir"] = "rtl";
                    gc.Attributes["class"] = "RTL";
                    return true;
                }
            }
            else
            	foreach (Control child in c.Controls)
                {
                    bool result = ChangeCurrentCultureTextFlowDirection(child);
                    if (result)
                    	return true;
                }
            return false;
        }
        
        protected override void Render(HtmlTextWriter writer)
        {
            StringBuilder sb = new StringBuilder();
            HtmlTextWriter tempWriter = new HtmlTextWriter(new StringWriter(sb));
            base.Render(tempWriter);
            tempWriter.Flush();
            tempWriter.Close();
            writer.Write(AssetManagment.Data.Localizer.Replace("Pages", Path.GetFileName(Request.PhysicalPath), sb.ToString()));
        }
        
        protected virtual void ValidateUrlParameters()
        {
            bool success = true;
            foreach (string s in Request.QueryString.Keys)
            	if (Array.IndexOf(AllowedUrlParameters, s) == -1)
                {
                    success = false;
                    break;
                }
            string link = Page.Request["_link"];
            if (!(String.IsNullOrEmpty(link)))
            	try
                {
                    StringEncryptor enc = new StringEncryptor();
                    link = enc.Decrypt(link.Split(',')[0]);
                    if (!(link.Contains('?')))
                    	link = ('?' + link);
                    string[] permalink = link.Split('?');
                    ClientScript.RegisterClientScriptBlock(GetType(), "CommandLine", String.Format("var __dacl=\'{0}?{1}\';", permalink[0], BusinessRules.JavaScriptString(permalink[1])), true);
                }
                catch (Exception )
                {
                    success = false;
                }
            if (!(success))
            {
                Response.StatusCode = 403;
                Response.End();
            }
            ClientScript.RegisterClientScriptBlock(GetType(), "ValidateUrlParameters", "var __dauh=1;", true);
        }
    }
    
    public partial class ControlBase : System.Web.UI.UserControl
    {
        
        protected override void OnInit(EventArgs e)
        {
            base.OnInit(e);
        }
        
        protected override void Render(HtmlTextWriter writer)
        {
            StringBuilder sb = new StringBuilder();
            HtmlTextWriter tempWriter = new HtmlTextWriter(new StringWriter(sb));
            base.Render(tempWriter);
            tempWriter.Flush();
            tempWriter.Close();
            writer.Write(AssetManagment.Data.Localizer.Replace("Pages", Path.GetFileName(Request.PhysicalPath), sb.ToString()));
        }
        
        public static System.Web.UI.Control LoadPageControl(System.Web.UI.Control placeholder, string pageName, bool developmentMode)
        {
            try
            {
                System.Web.UI.Page page = placeholder.Page;
                string basePath = "~";
                if (!(developmentMode))
                	basePath = "~/DesktopModules/AssetManagment";
                string controlPath = String.Format("{0}/Pages/{1}.ascx", basePath, pageName);
                System.Web.UI.Control c = page.LoadControl(controlPath);
                if (c != null)
                {
                    placeholder.Controls.Clear();
                    placeholder.Controls.Add(new LiteralControl("<table style=\"width:100%\" id=\"PageBody\" class=\"Hosted\"><tr><td valign=\"top\" id=\"P" +
                                "ageContent\">"));
                    placeholder.Controls.Add(c);
                    placeholder.Controls.Add(new LiteralControl("</td></tr></table>"));
                    return c;
                }
            }
            catch (Exception )
            {
            }
            return null;
        }
    }
}
