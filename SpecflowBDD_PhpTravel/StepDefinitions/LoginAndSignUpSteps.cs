using System;
using SpecflowBDD_PhpTravel.PageObjects;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace SpecflowBDD_PhpTravel.StepDefinitions
{
    [Binding]
    public class LoginAndSignUpSteps:Hooks
    {
        private readonly ScenarioContext _scenarioContext;

        public LoginAndSignUpSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [Given(@"I am logged in on my site with following credentials")]
        public void GivenIAmLoggedInOnMySiteWithFollowingCredentials(Table table)
        {
            var user = table.CreateInstance<UserDto>();
                Login myLoginPage = new Login(Driver);
                myLoginPage.EnterCredentials(user);
            
        }
        
        [When(@"I click disconnect button")]
        public void WhenIClickDisconnectButton()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I am successfully logged out")]
        public void ThenIAmSuccessfullyLoggedOut()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
