using NUnit.Framework;
using System;
using TechTalk.SpecFlow;
using UITests.Pages;

namespace UITests.StepDefinitions
{
    [Binding]
    public class BusinessLogicSteps
    {
        FormPage formPage = new FormPage();
        HelloPage helloPage;
        string Name;
        [Given(@"I have entered (.*) to the input")]
        public void GivenIHaveEnteredJohnToTheInput(string Value)
        {
            formPage.FillTheInputbox(Value);
            Name = Value;
        }
        
        [When(@"I press Go! button")]
        public void WhenIPressGoButton()
        {
            helloPage = formPage.Submit();
        }
        
        [Then(@"Hello Page should open")]
        public void ThenHelloPageShouldOpen()
        {
            Assert.IsTrue(helloPage.IsThisHelloPage()); 
        }
        
        [Then(@"the greetings (.*) should appear")]
        public void ThenTheGreetingsJohnShouldAppear(string Result)
        {
            string expectedGreeting = "Hello " + Name + "!";
            Assert.AreEqual(expectedGreeting, helloPage.GetGreeting());
        }
    }
}
