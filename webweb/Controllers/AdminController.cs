using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography;
using System.Text;
using System.Text.Encodings.Web;
using System.Threading;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace webweb.Controllers
{
    public class AdminController : Controller
    {
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly IEmailSender _emailSender;
        private readonly IApplicationLifetime _applicationLifetime;
        public AdminController(SignInManager<IdentityUser> signInManager, IEmailSender emailSender, IApplicationLifetime applicationLifetime)
        {
            _signInManager = signInManager;
            _emailSender = emailSender;
            _applicationLifetime = applicationLifetime;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            return RedirectToAction("ControlPanel");
        }
        public IActionResult ControlPanel(string restart)
        {
            wwBuildInfo.wwBuildInfo wwbi = new wwBuildInfo.wwBuildInfo();
            wwFileAccess.wwFileAccess wwfi = new wwFileAccess.wwFileAccess();
            ViewData["SoftwareName"] = wwbi.GetName();
            ViewData["VersionNumber"] = wwbi.GetVersion();
            ViewData["ProjectUrl"] = wwbi.GetUrl();
            ViewData["SiteName"] = wwbi.getSiteSettings()["SiteName"];
            ViewData["RestartShow"] = (restart == "yes");
            ViewData["AppSettingsJson"] = System.IO.File.ReadAllText(wwfi.MapPath("~/appsettings.json"));
            //ViewData["AppSettingsJson"] = wwfi.MapPath("~/appsettings.json");
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
        
        [HttpPost]
        public async Task<IActionResult> UploadFavicon(IFormFile postedFile)
        {
            if (_signInManager.IsSignedIn(User))
            { 
                wwFileAccess.wwFileAccess wwfi = new wwFileAccess.wwFileAccess();
                if (postedFile != null)
                {
                    string path = wwfi.MapPath("~/wwwroot/");
                    if (!Directory.Exists(path))
                    {
                        Directory.CreateDirectory(path);
                    }

                    if (postedFile.Length > 0)
                    {
                        var filePath = Path.Combine(path, "favicon.ico");
                        using (var fileStream = new FileStream(filePath, FileMode.Create))
                        {
                            await postedFile.CopyToAsync(fileStream);
                        }
                    }
                }
                return RedirectToAction("ControlPanel");
            }
            else
            {
                return RedirectToAction("ViewPage", "Page");
            }
        }

        [HttpPost]
        public IActionResult EditAppSettings(string newValue)
        {
            if (_signInManager.IsSignedIn(User))
            {
                wwFileAccess.wwFileAccess wwfi = new wwFileAccess.wwFileAccess();
                // Edit the config file
                using (StreamWriter sw = System.IO.File.CreateText(wwfi.MapPath("~/appsettings.json")))
                {
                    sw.Write(newValue);
                }
                // Stop the app, systemd will restart it
                Task.Delay(5000).ContinueWith(t => _applicationLifetime.StopApplication()); // Wait a bit so that the IActionResult can be returned before the application stops itself
                return RedirectToAction("ControlPanel", new { restart = "yes" });
            }
            else
            {
                return RedirectToAction("ViewPage", "Page");
            }
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult RunSqlQuery(string query)
        {
            if (_signInManager.IsSignedIn(User))
            {
                SqlAccess.SqlAccess sa = new SqlAccess.SqlAccess();
                DataSet qe = sa.RunSqlQuery(query);
                string jsonString;
                // Turn the DataSet into a json object
                try
                {
                    jsonString = JsonConvert.SerializeObject(qe.Tables[0]);
                }
                catch(Exception ex)
                {
                    if (ex.Message == "Cannot find table 0.")
                    {
                        //jsonString = "{\"Status\": \"The command completed successfully.\"}";
                        DataTable dataTable = new DataTable();
                        dataTable.Columns.Add("Status");
                        DataRow dataRow = dataTable.NewRow();
                        dataRow["Status"] = "The command completed successfully.";
                        dataTable.Rows.Add(dataRow);
                        jsonString = JsonConvert.SerializeObject(dataTable);
                    }
                    else
                    {
                        throw ex;
                    }
                }
                return Json(jsonString);
            }
            else
            {
                return RedirectToAction("ViewPage", "Page");
            }
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
