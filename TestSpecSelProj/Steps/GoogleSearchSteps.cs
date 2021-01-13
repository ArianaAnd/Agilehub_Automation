using NUnit.Framework;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace TestSpecSelProj
{
    [Binding]
    public class GoogleSearchSteps
    {
        private IWebDriver _driver;

        public GoogleSearchSteps(IWebDriver driver) => _driver = driver;

        [Given(@"I go to Google website")]
        public void GivenIGoToGoogleWebsite()
        {
            BasePage basePage = new BasePage(_driver);
            GooglePage googlePage = new GooglePage(_driver);

            basePage.NavigateToUrl("https://www.google.com/");
            googlePage.AcceptTerms();
        }

        [When(@"I search for '(.*)'")]
        public void WhenISearchFor(string searchText)
        {
            GooglePage googlePage = new GooglePage(_driver);
            googlePage.GoogleSearch(searchText);
        }

        [Then(@"I should be able to expand the first image")]
        public void ThenIShouldBeAbleToExpandTheFirstImage()
        {
            GooglePage googlePage = new GooglePage(_driver);
            googlePage.ClickFirstResultFromImages();
            Assert.IsTrue(googlePage.IsImagePanelDisplayed());
        }

        [Then(@"Return to the results page")]
        public void ThenReturnToTheResultsPage()
        {
            GooglePage googlePage = new GooglePage(_driver);
            googlePage.ReturnToImages();
            Assert.IsFalse(googlePage.IsImagePanelDisplayed());
        }

    }
}
