using NUnit.Framework;
using System;
using TechTalk.SpecFlow;
using UITests.Common;
using UITests.Pages;

namespace UITests.StepDefinitions
{
    [Binding]
    public class Steps
    {
        
        const String PAGE_TITLE = "UI Testing Site";
        const String LOGO_ATTRIBUTE = 
            "http://uitest.duodecadits.com/assets/img/dh_company_lux_doclerholding.jpg";
        public Page currentPage;
            
        

        [Given(@"I have opened the browser")]
        public void GivenIHaveOpenedTheBrowser() { }

        [When(@"I open (.*)")]
        public void WhenIOpen(String Page)
        {
            switch (Page)
            {
                case "Home":
                    {
                        currentPage = new HomePage();
                        break;
                    }
                case "Form":
                    {
                        currentPage = new FormPage();
                        break;
                    }
                case "Error":
                    {
                        currentPage = new ErrorPage();
                        break;
                    }
                default:
                    {
                        currentPage = new HomePage();
                        break;
                    }
            }
        }

        [Then(@"the title is valid")]
        public void ThenTheTitleIsValid()
        {
            Assert.AreEqual(PAGE_TITLE, currentPage.GetPageTitle());
        }
        
        [Then(@"the logo should appear")]
        public void ThenTheLogoShouldAppear()
        {
            Assert.AreEqual(LOGO_ATTRIBUTE, currentPage.GetLogoSRCAttribute());
        }
        


    }
}
