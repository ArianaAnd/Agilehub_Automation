using System;
using MyStore_Project.PageObjectModel;
using NUnit.Framework;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace MyStore_Project.StepDefinitions
{
    [Binding]
    public class SearchBarSteps:Hooks
    {
        private readonly ScenarioContext _scenarioContext;

        public SearchBarSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }
        [Given(@"I write '(.*)' in the search bar")]
        public void GivenIWriteInTheSearchBar(string element)
        {
            HomePage homePage = new HomePage(Driver);
            homePage.searchTextBox.Click();
            homePage.searchTextBox.SendKeys(element);
        }
        
        [Given(@"I press the search button")]
        public void GivenIPressTheSearchButton()
        {
            HomePage homePage = new HomePage(Driver);
            homePage.searchButton.Click();
        }
        
        [Then(@"I am shown only '(.*)' articles")]
        public void ThenIAmShownOnlyArticles(string element)
        {
            var result = "\"" + element.ToUpper() + "\"";
            Assert.IsTrue(Driver.FindElement(By.XPath("/html/body/div/div[2]/div/div[3]/div[2]/h1/span[1]")).Text == result);
        }
    }
}
