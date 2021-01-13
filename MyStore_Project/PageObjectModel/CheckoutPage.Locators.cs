using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyStore_Project.PageObjects
{
    partial class CheckoutPage
    {
        private IWebElement checkoutButton => _driver.FindElement(By.XPath("/html/body/div/div[2]/div/div[3]/div/p[2]/a[1]"));
        private IWebElement addressProceedCheckoutButton => _driver.FindElement(By.XPath("/html/body/div/div[2]/div/div[3]/div/form/p/button"));
        private IWebElement shippingProceedCheckoutButton => _driver.FindElement(By.XPath("/html/body/div/div[2]/div/div[3]/div/div/form/p/button"));
        private IWebElement payBankButton => _driver.FindElement(By.XPath("/html/body/div/div[2]/div/div[3]/div/div/div[3]/div[1]/div/p/a"));
        private IWebElement confirmOrderButton => _driver.FindElement(By.XPath("/html/body/div/div[2]/div/div[3]/div/form/p/button"));
        private IWebElement orderCompleteText => _driver.FindElement(By.XPath("/html/body/div/div[2]/div/div[3]/div/div/p/strong")); //Your order on My Store is complete.
        private IWebElement agreeTermsButton => _driver.FindElement(By.XPath("/html/body/div/div[2]/div/div[3]/div/div/form/div/p[2]/div/span/input"));
        private IWebElement termsOfServicePopUp => _driver.FindElement(By.XPath("/html/body/div[2]/div/div/div/div/p"));




    }
}
