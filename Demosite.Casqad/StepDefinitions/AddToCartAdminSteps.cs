using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using Demosite.Casqad;
using Demosite.Casqad.PageObjects;

namespace Demosite.Casqad.StepDefinitions
{
    [Binding]

    public class AddToCartAdminSteps:Hooks
    {
        private readonly ScenarioContext _scenarioContext;

        public AddToCartAdminSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [Given(@"I login with admmin")]
        public void GivenILoginWithAdmmin(Table table)
        {
            HomePage homepage = new HomePage(Driver);
            homepage.AuthenticateStep();
            var user = table.CreateInstance<UserDto>();
            LoginPage myLoginPage = new LoginPage(Driver);
            myLoginPage.AddCredentials(user);
        }
        
        [When(@"I add a product in the cart")]
        public void WhenIAddAProductInTheCart()
        {

            HomePage homePage = new HomePage(Driver);
            homePage.AddToCart(Driver.FindElement(By.XPath("/html/body/div/div[1]/div[2]/div/div/div/div/a")));
        }
        
        [Then(@"I see the product in the cart")]
        public void ThenISeeTheProductInTheCart()
        {
            Assert.IsTrue(Driver.FindElement(By.XPath("/html/body/div/div[1]/div[2]/table/tbody/tr[1]/td[2]")).Text == "Laptop ASUS");
        }
    }
}
