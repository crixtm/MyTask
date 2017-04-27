using NUnit.Framework;
using System;
using TechTalk.SpecFlow;
using UITests.Pages;

namespace UITests.StepDefinitions
{
    [Binding]
    public class FormPageSteps
    {
        FormPage formPage;
        HomePage homePage;

        [Given(@"I have Form page opened")]
        public void GivenIHaveFormPageOpened()
        {
            formPage = new FormPage();
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

    }
}
