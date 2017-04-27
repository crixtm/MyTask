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
    class FormPage : Page
    {
        public FormPage()
        {
            driver = WebDriver.GetWebDriverInstance();
            driver.Navigate().GoToUrl("http://uitest.duodecadits.com/form.html");
            PageFactory.InitElements(driver, this);
            var wait = new WebDriverWait(driver, TimeSpan.FromMilliseconds(3000))
                .Until(ExpectedConditions.ElementIsVisible(By.Id("dh_logo")));
        }

        [FindsBy(How = How.Id, Using = "dh_logo")]
        private IWebElement DHLogo;
        [FindsBy(How = How.ClassName, Using = "ui-test")]
        private IWebElement PageTitleText;
        [FindsBy(How = How.Id, Using = "home")]
        private IWebElement HomeButton;
        [FindsBy(How = How.XPath, Using = "//*[@id='form']/parent::li")]
        private IWebElement FormButtonContainer;
        [FindsBy(How = How.Id, Using = "error")]
        private IWebElement ErrorButton;

        override
        public ErrorPage ClickErrorButton()
        {
            ErrorButton.Click();
            return new ErrorPage();
        }
        public bool IsPageTitleTextExist()
        {
            return PageTitleText.Displayed ? true : false;
        }
        public HomePage ClickHomeButton()
        {
            HomeButton.Click();
            return new HomePage();
        }
        public bool IsFormButtonActive()
        {
            return FormButtonContainer.GetAttribute("class") == "active" ? true : false;
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
