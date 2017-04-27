using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UITests.Pages
{
    public class ErrorPage : Page
    {
        public ErrorPage()
        {
            driver = WebDriver.GetWebDriverInstance();
            driver.Navigate().GoToUrl("http://uitest.duodecadits.com/error");
            var wait = new WebDriverWait(driver, TimeSpan.FromMilliseconds(2000))
                   .Until(ExpectedConditions.ElementIsVisible(By.Id("dh_logo")));
        }

        [FindsBy(How = How.Id, Using = "dh_logo")]
        private IWebElement DHLogo;

        override
        public ErrorPage ClickErrorButton()
        {
            return new ErrorPage();
        }
        override
        public string GetLogoSRCAttribute()
        {
            return DHLogo.GetAttribute("src");
        }
        override
        public String GetPageTitle()
        {
            return driver.Title;
        }
    }
}
