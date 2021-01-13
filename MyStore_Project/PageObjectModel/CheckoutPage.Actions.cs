using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyStore_Project.PageObjects
{
    partial class CheckoutPage
    {
        private IWebDriver _driver;
        private WebDriverWait _driverWait;

        public CheckoutPage(IWebDriver driver)
        {
            _driver = driver;
            // setam driverul sa astepte cate 3 secunde pentru fiecere element unde e folosit
            _driverWait = new WebDriverWait(_driver, TimeSpan.FromSeconds(3));

            //ignora exceptiile in momentul in care nu gaseste elementul
            _driverWait.IgnoreExceptionTypes();
        }

        public void ProductCheckout()
        {
            checkoutButton.Click();
            addressProceedCheckoutButton.Click();
            agreeTermsButton.Click();
            shippingProceedCheckoutButton.Click();
            payBankButton.Click();
            confirmOrderButton.Click();
        }

        public void TermsOfService()
        {
           checkoutButton.Click();
            addressProceedCheckoutButton.Click();
            shippingProceedCheckoutButton.Click();
        }

        public double GetTotalPrice()
        {
            ((IJavaScriptExecutor)_driver).ExecuteScript("window.scrollTo(0, 500)");
            var totals = _driver.FindElements(By.XPath("//*[contains(@id, 'total_product_price')]"));

            double totalCost = 0;
            foreach (var total in totals)
            {
                var totalText = total.Text.Split('$');
                totalCost += Convert.ToDouble(totalText[1]);
            }

            return Math.Round(totalCost, 2);
        }
    }
}
