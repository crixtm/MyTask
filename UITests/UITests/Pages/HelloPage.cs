using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;

namespace UITests.Pages
{
    public class HelloPage
    {
		IWebDriver driver;
        private const string HELLO_URL = "hello.html"; 
        public HelloPage()
        {
            driver = WebDriver.GetWebDriverInstance();
            PageFactory.InitElements(driver, this);
            var wait = new WebDriverWait(driver, TimeSpan.FromMilliseconds(3000))
                .Until(ExpectedConditions.ElementIsVisible(By.Id("dh_logo")));

        }

        [FindsBy(How = How.Id, Using = "hello-text")]
        private IWebElement Greetings;

		public bool IsThisHelloPage()
        {
			return driver.Url.Contains(HELLO_URL) ? true : false;
        }
		public string GetGreeting()
        {
            return Greetings.Text;
        }
    }
}
