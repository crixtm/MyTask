using NUnit.Framework;
using System;
using TechTalk.SpecFlow;
using UITests.Pages;

namespace UITests.StepDefinitions
{
    [Binding]
    public class UISteps
    {
        
        const String PAGE_TITLE = "UI Testing Site";
        const String LOGO_ATTRIBUTE = 
            "http://uitest.duodecadits.com/assets/img/dh_company_lux_doclerholding.jpg";
        public Page currentPage;
        public HomePage homePage;
        public FormPage formPage;
        public ErrorPage errorPage;

        [Given(@"I have opened the browser")]
        public void GivenIHaveOpenedTheBrowser() { }

        [When(@"I open (.*)")]
        public void WhenIOpen(String Page)
        {
            switch (Page)
            {
                case "Home":
                    {
                        homePage = new HomePage();
                        currentPage = homePage;
                        break;
                    }
                case "Form":
                    {
                        formPage = new FormPage();
                        currentPage = formPage;
                        break;
                    }
                case "Error":
                    {
                        currentPage = new ErrorPage();
                        break;
                    }
                default:
                    {
                        homePage = new HomePage();
                        currentPage = homePage;
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

        [Given(@"I have Home page opened")]
        public void GivenIHaveHomePageOpened()
        {
            homePage = new HomePage();
            currentPage = homePage;
        }

        [When(@"I press Form button")]
        public void WhenIPressFormButton()
        {
            formPage = homePage.ClickFormButton();
        }

        [Then(@"FormPage should be loaded")]
        public void ThenFormPageShouldBeLoaded()
        {
            Assert.IsTrue(formPage.IsPageTitleTextExist());
        }

        [Then(@"Form button should be active")]
        public void ThenFormButtonShouldBeActive()
        {
            Assert.IsTrue(formPage.IsFormButtonActive());
        }

        [Given(@"I have Form page opened")]
        public void GivenIHaveFormPageOpened()
        {
            formPage = new FormPage();
            currentPage = formPage;
        }

        [When(@"I press Home button")]
        public void WhenIPressHomeButton()
        {
            homePage = formPage.ClickHomeButton();
        }

        [Then(@"HomePage should be loaded")]
        public void ThenHomePageShouldBeLoaded()
        {
            Assert.IsTrue(homePage.IsPageTitleTextExist());
        }

        [Then(@"Home button should be active")]
        public void ThenHomeButtonShuoldBeActive()
        {
            Assert.IsTrue(homePage.IsHomeButtonActive());
        }

        [When(@"I press Error button")]
        public void WhenIPressErrorButton()
        {
            errorPage = currentPage.ClickErrorButton();
        }

        [Then(@"Http (.*) Error should appear")]
        public void ThenHttpErrorShouldAppear(int p0)
        {
            Assert.IsTrue(errorPage.IsItError());
        }

        [When(@"I press UI Testing button")]
        public void WhenIPressUITestingButton()
        {
            homePage = new HomePage();
        }

        [Then(@"welcome message should shown")]
        public void ThenWelcomeMessageShouldShown()
        {
            Assert.IsTrue(homePage.WelcomeMessageShown());
        }

        [Then(@"dedication message should shown")]
        public void ThenDedicationMessageShouldShown()
        {
            Assert.IsTrue(homePage.DedicationMessageShown());
        }

        [Then(@"inputbox should appear")]
        public void ThenInputboxShouldAppear()
        {
            Assert.IsTrue(formPage.IsInputBoxExist());
        }

        [Then(@"submit button should appear")]
        public void ThenSubmitButtonShouldAppear()
        {
            Assert.IsTrue(formPage.IsSubmitButtonExist());
        }

    }
}
