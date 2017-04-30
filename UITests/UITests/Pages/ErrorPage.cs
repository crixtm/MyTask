using OpenQA.Selenium.Support.UI;
using System;

namespace UITests.Pages
{
    public class ErrorPage : Page
    {
        public ErrorPage()
        {
            driver = WebDriver.GetWebDriverInstance();
            driver.Navigate().GoToUrl("http://uitest.duodecadits.com/error");
            var wait = new WebDriverWait(driver, TimeSpan.FromMilliseconds(2000));
        }

        public bool IsItError()
        {
            return driver.Title.Contains("404") ? true : false; 
        }

        override
        public ErrorPage ClickErrorButton()
        {
            return new ErrorPage();
        }

        override
        public string GetLogoSRCAttribute()
        {
            return "404";
        }

        override
        public String GetPageTitle()
        {
            return driver.Title;
        }

    }
}
