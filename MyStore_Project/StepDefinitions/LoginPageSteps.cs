using System;
using TechTalk.SpecFlow;

namespace MyStore_Project.StepDefinitions
{
    [Binding]
    public class LoginPageSteps
    {
        private readonly ScenarioContext _scenarioContext;

        public LoginPageSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }
        [Given(@"I navigate to website and click login")]
        public void GivenINavigateToWebsiteAndClickLogin()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I fill the register form with following data")]
        public void WhenIFillTheRegisterFormWithFollowingData(Table table)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I fill email")]
        public void ThenIFillEmail(Table table)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I am successfully logged in")]
        public void ThenIAmSuccessfullyLoggedIn()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
