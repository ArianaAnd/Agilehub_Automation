using NUnit.Framework;
using OpenQA.Selenium;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using TestSpecSelProj.Dto;

namespace TestSpecSelProj
{
    [Binding]  //specflow attribute - indicates that this class is binded with a feature file
    public sealed class AuthenticationSteps
    {
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        private IWebDriver _driver;

        public AuthenticationSteps(IWebDriver driver) => _driver = driver;

        [Given(@"I navigate to authentication page")]
        public void GivenINavigateToAuthenticationPage()
        {
            BasePage basePage = new BasePage(_driver);
            HomePage homePage = new HomePage(_driver);
            basePage.NavigateToUrl(basePage.CasqadUrl);
            homePage.GoToAuthentication();
        }

        //[When(@"I login with user '(.*)'")]
        //public void WhenILoginWithUser(string userEmailAddress)
        //{
        //    LoginPage loginPage = new LoginPage(Driver);
        //    loginPage.EmailFieldTextBox.SendKeys(userEmailAddress);
        //}

        //[When(@"password '(.*)'")]
        //public void WhenPassword(string userPassword)
        //{
        //    LoginPage loginPage = new LoginPage(Driver);
        //    loginPage.PasswordFieldTextBox.SendKeys(userPassword);
        //    loginPage.SubmitButton.Click();
        //}

        [When(@"I login with following credentials")]
        public void WhenILoginWithFollowingCredentials(Table table)
        {
            var myUser = table.CreateInstance<UserDto>();
            LoginPage loginPage = new LoginPage(_driver);
            //loginPage.AuthenticateUser(myUser.userEmail, myUser.userPassword);
            loginPage.LoginIntoApplication(myUser);
        }


        [Then(@"I am logged in")]
        public void ThenIAmLoggedIn()
        {
            HomePage homePage = new HomePage(_driver);
            Assert.IsTrue(homePage.DeconectareButton.Displayed);
        }


    }
}
