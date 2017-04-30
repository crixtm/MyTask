using System;
using System.Configuration;

namespace UITests
{
    class AppConfigHandler
    {
        private string browser;
        public string Browser { get { return browser; } }
        private string path;
        public string Path { get { return path; } }

        public AppConfigHandler()
        {
            try
            {
                browser = ConfigurationManager.AppSettings.Get("Browser");
                path = ConfigurationManager.AppSettings.Get("ScreenShotPath");
            }
            catch (Exception)
            {
                throw new Exception("Error in app.config!");
            }
        }
    }
}
