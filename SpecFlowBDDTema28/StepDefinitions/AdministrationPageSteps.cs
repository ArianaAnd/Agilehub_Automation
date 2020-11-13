using System;
using TechTalk.SpecFlow;
using SpecFlowBDDTema28.PageObjects;
using SpecFlowBDDTema28.Dto;
using TechTalk.SpecFlow.Assist;

namespace SpecFlowBDDTema28.StepDefinitions
{
    [Binding]
    public class AdministrationPageSteps:Hooks
    {
        [Then(@"I see the users list")]
        public void ThenISeeTheUsersList()
        {
            LoginPage loginPage = new LoginPage(Driver);
            AdminPage adminPage = new AdminPage(Driver);
            loginPage.VerifyElementContainsText(adminPage.UsersTableHeader, "Email");
        }

        [When(@"I navigate to Administration page")]
        public void WhenINavigateToAdministrationPage(string userEmail)
        {
            SignUp sigUpPage = new SignUp(Driver);
            AdminPage adminPage = new AdminPage(Driver);
            adminPage.ClickUsersBtn();
            sigUpPage.SigUpFormFill();
            adminPage.EditUsers("A", "test@test.com", "01111111");


        }
       
        
        [When(@"I edit the user '(.*)'")]
        public void WhenIEditTheUser()
        {
            LoginPage loginPage = new LoginPage(Driver);
            loginPage.VerifyElementContainsText(loginPage.AlertMessage, "The user has been successfully updated.");
        }
        
   
        
      
    }
}
