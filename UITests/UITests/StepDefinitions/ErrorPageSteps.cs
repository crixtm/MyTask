using System;
using TechTalk.SpecFlow;
using UITests.Pages;

namespace UITests.StepDefinitions
{
    [Binding]
    public class ErrorPageSteps
    {
        Page currentPage;
        ErrorPage errorPage;
        [Given(@"I have (.*) opened")]
        public void GivenIHaveHomeOpened(string Page)
        {
            switch (Page)
            {
                case "Home":
                    currentPage = new HomePage();
                    break;
                case "Form":
                    currentPage = new FormPage();
                    break;
                default:
                    currentPage = new HomePage();
                    break;
            }
        }


        [When(@"I press Error button")]
        public void WhenIPressErrorButton()
        {
            errorPage = currentPage.ClickErrorButton();
        }
        
        [Then(@"Http (.*) Error should appear")]
        public void ThenHttpErrorShouldAppear(int p0)
        {
            Assert.
        }
    }
}
