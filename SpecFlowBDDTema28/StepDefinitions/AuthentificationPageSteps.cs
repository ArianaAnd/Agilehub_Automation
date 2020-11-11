using System;
using TechTalk.SpecFlow;

namespace SpecFlowBDDTema28.StepDefinitions
{
    [Binding]
    public class AuthentificationPageSteps
    {
        [Given(@"I navigate to authentication page")]
        public void GivenINavigateToAuthenticationPage()
        {

            HomePage myHomePage = new HomePage(Driver);            myHomePage.GoToAuthentificatePage();            LoginPage myLoginPage = new LoginPage(Driver);            myLoginPage.EnterCredentials("admin.test3@gmail.com", "password123");            Assert.IsTrue(Driver.FindElement(By.XPath("//a[text()='Deconectare']")).Displayed);
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
