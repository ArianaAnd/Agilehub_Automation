using System;
using TechTalk.SpecFlow;

namespace Demosite.Casqad.StepDefinitions
{
    [Binding]
    public class AuthenticateAndLoginStepsDependencyInjection
    {
        [Given(@"I navigate to authentication page")]
        public void GivenINavigateToAuthenticationPage()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I login with following credentials:")]
        public void WhenILoginWithFollowingCredentials(Table table)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I am loged in")]
        public void ThenIAmLogedIn()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
