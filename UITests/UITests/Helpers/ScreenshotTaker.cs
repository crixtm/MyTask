using OpenQA.Selenium;
using OpenQA.Selenium.Support.Extensions;
using System;
using System.Drawing.Imaging;
using TechTalk.SpecFlow;

namespace UITests.Helpers
{
    public static class ScreenshotTaker
    {
        private static IWebDriver driver = WebDriver.GetWebDriverInstance();
        public static void Take()
        {
            var shot = driver.TakeScreenshot();
            string filename = (string)ScenarioContext.Current["Path"] +
                "/" + ScenarioContext.Current.ScenarioInfo.Title
                + DateTime.Now.ToString("hh_mm") +
                ".png";
            shot.SaveAsFile(filename, ImageFormat.Png);
        }
    }
}
