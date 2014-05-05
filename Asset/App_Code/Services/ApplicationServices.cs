using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.Security;
using AssetManagment.Data;

namespace AssetManagment.Services
{
	public partial class ApplicationServices : EnterpriseApplicationServices
    {
        
        public static void Initialize()
        {
            ApplicationServices services = new ApplicationServices();
            services.RegisterServices();
        }
    }
    
    public class ApplicationServicesBase
    {
        
        public static bool EnableMobileClient = true;
        
        public static Regex MobileAgentBRegex = new Regex(@"(android|bb\d+|meego).+mobile|avantgo|bada\/|blackberry|blazer|compal|elaine|fennec|hiptop|iemobile|ip(hone|od)|iris|kindle|lge |maemo|midp|mmp|netfront|opera m(ob|in)i|palm( os)?|phone|p(ixi|re)\/|plucker|pocket|psp|series(4|6)0|symbian|treo|up\.(browser|link)|vodafone|wap|windows (ce|phone)|xda|xiino|android|ipad|playbook|silk", (RegexOptions.IgnoreCase | RegexOptions.Multiline));
        
        public static Regex MobileAgentVRegex = new Regex("1207|6310|6590|3gso|4thp|50[1-6]i|770s|802s|a wa|abac|ac(er|oo|s\\-)|ai(ko|rn)|al(" +
                "av|ca|co)|amoi|an(ex|ny|yw)|aptu|ar(ch|go)|as(te|us)|attw|au(di|\\-m|r |s )|avan|" +
                "be(ck|ll|nq)|bi(lb|rd)|bl(ac|az)|br(e|v)w|bumb|bw\\-(n|u)|c55\\/|capi|ccwa|cdm\\-|c" +
                "ell|chtm|cldc|cmd\\-|co(mp|nd)|craw|da(it|ll|ng)|dbte|dc\\-s|devi|dica|dmob|do(c|p" +
                ")o|ds(12|\\-d)|el(49|ai)|em(l2|ul)|er(ic|k0)|esl8|ez([4-7]0|os|wa|ze)|fetc|fly(\\-" +
                "|_)|g1 u|g560|gene|gf\\-5|g\\-mo|go(\\.w|od)|gr(ad|un)|haie|hcit|hd\\-(m|p|t)|hei\\-|" +
                "hi(pt|ta)|hp( i|ip)|hs\\-c|ht(c(\\-| |_|a|g|p|s|t)|tp)|hu(aw|tc)|i\\-(20|go|ma)|i23" +
                "0|iac( |\\-|\\/)|ibro|idea|ig01|ikom|im1k|inno|ipaq|iris|ja(t|v)a|jbro|jemu|jigs|k" +
                "ddi|keji|kgt( |\\/)|klon|kpt |kwc\\-|kyo(c|k)|le(no|xi)|lg( g|\\/(k|l|u)|50|54|\\-[a" +
                "-w])|libw|lynx|m1\\-w|m3ga|m50\\/|ma(te|ui|xo)|mc(01|21|ca)|m\\-cr|me(rc|ri)|mi(o8|" +
                "oa|ts)|mmef|mo(01|02|bi|de|do|t(\\-| |o|v)|zz)|mt(50|p1|v )|mwbp|mywa|n10[0-2]|n2" +
                "0[2-3]|n30(0|2)|n50(0|2|5)|n7(0(0|1)|10)|ne((c|m)\\-|on|tf|wf|wg|wt)|nok(6|i)|nzp" +
                "h|o2im|op(ti|wv)|oran|owg1|p800|pan(a|d|t)|pdxg|pg(13|\\-([1-8]|c))|phil|pire|pl(" +
                "ay|uc)|pn\\-2|po(ck|rt|se)|prox|psio|pt\\-g|qa\\-a|qc(07|12|21|32|60|\\-[2-7]|i\\-)|q" +
                "tek|r380|r600|raks|rim9|ro(ve|zo)|s55\\/|sa(ge|ma|mm|ms|ny|va)|sc(01|h\\-|oo|p\\-)|" +
                "sdk\\/|se(c(\\-|0|1)|47|mc|nd|ri)|sgh\\-|shar|sie(\\-|m)|sk\\-0|sl(45|id)|sm(al|ar|b3" +
                "|it|t5)|so(ft|ny)|sp(01|h\\-|v\\-|v )|sy(01|mb)|t2(18|50)|t6(00|10|18)|ta(gt|lk)|t" +
                "cl\\-|tdg\\-|tel(i|m)|tim\\-|t\\-mo|to(pl|sh)|ts(70|m\\-|m3|m5)|tx\\-9|up(\\.b|g1|si)|u" +
                "tst|v400|v750|veri|vi(rg|te)|vk(40|5[0-3]|\\-v)|vm40|voda|vulc|vx(52|53|60|61|70|" +
                "80|81|83|85|98)|w3c(\\-| )|webc|whit|wi(g |nc|nw)|wmlb|wonu|x700|yas\\-|your|zeto|" +
                "zte\\-", (RegexOptions.IgnoreCase | RegexOptions.Multiline));
        
