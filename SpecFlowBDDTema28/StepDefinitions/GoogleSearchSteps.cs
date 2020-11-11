using System;
using TechTalk.SpecFlow;
using SpecFlowBDDTema28.PageObjectsG;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SpecFlowBDDTema28.StepDefinitions
{
    [Binding]
    public class GoogleSearchSteps:Hooks
    {
        [Given(@"I go to Google website")]
        public void GivenIGoToGoogleWebsite()
        {
            Actions actionsPage = new Actions(Driver);
            GoogleSearch googlePage = new GoogleSearch(Driver);

            actionsPage.NavigateToUrl("Https://www.google.com/");
            googlePage.AcceptGoogleTerms();
        }
        
        [When(@"I search for '(.*)'")]
        public void WhenISearchFor(string searchText)
        {
            GoogleSearch googlePage = new GoogleSearch(Driver);
            googlePage.SearchGoogleImage(searchText);

        }
        
        [Then(@"I should be able to expand the first image")]
        public void ThenIShouldBeAbleToExpandTheFirstImage()
        {
            GoogleSearch googlePage = new GoogleSearch(Driver);
            googlePage.SelectGoogleImage();
            Assert.IsTrue(!googlePage.imageFrame.Displayed);
        }
        
        [Then(@"Return to the results page")]
        public void ThenReturnToTheResultsPage()
        {
            GoogleSearch googlePage = new GoogleSearch(Driver);
            googlePage.ReturnImage();
            Assert.IsTrue(!googlePage.imageFrame.Displayed);
        }
    }
}
