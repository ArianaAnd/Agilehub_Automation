using System;
using System.Threading;
using MyStore_Project.PageObjectModel;
using MyStore_Project.PageObjects;
using NUnit.Framework;
using OpenQA.Selenium;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace MyStore_Project.StepDefinitions
{
    [Binding]
    public class PopUpPageTermServicesSteps:Hooks
    {
        [Given(@"I am logged in with following user")]
        public void GivenIAmLoggedInWithFollowingUser(Table table)
        {
            HomePage homePage = new HomePage(Driver);
            homePage.AuthentificatePage();
            var user = table.CreateInstance<UserDto>();
            LoginPage loginPage = new LoginPage(Driver);
            loginPage.AddCredentials(user);
        }
        
        [Given(@"I add a product into cart")]
        public void GivenIAddAProductIntoCart()
        {
            HomePage homePage = new HomePage(Driver);
            homePage.AddDressToCartPage();
            Thread.Sleep(2000);
            homePage.proceedCheckoutButton.Click();
        }

        [When(@"I complete the checkout process")]
        public void WhenICompleteTheCheckoutProcess()
        {
            CheckoutPage checkoutPage = new CheckoutPage(Driver);
            checkoutPage.TermsOfService();
        }

        [Then(@"I am shown a popup if terms of service is not checked")]
        public void ThenIAmShownAPopupIfTermsOfServiceIsNotChecked()
        {
            Assert.IsTrue(Driver.FindElement(By.XPath("/html/body/div[2]/div/div/div/div/p")).Displayed);
        }
    }
}
