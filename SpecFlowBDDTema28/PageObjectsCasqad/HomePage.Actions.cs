using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowBDDTema28.PageObjects
{
    partial class HomePage
    {
        private IWebDriver _driver;
        private WebDriverWait _driverWait;

        public HomePage(IWebDriver driver)
        {
            _driver = driver;

            _driverWait = new WebDriverWait(_driver, TimeSpan.FromSeconds(30));

            _driverWait.IgnoreExceptionTypes();
        }
        public void Authenticate()
        {
            authenticationButton.Click();
        }

        public void AddToCart(IWebElement element)
        {
            element.Click();
            addToCartButton.Click();
        }

        public void ClickeveryMenu()
        {
            laptopsButton.Click();
            phonesButton.Click();
            phonesButton.Click();
            accesoryButton.Click();

        }
        public void ViewDetails()
        {
            viewDetails.Click();
        }
        public void NavigateToUrl(string pageUrl)
        {
            _driver.Navigate().GoToUrl(pageUrl);
        }
    }
}
