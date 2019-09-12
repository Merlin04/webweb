using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Web;
using System.Data;
using System.Configuration;
using System.IO;
using System.Text;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using webweb.Models;
using System.Text.RegularExpressions;
using Microsoft.AspNetCore.Http.Internal;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace webweb.Controllers
{
    public class PageController : Controller
    {
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly UserManager<IdentityUser> _userManager;
        public PageController(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }
        public ActionResult Index()
        {
            return RedirectToAction("Index", "Home");
            //return View();
        }
        public ActionResult ViewPage(string id)
        {
            if (id == null)
            {
                //return RedirectToAction("Index", "Home");
                id = "Index";
            }

            SqlAccess.SqlAccess sa = new SqlAccess.SqlAccess();
            wwBuildInfo.wwBuildInfo wwbi = new wwBuildInfo.wwBuildInfo();
            //ViewData["CustomHtml"] = "<div class='ui label'>Testing html \" ` ` \" chars</div>";
            string[] pageData = sa.GetPageByName(id);
            string pageContents = pageData[0];
            string fixNameCaps = sa.FixNameCaps(id);
            List<string> authCredentials = new List<string>();
            ViewData["PageName"] = ((fixNameCaps == "") ? id : fixNameCaps);
            if (pageContents == "")
            {
                ViewData["CustomHtml"] = @"<div class=""ui negative message"">
  <div class=""header"">
404 Error
  </div>
  <p>Either this page is empty or it does not exist. 
</p></div>";
                ViewData["ErrorShown"] = true;
            }
            else
            {
                ViewData["CustomHtml"] = applySyntaxRules(pageContents, ViewData["PageName"].ToString());
                Dictionary<string, object> authProcessedText =
                    applyAuthenticationRules(ViewData["CustomHtml"].ToString());
                ViewData["CustomHtml"] = (string)authProcessedText["outText"];
                authCredentials = (List<string>)authProcessedText["authCredentials"];
            }
            string newHtml = ViewData["CustomHtml"].ToString().Replace("{{HIDENAVBAR}}\r\n", "");
            if (newHtml != ViewData["CustomHtml"].ToString())
            {
                ViewData["ShowNavbar"] = false;
                ViewData["CustomHtml"] = newHtml;
            }
            else
            {
                ViewData["ShowNavbar"] = true;
            }
            newHtml = ViewData["CustomHtml"].ToString().Replace("{{NOMARGIN}}\r\n", "");
            if (newHtml != ViewData["CustomHtml"].ToString())
            {
                ViewData["NoMargin"] = true;
                ViewData["CustomHtml"] = newHtml;
            }
            else
            {
                ViewData["NoMargin"] = false;
            }
            ViewData["CustomCss"] = pageData[1];
            ViewData["CustomJs"] = pageData[2];
            ViewData["CustomHead"] = pageData[3];
            ViewData["VersionNumber"] = wwbi.GetVersion();
            ViewData["SoftwareName"] = wwbi.GetName();
            ViewData["SiteName"] = getSiteSettings()["SiteName"];
            if (_userManager.Users.ToList().Count < 1) { return RedirectToPage("/Account/Register", new { area = "Identity" }); }

            bool credentialMatches = true;
            
            if (authCredentials.Count > 0)
            {
                credentialMatches = false;
                var req = HttpContext.Request;
                var auth = req.Headers["Authorization"];
                if (!string.IsNullOrEmpty(auth))
                {
                    var cred = ASCIIEncoding.ASCII.GetString(Convert.FromBase64String(auth.ToString().Substring(6))).Split(':');
                    var user = new { Name = cred[0], Pass = cred[1] };
                    foreach (string credentialPair in authCredentials)
                    {
                        var credentialList = credentialPair.Split("|");
                        if (user.Name == credentialList[0] && user.Pass == credentialList[1])
                        {
                            credentialMatches = true;
                            break; // Don't keep going through the credential list
                        }
                    }
                }
            }
            try
            {
                if (!credentialMatches)
                {
                    HttpContext.Response.Headers.Add("WWW-Authenticate", "Basic realm=\"This page is protected, please enter the username and password specific to the page.\"");
                    return new UnauthorizedResult();
                }
                if ((!_signInManager.IsSignedIn(User)) && (ViewData["PageName"].ToString().Substring(0, 6) == "Draft|"))
                {
                    return RedirectToAction("ViewPage", "Page", new {id = "Index"});
                }
                return View();
            }
            catch (Exception ex)
            {
                // Sometimes the string isn't long enough to be substringed
                return View();
            }
        }
        public ActionResult NewPage()
        {
            SqlAccess.SqlAccess sa = new SqlAccess.SqlAccess();
            wwBuildInfo.wwBuildInfo wwbi = new wwBuildInfo.wwBuildInfo();
            ViewData["VersionNumber"] = wwbi.GetVersion();
            ViewData["SoftwareName"] = wwbi.GetName();
            DataSet templates = sa.GetTemplates();
            ViewData["TemplateHtml"] = "";
            foreach (DataRow dr in templates.Tables[0].Rows)
            {
                ViewData["TemplateHtml"] = ViewData["TemplateHtml"].ToString() +
                    string.Format(@"
                        <div class='item' data-value='{0}'>
                            <div class='ui tiny header'>{0}</div>
                            <label>{1}</label>
                        </div>
                    ", dr["name"], dr["description"]);
            }
            ViewData["SiteName"] = getSiteSettings()["SiteName"];
            if (_signInManager.IsSignedIn(User))
            {
                return View();
            }
            else
            {
                return RedirectToAction("ViewPage", "Page");
            }
        }
        public ActionResult EditPage(string id)
        {
            if (id == null)
            {
                return RedirectToAction("ViewPage");
            }
            SqlAccess.SqlAccess sa = new SqlAccess.SqlAccess();
            wwBuildInfo.wwBuildInfo wwbi = new wwBuildInfo.wwBuildInfo();
            string fixNameCaps = sa.FixNameCaps(id);
            if (fixNameCaps == "")
            {
                return RedirectToAction("ViewPage");
            }
            ViewData["PageName"] = ((fixNameCaps == "") ? id : fixNameCaps);
            //ViewData["CustomHtml"] = "<div class='ui label'>Testing html \" ` ` \" chars</div>";
            string[] pageContents = sa.GetPageByName(id);
            for (int i = 0; i < 4; i++)
            {
                pageContents[i] = pageContents[i].Replace("\n", "").Replace("\\", "\\\\").Replace("\"", "\\\"").Replace("\r", "\\r");
            }
            ViewData["HtmlEdit"] = pageContents[0];
            ViewData["CssEdit"] = pageContents[1];
            ViewData["JsEdit"] = pageContents[2];
            ViewData["HeadEdit"] = pageContents[3];
            try
            {
                ViewData["ShowUndraftButton"] = (ViewData["PageName"].ToString().Substring(0, 6) == "Draft|") ? "true" : "false";
            }
            catch (Exception ex)
            {
                ViewData["ShowUndraftButton"] = "false";
            }
            ViewData["VersionNumber"] = wwbi.GetVersion();
            ViewData["SoftwareName"] = wwbi.GetName();
            ViewData["SiteName"] = getSiteSettings()["SiteName"];
            if (_signInManager.IsSignedIn(User))
            {
                return View();
            }
            else
            {
                return RedirectToAction("ViewPage", "Page");
            }
        }
        public ActionResult ManageTemplates()
        {
            SqlAccess.SqlAccess sa = new SqlAccess.SqlAccess();
            wwBuildInfo.wwBuildInfo wwbi = new wwBuildInfo.wwBuildInfo();
            ViewData["VersionNumber"] = wwbi.GetVersion();
            ViewData["SoftwareName"] = wwbi.GetName();
            ViewData["allTemplates"] = sa.GetAllTemplates().Tables[0];
            ViewData["SiteName"] = getSiteSettings()["SiteName"];
            if (_signInManager.IsSignedIn(User))
            {
                return View();
            }
            else
            {
                return RedirectToAction("ViewPage", "Page");
            }
        }
        public ActionResult EditTemplate(string id)
        {
            if (id == null)
            {
                return RedirectToAction("ManageTemplates");
            }
            SqlAccess.SqlAccess sa = new SqlAccess.SqlAccess();
            wwBuildInfo.wwBuildInfo wwbi = new wwBuildInfo.wwBuildInfo();
            string fixNameCaps = sa.FixNameCapsTemplate(id);
            if (fixNameCaps == "")
            {
                return RedirectToAction("ManageTemplates");
            }
            ViewData["TemplateName"] = ((fixNameCaps == "") ? id : fixNameCaps);
            ViewData["TemplateId"] = id;
            //ViewData["CustomHtml"] = "<div class='ui label'>Testing html \" ` ` \" chars</div>";
            DataRow pageContentsDR = sa.GetTemplateById(id).Tables[0].Rows[0];
            string[] pageContents = { pageContentsDR["contents_html"].ToString(), pageContentsDR["contents_css"].ToString(), pageContentsDR["contents_js"].ToString(), pageContentsDR["contents_head"].ToString() };
            for (int i = 0; i < 4; i++)
            {
                pageContents[i] = pageContents[i].Replace("\n", "").Replace("\\", "\\\\").Replace("\"", "\\\"").Replace("\r", "\\r");
            }
            ViewData["HtmlEdit"] = pageContents[0];
            ViewData["CssEdit"] = pageContents[1];
            ViewData["JsEdit"] = pageContents[2];
            ViewData["HeadEdit"] = pageContents[3];
            ViewData["TemplateDesc"] = pageContentsDR["description"];
            ViewData["VersionNumber"] = wwbi.GetVersion();
            ViewData["SoftwareName"] = wwbi.GetName();
            ViewData["SiteName"] = getSiteSettings()["SiteName"];
            if (_signInManager.IsSignedIn(User))
            {
                return View();
            }
            else
            {
                return RedirectToAction("ViewPage", "Page");
            }
        }
        public ActionResult ManageFiles(string garbage)
        {
            wwBuildInfo.wwBuildInfo wwbi = new wwBuildInfo.wwBuildInfo();
            ViewData["GarbageShow"] = (garbage == "yes");
            ViewData["VersionNumber"] = wwbi.GetVersion();
            ViewData["SoftwareName"] = wwbi.GetName();
            ViewData["SiteName"] = getSiteSettings()["SiteName"];
            if (_signInManager.IsSignedIn(User))
            {
                return View();
            }
            else
            {
                return RedirectToAction("ViewPage", "Page");
            }
        }
        [HttpPost]
        public ActionResult NewTemplatePage(string pageName, string template, string saveAsDraft)
        {
            if (_signInManager.IsSignedIn(User))
            {
                SqlAccess.SqlAccess sa = new SqlAccess.SqlAccess();
                string newPageName = ((saveAsDraft == "true") ? "Draft|" : "") + pageName;
                // Create the new page
                DataSet selectedTemplate = sa.GetTemplateByName(template);
                DataRow dR = selectedTemplate.Tables[0].Rows[0];
                sa.NewPage(newPageName, dR["contents_html"].ToString(), dR["contents_css"].ToString(), dR["contents_js"].ToString(), dR["contents_head"].ToString());
                // Send to the page
                return RedirectToAction("EditPage", new { id = newPageName });
            }
            else
            {
                return RedirectToAction("ViewPage", "Page");
            }
        }
        [HttpPost]
        public ActionResult NewEmptyPage(string pageName, string saveAsDraft)
        {
            if (_signInManager.IsSignedIn(User))
            { 
                SqlAccess.SqlAccess sa = new SqlAccess.SqlAccess();
                string newPageName = ((saveAsDraft == "true") ? "Draft|" : "") + pageName;
                // Create the new page
                sa.CreateEmptyPage(newPageName);
                // Send to the page
                return RedirectToAction("EditPage", new { id = newPageName });
            }
            else
            {
                return RedirectToAction("ViewPage", "Page");
            }
        }
        [HttpPost]
        public ActionResult NewTemplateForm(string templateName)
        {
            if (_signInManager.IsSignedIn(User))
            {
                SqlAccess.SqlAccess sa = new SqlAccess.SqlAccess();
                string templateID = sa.NewTemplate(templateName);
                return RedirectToAction("EditTemplate", new { id = templateID });
            }
            else
            {
                return RedirectToAction("ViewPage", "Page");
            }
        }
        //[ValidateInput(false)]
        [HttpPost]
        public ActionResult EditPageForm(string pageName, string HtmlEdit, string CssEdit, string JsEdit, string HeadEdit, string saveAsDraft)
        {
            if (_signInManager.IsSignedIn(User))
            {
                SqlAccess.SqlAccess sa = new SqlAccess.SqlAccess();
                string newPageName = pageName;
                if (saveAsDraft == "Yes")
                {
                    newPageName = "Draft|" + pageName;
                }
                else if (saveAsDraft == "Undraft")
                {
                    newPageName = pageName.Substring(6);
                    sa.DeletePage(pageName);
                }
                sa.NewPage(newPageName, HtmlEdit, CssEdit, JsEdit, HeadEdit);
                return RedirectToAction("ViewPage", new { id = newPageName });
            }
            else
            {
                return RedirectToAction("ViewPage", "Page");
            }
        }
        [HttpPost]
        public ActionResult DeletePageForm(string pageName)
        {
            if (_signInManager.IsSignedIn(User))
            {
                SqlAccess.SqlAccess sa = new SqlAccess.SqlAccess();
                sa.DeletePage(pageName);
                return RedirectToAction("ViewPage", new { id = "Index" });
            }
            else
            {
                return RedirectToAction("ViewPage", "Page");
            }
        }
        //[ValidateInput(false)]
        [HttpPost]
        public ActionResult EditTemplateForm(string templateName, string templateDesc, string HtmlEdit, string CssEdit, string JsEdit, string HeadEdit, string templateId)
        {
            if (_signInManager.IsSignedIn(User))
            {
                SqlAccess.SqlAccess sa = new SqlAccess.SqlAccess();
                sa.EditTemplate(templateId, templateName, templateDesc, HtmlEdit, CssEdit, JsEdit, HeadEdit);
                return RedirectToAction("ManageTemplates");
            }
            else
            {
                return RedirectToAction("ViewPage", "Page");
            }
        }
        [HttpPost]
        public ActionResult DeleteTemplateForm(string templateId)
        {
            if (_signInManager.IsSignedIn(User))
            {
                SqlAccess.SqlAccess sa = new SqlAccess.SqlAccess();
                sa.DeleteTemplate(templateId);
                return RedirectToAction("ManageTemplates");
            }
            else
            {
                return RedirectToAction("ViewPage", "Page");
            }
        }
        [HttpPost]
        public ActionResult NavigateForm(string pageName)
        {
            return RedirectToAction("ViewPage", new { id = pageName });
        }
        [HttpPost]
        public async Task<IActionResult> UploadFile(List<IFormFile> postedFiles)
        {
            if (_signInManager.IsSignedIn(User))
            { 
                wwFileAccess.wwFileAccess wwfi = new wwFileAccess.wwFileAccess();
                foreach (var postedFile in postedFiles)
                {
                    if (postedFile == null) continue;
                    string path = wwfi.MapPath("~/wwwroot/Content/resources/");
                    if (!Directory.Exists(path))
                    {
                        Directory.CreateDirectory(path);
                    }
                    if (postedFile.Length > 0)
                    {
                        var filePath = Path.Combine(path, postedFile.FileName);
                        using (var fileStream = new FileStream(filePath, FileMode.Create))
                        {
                            await postedFile.CopyToAsync(fileStream);
                        }
                    }
                }
                return RedirectToAction("ManageFiles");
            }
            else
            {
                return RedirectToAction("ViewPage", "Page");
            }
        }
        [HttpPost]
        public ActionResult MoveFile(string oldFileName, string newFileName)
        {
            if (_signInManager.IsSignedIn(User))
            {
                wwFileAccess.wwFileAccess wwfi = new wwFileAccess.wwFileAccess();
                wwfi.MoveFile(oldFileName, newFileName);
                return RedirectToAction("ManageFiles");
            }
            else
            {
                return RedirectToAction("ViewPage", "Page");
            }
        }
        [HttpPost]
        public ActionResult GarbageFile(string filePath)
        {
            if (_signInManager.IsSignedIn(User))
            {
                wwFileAccess.wwFileAccess wwfi = new wwFileAccess.wwFileAccess();
                wwfi.GarbageFile(filePath);
                return RedirectToAction("ManageFiles", new { garbage = "yes" });
            }
            else
            {
                return RedirectToAction("ViewPage", "Page");
            }
        }

        public IConfigurationSection getSiteSettings()
        {
            IConfigurationBuilder builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: false);

            IConfigurationRoot configuration = builder.Build();
            // configurationSection.Key => FilePath
            // configurationSection.Value => C:\\temp\\logs\\output.txt
            IConfigurationSection configurationSection = configuration.GetSection("SiteSettings");
            return configurationSection;
        }

        public string applySyntaxRules(string inText, string currentPageName)
        {
            string outText = inText;
            //// Replace [[Links]] with <a href="/ViewPage/Links">Links</a>
            // First step: get all the [[Links]]
            string regexPattern1 = @"(?<!\\)\[\[.+?(?<!\\)\]\]";
            // What does this regex mean?
            // (?<!\\) # Match only if preceding character isn't a backslash
            // \[\[    # There should be [[ next
            // .+?      # There should be at least one character next, and it should not be greedy, see http://www.lagmonster.org/docs/regex/node23.html
            // (?<!\\) # There should not be a backslash as the character before the following
            // \]\]    # There should be ]] next
            /*Regex regex1 = new Regex(regexPattern1);
            MatchCollection mc1 = regex1.Matches(inText);
            if(mc1.Count > 0)
            {
                foreach(Match match in mc1)
                {
                    // Second step: get text in the [[brackets]]
                    string pageName = match.Value.Substring(2, match.Value.Length - 4);
                    // Third step: replace the [[Link]] with <a href="/ViewPage/Links">Links</a>
                    outText = outText.Replace(match.Value, "<a href=\"/ViewPage/" + pageName + "\">" + pageName + "</a>");
                }
            }
            */
            MatchEvaluator myEvaluator = new MatchEvaluator((match) => {
                // Second step: get text in the [[brackets]]
                string pageName = match.Value.Substring(2, match.Value.Length - 4);
                // Third step: replace the [[Link]] with <a href="/ViewPage/Links">Links</a>
                return ("<a href=\"/ViewPage/" + pageName + "\">" + pageName + "</a>");
            });
            outText = Regex.Replace(outText, regexPattern1, myEvaluator);
            //// Replace {{PAGENAME}} with currentPageName
            outText = outText.Replace("{{PAGENAME}}", currentPageName);
            return outText;
        }
        
        /// <summary>
        /// Apply the authentication filter to the input text
        /// </summary>
        /// <param name="inText">The text to apply the filter to</param>
        /// <returns>A new Dictionary&lt;string, object&gt;:
        /// {
        ///     {"outText", string outText},
        ///     {"authCredentials", new List&lt;string&gt; authCredentials)
        /// }
        /// </returns>
        public Dictionary<string, object> applyAuthenticationRules(string inText)
        {
            string outText = inText;
            List<string> authCredentials = new List<string>();
            string regexPattern1 = @"(?<={{USEAUTH:).+\|.+(?=}})";
            // Regex explanation
            // (?<={{USEAUTH:) # The string "{{USEAUTH:" should precede the text
            // .+ # At least one character
            // \| # "|" should be next
            // .+ # At least one character
            // (?=}}) # The string "}}" should be after the text
            MatchEvaluator myEvaluator = new MatchEvaluator((match) => { authCredentials.Add(match.Value);
                return "";
            });
            outText = Regex.Replace(outText, regexPattern1, myEvaluator);
            // Replace the empty USEAUTH(s) with nothing
            outText = outText.Replace("{{USEAUTH:}}\r\n", "");
            return new Dictionary<string, object>
            {
                {"outText", outText},
                {"authCredentials", authCredentials}
            };
        }
    }
}
