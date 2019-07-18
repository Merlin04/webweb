using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace webweb.Controllers
{
    public class DocsController : Controller
    {
        public ActionResult Index()
        {
            return RedirectToAction("About");
        }
        public ActionResult About()
        {
            wwBuildInfo.wwBuildInfo wwbi = new wwBuildInfo.wwBuildInfo();
            ViewData["SoftwareName"] = wwbi.GetName();
            ViewData["VersionNumber"] = wwbi.GetVersion();
            ViewData["ProjectUrl"] = wwbi.GetUrl();
            ViewData["SiteName"] = getSiteSettings()["SiteName"];
            return View();
        }
        public ActionResult Syntax()
        {
            wwBuildInfo.wwBuildInfo wwbi = new wwBuildInfo.wwBuildInfo();
            ViewData["SoftwareName"] = wwbi.GetName();
            ViewData["VersionNumber"] = wwbi.GetVersion();
            ViewData["ProjectUrl"] = wwbi.GetUrl();
            ViewData["SiteName"] = getSiteSettings()["SiteName"];
            return View();
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
