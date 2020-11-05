using NUnit.Framework;
using SpecFlowSeleniumBDD.PageObjects;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace SpecFlowSeleniumBDD
{ 
      [Binding]//specflow argument - indicates that this class is binded with a feature file
              //can be created with a simple class.cs but must be added [Binding] argument  

    public class SpecFlowTestSteps : Hooks
    {
        private readonly ScenarioContext _injectedContext;
        public SpecFlowTestSteps(ScenarioContext context)
        {
            _injectedContext = context;
        }
        [When(@"I login with following credentials:")]
        public void WhenILoginWithFollowingCredentials(Table table)
        {
            var myUser = table.CreateInstance<UserDto>();
            LoginPage loginPage = new LoginPage(Driver);
            loginPage.LoginIntoApplication(myUser);
        }
        [Given(@"I navigate to authentication page")]
        public void GivenINavigateAuthenticationPage()
        {
            HomePage homePage = new HomePage(Driver);
            homePage.GoToAuthentificatePage();
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
        [Then(@"I am loged in")]
        public void ThenIAmLogedIn()
        {
            HomePage homePage = new HomePage(Driver);
            Assert.IsTrue(homePage.DeconectareButton.Displayed);
        }

    }
}


