using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;

namespace UITests.Pages
{
    class HomePage : Page
    {
        //IWebDriver driver;
        public HomePage()
        {
            driver = WebDriver.GetWebDriverInstance();
            driver.Navigate().GoToUrl("http://uitest.duodecadits.com/");
            PageFactory.InitElements(driver, this);
            var wait = new WebDriverWait(driver, TimeSpan.FromMilliseconds(2000))
                .Until(ExpectedConditions.ElementIsVisible(By.Id("dh_logo")));

        }

        [FindsBy(How = How.Id, Using = "dh_logo")]
        private IWebElement DHLogo;
        [FindsBy(How = How.ClassName, Using = "ui-test")]
        private IWebElement PageTitleText;
        [FindsBy(How = How.XPath, Using = "//*[@id='home']/parent::li")]
        private IWebElement HomeButtonContainer;
        [FindsBy(How = How.Id, Using = "form")]
        private IWebElement FormButton;
        [FindsBy(How = How.Id, Using = "error")]
        private IWebElement ErrorButton;

        override
        public ErrorPage ClickErrorButton()
        {
            ErrorButton.Click();
            return new ErrorPage();
        }
        public FormPage ClickFormButton()
        {
            FormButton.Click();
            return new FormPage();
        }
        public bool IsHomeButtonActive()
        {
            return HomeButtonContainer.GetAttribute("class") == "active" ? true : false;
        }
        public bool IsPageTitleTextExist()
        {
            return PageTitleText.Displayed ? true : false; 
        }
        override
        public string GetLogoSRCAttribute()
        {
            return DHLogo.GetAttribute("src");
        }
        override
        public string GetPageTitle()
        {
            return driver.Title;
        }
        
    }
}
