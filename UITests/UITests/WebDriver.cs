using System;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace UITests
{
    internal class WebDriver
    {
        private static IWebDriver driver;

        private WebDriver() { }

        internal static IWebDriver GetWebDriverInstance()
        {
            if (null == driver)
            {
                driver = DriverFactory.GetWebDriver(Common.Browsers.CHROME);
                return driver;
            }
            else
            {
                return driver;
            }
        }

        internal static void DevastateDriver()
        {
            driver.Quit();
            driver = null;
        }
    }
}