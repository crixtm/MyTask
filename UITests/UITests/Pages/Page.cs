using OpenQA.Selenium;
using System;

namespace UITests.Pages
{
    public abstract class Page
    {
        public IWebDriver driver;
        abstract public String GetPageTitle();
        abstract public String GetLogoSRCAttribute();
        abstract public ErrorPage ClickErrorButton();
    }
}
