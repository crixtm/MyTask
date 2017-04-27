using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using UITests.Common;


namespace UITests
{
    internal class DriverFactory
    {
        internal static IWebDriver GetWebDriver(Browsers browserName)
        {
            switch (browserName)
            {
                case Browsers.CHROME:
                    return new ChromeDriver();
                default:
                    return new FirefoxDriver();
            }
        }

    }
}
