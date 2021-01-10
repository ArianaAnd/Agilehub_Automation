using System;
using Demosite.Casqad.PageObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace Demosite.Casqad.StepDefinitions
{
    [Binding]
    public class EditUserAsAdminSteps : Hooks
    {
        private readonly ScenarioContext _scenarioContext;


        public EditUserAsAdminSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }


        [Given(@"I am logged in as an admin with credentials ""(.*)"" and ""(.*)""")]
        public void GivenIAmLoggedInAsAnAdminWithCredentialsAnd(string user, string password)
        {
            HomePage homePage = new HomePage(Driver);
            homePage.AuthenticateStep();
            LoginPage myLoginPage = new LoginPage(Driver);
            myLoginPage.AddCredentials(user, password);
        }

        [When(@"I click the Admin button")]
        public void WhenIClickTheAdminButton()
        {
            HomePage homePage = new HomePage(Driver);
            homePage.adminButton.Click();
        }

        [When(@"I navigate to Users page")]
        public void WhenINavigateToUsersPage()
        {
            AdminPage adminPage = new AdminPage(Driver);
            adminPage.ClickUsersButton();
        }

        [When(@"I click  Edit and enter the following fields")]
        public void WhenIClickEditAndEnterTheFollowingFields(Table table)
        {
            AdminPage adminPage = new AdminPage(Driver);
            var user = table.CreateInstance<UserDto>();
            adminPage.EditUSer(user.userName, user.userEmail, user.userPhone);
        }

        [Then(@"The user is successfully edited")]
        public void ThenTheUserIsSuccessfullyEdited()
        {
            Assert.IsTrue(Driver.FindElement(By.XPath("/html/body/div/div")).Text
                .Contains("The user has been updated"));
        }
    }
}
