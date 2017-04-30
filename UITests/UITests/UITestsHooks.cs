using System;
using System.IO;
using TechTalk.SpecFlow;
using UITests.Helpers;

namespace UITests
{
    [Binding]
    public sealed class UITestsHooks
    {
        private static AppConfigHandler config = new AppConfigHandler();

        [BeforeScenario]
        public void BeforeScenario()
        {
            string path = config.Path + DateTime.Now.ToString("yyyy-MM-dd");
            ScenarioContext.Current.Add("Browser", config.Browser);
            ScenarioContext.Current.Add("Path", path);
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
        }

        [AfterScenario]
        public void AfterScenario()
        {
            if (ScenarioContext.Current.TestError != null)
            {
                ScreenshotTaker.Take();
            }
            WebDriver.DevastateDriver();
        }
    }
}
