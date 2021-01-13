using System;
using MyStore_Project.PageObjectModel;
using NUnit.Framework;
using OpenQA.Selenium;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace MyStore_Project.StepDefinitions
{
    [Binding]
    public class LoginWithExistingUserSteps:Hooks
    {
        [Given(@"I click the login button")]
        public void GivenIClickTheLoginButton()
        {
            HomePage homePage = new HomePage(Driver);
            homePage.AuthentificatePage();
        }
        
        [When(@"I login with the following credentials")]
        public void WhenILoginWithTheFollowingCredentials(Table table)
        {
            var user = table.CreateInstance<UserDto>();
            LoginPage myLoginPage = new LoginPage(Driver);
            myLoginPage.AddCredentials(user);
        }
        
        [Then(@"I am succesfullly logged in")]
        public void ThenIAmSuccesfulllyLoggedIn()
        {
            Assert.IsTrue(Driver.FindElement(By.XPath("/html/body/div/div[1]/header/div[2]/div/div/nav/div[2]/a")).Displayed);
        }
    }
}
