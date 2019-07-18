using System;
using System.IO;
using Microsoft.Extensions.Configuration;

namespace wwBuildInfo
{
    public class wwBuildInfo
    {
        public string GetVersion()
        {
            return "v0.2";
        }
        public string GetName()
        {
            return "webweb";
        }
        public string GetUrl()
        {
            return "https://github.com/Merlin04/webweb";
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
