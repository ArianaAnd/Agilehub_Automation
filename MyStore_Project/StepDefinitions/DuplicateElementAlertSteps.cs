using System;
using System.Threading;
using MyStore_Project.PageObjectModel;
using NUnit.Framework;
using OpenQA.Selenium;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace MyStore_Project.StepDefinitions
{
    [Binding]
    public class DuplicateElementAlertSteps:Hooks
    {
        private readonly ScenarioContext _scenarioContext;
        public DuplicateElementAlertSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [Given(@"I enter the login page")]
        public void GivenIEnterTheLoginPage()
        {
            HomePage homePage = new HomePage(Driver);
            homePage.AuthentificatePage();
        }
        
        [Given(@"I enter an used email address")]
        public void GivenIEnterAnUsedEmailAddress(Table table)
        {
            var user = table.CreateInstance<UserDto>();
            HomePage homePage = new HomePage(Driver);
            homePage.emailAddressTextBox.Click();
            homePage.emailAddressTextBox.SendKeys(user.userEmail);
        }
        
        [When(@"I click the register button")]
        public void WhenIClickTheRegisterButton()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I see an alert")]
        public void ThenISeeAnAlert()
        {
            Thread.Sleep(2000);
            Assert.IsTrue(Driver.FindElement(By.XPath("/html/body/div/div[2]/div/div[3]/div/div/div[1]/form/div/div[1]")).Displayed);
        }
    }
}
