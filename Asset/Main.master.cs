using AssetManagment.Services;
using AssetManagment.Web;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;



public partial class Main : System.Web.UI.MasterPage
{
    
    public static string[] MicrosoftJavaScript = new string[] {
            "MicrosoftAjax.js",
            "MicrosoftAjaxWebForms.js",
            "MicrosoftAjaxApplicationServices.js"};
    
    static Main()
    {
        AquariumExtenderBase.EnableCombinedScript = true;
    }
    
    protected void Page_Load(object sender, EventArgs e)
    {
        string pageCssClass = (Page.GetType().Name + " Loading");
        PropertyInfo p = Page.GetType().GetProperty("CssClass");
        if (null != p)
        {
            string cssClassName = ((string)(p.GetValue(Page, null)));
            if (!(String.IsNullOrEmpty(pageCssClass)))
            	pageCssClass = (pageCssClass + " ");
            pageCssClass = (pageCssClass + cssClassName);
        }
        if (!(pageCssClass.Contains("Wide")))
        	pageCssClass = (pageCssClass + " Standard");
        LiteralControl c = ((LiteralControl)(Page.Form.Controls[0]));
        if ((null != c) && !(String.IsNullOrEmpty(pageCssClass)))
        	c.Text = Regex.Replace(c.Text, "<div>", String.Format("<div class=\"{0}\">", pageCssClass));
    }
    
    protected void Page_PreRender(object sender, EventArgs e)
    {
        ApplicationServices.RegisterCssLinks(Page);
    }
    
    protected void sm_ResolveScriptReference(object sender, ScriptReferenceEventArgs e)
    {
        if (System.Array.IndexOf(MicrosoftJavaScript, e.Script.Name) >= 0)
        {
            if (AquariumExtenderBase.EnableCombinedScript)
            {
                string lang = CultureInfo.CurrentUICulture.IetfLanguageTag.ToLower();
                string scriptPath = String.Format("~/appservices/combined-{0}.{1}.js", ApplicationServices.Version, lang);
                if (ApplicationServices.IsMobileClient)
                	scriptPath = String.Format("{0}?_mobile", scriptPath);
                e.Script.Path = scriptPath;
                return;
            }
            e.Script.Path = String.Format("~/Scripts/{0}?{1}", e.Script.Name, ApplicationServices.Version);
        }
    }
}
