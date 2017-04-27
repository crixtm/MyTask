using NUnit.Framework;
using System;
using TechTalk.SpecFlow;
using UITests.Pages;

namespace UITests.StepDefinitions
{
    
    [Binding]
    public class HomePageSteps
    {
        HomePage homePage;
        FormPage formPage;

        [Given(@"I have Home page opened")]
        public void GivenIHaveHomePageOpened()
        {
            homePage = new HomePage();
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
    }
}