        public virtual string Realm
        {
            get
            {
                return "AssetManagment Application Services";
            }
        }
        
        public static bool IsMobileClient
        {
            get
            {
                object isMobile = HttpContext.Current.Items["ApplicationServices_IsMobileClient"];
                if (isMobile == null)
                {
                    isMobile = ClientIsMobile();
                    HttpContext.Current.Items["ApplicationServices_IsMobileClient"] = isMobile;
                }
                return ((bool)(isMobile));
            }
        }
        
        public virtual void RegisterServices()
        {
            CreateStandardMembershipAccounts();
        }
        
        public virtual void CreateStandardMembershipAccounts()
        {
            // Create a separate code file with a definition of the partial class ApplicationServices overriding
            // this method to prevent automatic registration of 'admin' and 'user'. Do not change this file directly.
            RegisterStandardMembershipAccounts();
        }
        
        public virtual bool RequiresAuthentication(HttpRequest request)
        {
            return request.Path.EndsWith("Export.ashx", StringComparison.CurrentCultureIgnoreCase);
        }
        
        public virtual bool AuthenticateRequest(HttpContext context)
        {
            return false;
        }
        
        public static void RegisterStandardMembershipAccounts()
        {
            MembershipUser admin = Membership.GetUser("admin");
            if ((admin != null) && admin.IsLockedOut)
            	admin.UnlockUser();
            MembershipUser user = Membership.GetUser("user");
            if ((user != null) && user.IsLockedOut)
            	user.UnlockUser();
            if (Membership.GetUser("admin") == null)
            {
                MembershipCreateStatus status;
                admin = Membership.CreateUser("admin", "admin123%", "admin@AssetManagment.com", "ASP.NET", "Code OnTime", true, out status);
                user = Membership.CreateUser("user", "user123%", "user@AssetManagment.com", "ASP.NET", "Code OnTime", true, out status);
                Roles.CreateRole("Administrators");
                Roles.CreateRole("Users");
                Roles.AddUserToRole(admin.UserName, "Users");
                Roles.AddUserToRole(user.UserName, "Users");
                Roles.AddUserToRole(admin.UserName, "Administrators");
            }
        }
        
        public static bool ClientIsMobile()
        {
            if (!(EnableMobileClient))
            	return false;
            HttpRequest request = HttpContext.Current.Request;
            string u = request.ServerVariables["HTTP_USER_AGENT"];
            HttpCookie mobileCookie = request.Cookies["appfactorymobile"];
            if (mobileCookie != null)
            	return (mobileCookie.Value == "true");
            if (String.IsNullOrEmpty(u))
            	return false;
            return (MobileAgentBRegex.IsMatch(u) || MobileAgentVRegex.IsMatch(u.Substring(0, 4)));
        }
        
        public static void RegisterCssLinks(Page p)
        {
            foreach (Control c in p.Header.Controls)
            	if (c is HtmlLink)
                {
                    HtmlLink l = ((HtmlLink)(c));
                    if (l.ID == "AssetManagmentTheme")
                    	return;
                    if (l.Href.Contains("_Theme_Yoshi.css"))
                    {
                        l.ID = "AssetManagmentTheme";
                        if (ApplicationServices.IsMobileClient)
                        {
                            string jqmCss = String.Format("jquery.mobile-{0}.min.css", ApplicationServices.JqmVersion);
                            l.Href = ("~/mobile/" + jqmCss);
                            HtmlMeta meta = new HtmlMeta();
                            meta.Attributes["name"] = "viewport";
                            meta.Attributes["content"] = "device-width, initial-scale=1";
                            p.Header.Controls.AddAt(0, meta);
                            // enumerate custom css files
                            string mobilePath = Path.GetDirectoryName(p.Server.MapPath("~/Mobile/"));
                            foreach (string fileName in Directory.GetFiles(mobilePath, "*.css"))
                            {
                                string cssFile = Path.GetFileName(fileName);
                                if (!(cssFile.Contains("jquery.mobile")))
                                {
                                    HtmlLink cssLink = new HtmlLink();
                                    cssLink.Href = String.Format("~/mobile/{0}?{1}", cssFile, ApplicationServices.Version);
                                    cssLink.Attributes["type"] = "text/css";
                                    cssLink.Attributes["rel"] = "stylesheet";
                                    p.Header.Controls.Add(cssLink);
                                }
                            }
                        }
                        else
                        	if (!(l.Href.Contains("?")))
                            	l.Href = (l.Href + String.Format("?{0}", ApplicationServices.Version));
                        return;
                    }
                }
        }
    }
    
    public partial class ApplicationSiteMapProvider : ApplicationSiteMapProviderBase
    {
    }
    
    public class ApplicationSiteMapProviderBase : System.Web.XmlSiteMapProvider
    {
        
        public override bool IsAccessibleToUser(HttpContext context, SiteMapNode node)
        {
            string device = node["Device"];
            if ((device == "Mobile") && !(ApplicationServices.IsMobileClient))
            	return false;
            if ((device == "Desktop") && ApplicationServices.IsMobileClient)
            	return false;
            return base.IsAccessibleToUser(context, node);
        }
    }
}
