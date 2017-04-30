using OpenQA.Selenium;
using System;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;

namespace UITests.Pages
{
    public class HomePage : Page
    {
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
        [FindsBy(How = How.XPath, Using = "//div[@class='ui-test']/child::h1")]
        private IWebElement WelcomeMessage;
        [FindsBy(How = How.XPath, Using = "//div[@class='ui-test']/child::p")]
        private IWebElement DedicationMessage;

        private const string WELCOME_MESSAGE = 
            "Welcome to the Docler Holding QA Department";
        private const string DEDICATION_MESSAGE = 
            "This site is dedicated to perform some exercises and demonstrate automated web testing.";

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

        public bool WelcomeMessageShown()
        {
            return WelcomeMessage.Text == WELCOME_MESSAGE ? true : false;   
        }

        public bool DedicationMessageShown()
        {
            return DedicationMessage.Text == DEDICATION_MESSAGE ? true : false;
        }
    }
}
