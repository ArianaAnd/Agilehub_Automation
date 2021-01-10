using System;
using Demosite.Casqad.PageObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace Demosite.Casqad.StepDefinitions
{
    [Binding]

    

    public class SignUpAndLoginSteps:Hooks
    {
    private readonly ScenarioContext _scenarioContext;

    public SignUpAndLoginSteps(ScenarioContext scenarioContext)
    {
        _scenarioContext = scenarioContext;
    }

    
        [Given(@"I navigate to my website and click SignUp")]
        public void GivenINavigateToMyWebsiteAndClickSignUp()
        {
            HomePage homePage = new HomePage(Driver);
            homePage.AuthenticateStep();
        }
        
        [When(@"I fill the signup form with following data")]
        public void WhenIFillTheSignupFormWithFollowingData(Table table)
        {
            var user = table.CreateInstance<UserDto>();
            LoginPage myLoginPage = new LoginPage(Driver);
            myLoginPage.AddCredentials(user);
        }
        
     
        [Then(@"I  am login in")]
        public void WhenILoginWithNewlyCreatedUser(Table table)
        {
            Assert.IsTrue(Driver.FindElement(By.XPath("//a[text()='Deconectare']")).Displayed);
        }
        
   
    }
}
