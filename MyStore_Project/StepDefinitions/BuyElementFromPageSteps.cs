using System;
using MyStore_Project.PageObjectModel;
using MyStore_Project.PageObjects;
using NUnit.Framework;
using OpenQA.Selenium;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace MyStore_Project.StepDefinitions
{

    [Binding]
    public class BuyElementFromPageSteps : Hooks
    {
        private readonly ScenarioContext _scenarioContext;

        public BuyElementFromPageSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [Given(@"I am logged in with existing user")]
        public void GivenIAmLoggedInWithExistingUser(Table table)
        {
            HomePage homePage = new HomePage(Driver);
            homePage.AuthentificatePage();
            LoginPage loginPage = new LoginPage(Driver);
            var user = table.CreateInstance<UserDto>();
            loginPage.AddCredentials(user);


        }

        [When(@"I add the Dress to cart")]
        public void WhenIAddTheDressToCart()
        {
            HomePage homePage = new HomePage(Driver);
            homePage.AddDressToCartPage();
        }

        [When(@"I access the cart to proceed to checkout")]
        public void WhenIAccessTheCartToProceedToCheckout()
        {
            HomePage homePage = new HomePage(Driver);
            homePage.proceedCheckoutButton.Click();
        }

        [When(@"I finish the checkout steps from page")]
        public void WhenIFinishTheCheckoutStepsFromPage()
        {
            CheckoutPage checkoutPage = new CheckoutPage(Driver);
            checkoutPage.ProductCheckout();
        }

        [Then(@"My order is completed")]
        public void ThenMyOrderIsCompleted()
        {
            Assert.IsTrue(Driver.FindElement(By.XPath("/html/body/div/div[2]/div/div[3]/div/div/p/strong")).Text ==
                          "Your order on My Store is complete.");
        }
    }
}
