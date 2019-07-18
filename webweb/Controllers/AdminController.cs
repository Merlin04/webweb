using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography;
using System.Text;
using System.Text.Encodings.Web;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace webweb.Controllers
{
    public class AdminController : Controller
    {
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly IEmailSender _emailSender;
        public AdminController(SignInManager<IdentityUser> signInManager, IEmailSender emailSender)
        {
            _signInManager = signInManager;
            _emailSender = emailSender;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ControlPanel()
        {
            wwBuildInfo.wwBuildInfo wwbi = new wwBuildInfo.wwBuildInfo();
            ViewData["SoftwareName"] = wwbi.GetName();
            ViewData["VersionNumber"] = wwbi.GetVersion();
            ViewData["ProjectUrl"] = wwbi.GetUrl();
            ViewData["SiteName"] = wwbi.getSiteSettings()["SiteName"];
            if(_signInManager.IsSignedIn(User)) {
                return View();
            }
            else
            {
                return RedirectToAction("ViewPage", "Page");
            }
        }
        [HttpPost]
        public ActionResult RegisterUserForm(string registerEmail)
        {
            if (_signInManager.IsSignedIn(User))
            {
                SqlAccess.SqlAccess sa = new SqlAccess.SqlAccess();
                wwBuildInfo.wwBuildInfo wwbi = new wwBuildInfo.wwBuildInfo();
                string code = sa.AddRegisterToken(RandomString(64), DateTime.Now.AddDays(30));
                var callbackUrl = Url.Page(
                    "/Account/Register",
                    pageHandler: null,
                    values: new {area = "Identity", code },
                    protocol: Request.Scheme);
                _emailSender.SendEmailAsync(
                    registerEmail,
                    "Register an account on " + wwbi.getSiteSettings()["SiteName"],
                    $"To create an account, please <a href='{HtmlEncoder.Default.Encode(callbackUrl)}'>click here</a>.");

                return RedirectToAction("ControlPanel");
            }
            else
            {
                return RedirectToAction("ViewPage", "Page");
            }
        }

        [HttpPost]
        public ActionResult ClearGarbageForm()
        {
            wwFileAccess.wwFileAccess wwfi = new wwFileAccess.wwFileAccess();
            Array.ForEach(Directory.GetFiles(wwfi.MapPath("~/wwwroot/Content/garbage")), System.IO.File.Delete);
            return RedirectToAction("ControlPanel");
        }
        
        static string RandomString(int length)
        {
            const string valid = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            StringBuilder res = new StringBuilder();
            using (RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider())
            {
                byte[] uintBuffer = new byte[sizeof(uint)];

                while (length-- > 0)
                {
                    rng.GetBytes(uintBuffer);
                    uint num = BitConverter.ToUInt32(uintBuffer, 0);
                    res.Append(valid[(int)(num % (uint)valid.Length)]);
                }
            }

            return res.ToString();
        }
    }
}
