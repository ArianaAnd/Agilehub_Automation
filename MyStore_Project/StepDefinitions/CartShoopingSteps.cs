using System;
using System.Threading;
using MyStore_Project.PageObjectModel;
using MyStore_Project.PageObjects;
using NUnit.Framework;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace MyStore_Project.StepDefinitions
{
    [Binding]
    public class CartShoopingSteps:Hooks
    {
        private readonly ScenarioContext _scenarioContext;

        public CartShoopingSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }
        [Given(@"I go to dresses page")]
        public void GivenIGoToDressesPage()
        {
            HomePage homePage = new HomePage(Driver);
            homePage.dressButton.Click();
        }
        
        [Given(@"I add (.*) dresses into the cart")]
        public void GivenIAddDressesIntoTheCart(int p0)
        {
            DressesPage dressPage = new DressesPage(Driver);
            dressPage.AddDressesToCart();
        }
        
        [When(@"I navigate to cart")]
        public void WhenINavigateToCart()
        {
            DressesPage dressPage = new DressesPage(Driver);
            Thread.Sleep(2000);
            dressPage.proceedCheckoutButton.Click();
        }
        
        [Then(@"price should add up")]
        public void ThenPriceShouldAddUp()
        {
            CheckoutPage checkoutPage = new CheckoutPage(Driver);
            var total = checkoutPage.GetTotalPrice();
            var totalElementText = Driver.FindElement(By.XPath("/html/body/div/div[2]/div/div[3]/div/div[2]/table/tfoot/tr[1]/td[3]")).Text.Split('$');
            Assert.AreEqual(total, Convert.ToDouble(totalElementText[1]));
        }
    }
}
