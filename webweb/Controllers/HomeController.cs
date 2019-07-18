using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using webweb.Models;
using wwFileAccess;

namespace webweb.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            /*SqlAccess.SqlAccess sa = new SqlAccess.SqlAccess();
            wwBuildInfo.wwBuildInfo wwbi = new wwBuildInfo.wwBuildInfo();
            //ViewData["CustomHtml"] = "<div class='ui label'>Testing html \" ` ` \" chars</div>";
            ViewData["CustomHtml"] = sa.GetPageByName("index");
            ViewData["VersionNumber"] = wwbi.GetVersion();
            return View();*/
            return RedirectToAction("ViewPage", "Page");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
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
    }
}
