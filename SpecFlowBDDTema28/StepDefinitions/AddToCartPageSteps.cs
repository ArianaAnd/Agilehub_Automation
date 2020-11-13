using SpecFlowBDDTema28.PageObjects;
using System;
using TechTalk.SpecFlow;
using SpecFlowBDDTema28.PageObjectsCasqad;
using SpecFlowBDDTema28.Dto;

namespace SpecFlowBDDTema28.StepDefinitions
{
    [Binding]
    public class AddToCartPageSteps:Hooks
    {
      
        
        [When(@"I add a product to the cart")]
        public void WhenIAddAProductToTheCart()
        {
            HomePage homePage = new HomePage(Driver);
            ProductPage productPage = new ProductPage(Driver);
           Driver.Navigate().GoToUrl("http://demosite.casqad.org/");
            homePage.ViewDetails();
            productPage.AddToCart();
            
        }
        
        [Then(@"I need to login to complete the action")]
        public void ThenINeedToLoginToCompleteTheAction()
        {
            LoginPage loginPage = new LoginPage(Driver);
            loginPage.VerifyElementContainsText(loginPage.AlertMessage, "Pentru a efectua aceasta actiune, va rugam sa va autentificati");
        }
        
        [Then(@"I see the order button in my cart")]
        public void ThenISeeTheOrderButtonInMyCart()
        {
            AddToCart addToCart = new AddToCart(Driver);
            LoginPage loginPage = new LoginPage(Driver);
            loginPage.VerifyElementIsDisplayed(addToCart.ComandaAcumButton);
        }
    }
}
