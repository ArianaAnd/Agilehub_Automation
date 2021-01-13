using System;
using MyStore_Project.PageObjectModel;
using NUnit.Framework;
using OpenQA.Selenium;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace MyStore_Project.StepDefinitions
{
    [Binding]
    public class LoginPageSteps:Hooks
    {
        private readonly ScenarioContext _scenarioContext;

        public LoginPageSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }
        [Given(@"I navigate to website and click login")]
        public void GivenINavigateToWebsiteAndClickLogin()
        {
            HomePage homePage = new HomePage(Driver);
            homePage.AuthentificatePage();
        }
        
        [When(@"I fill the register form with following data")]
        public void WhenIFillTheRegisterFormWithFollowingData(Table table)
        {
            var user = table.CreateInstance<UserDto>();
            RegisterPage registerPage = new RegisterPage(Driver);
            registerPage.AddRegistrationCredentials(user);
        }
        
        [Then(@"I fill email")]
        public void ThenIFillEmail(Table table)
        {
            var user = table.CreateInstance<UserDto>();
            HomePage homePage = new HomePage(Driver);
            homePage.emailAddressTextBox.SendKeys(user.userEmail);
            homePage.registerButton.Click();
        }
        
        [Then(@"I am successfully logged in")]
        public void ThenIAmSuccessfullyLoggedIn()
        {
            Assert.IsTrue(Driver.FindElement(By.XPath("/html/body/div/div[1]/header/div[2]/div/div/nav/div[2]/a"))
                .Displayed);
        }
    }
}
