using System;
using TechTalk.SpecFlow;

namespace Demosite.Casqad.StepDefinitions
{
    [Binding]
    public class AuthenticateAndLoginSteps
    {
        [Given(@"I navigate to my authentication page")]
        public void GivenINavigateToMyAuthenticationPage()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I login with following credentials")]
        public void WhenILoginWithFollowingCredentials(Table table)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I am logged in")]
        public void ThenIAmLoggedIn()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
