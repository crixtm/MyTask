using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
