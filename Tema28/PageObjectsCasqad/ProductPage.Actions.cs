using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Tema28.PageObjectsCasqad
{
    partial class ProductPage
    {
        private IWebDriver _driver;
        private WebDriverWait _driverWait;
        public ProductPage(IWebDriver driver)
        {
       
            _driver = driver;
            // setam driverul sa astepte cate 3 secunde pentru fiecere element unde e folosit
            _driverWait = new WebDriverWait(_driver, TimeSpan.FromSeconds(3));

            //ignora exceptiile in momentul in care nu gaseste elementul
            _driverWait.IgnoreExceptionTypes();
        }
        public void AdaugaInCos()
        {
            AdaugaInCosButton.Click();
        }
        public bool VerifyErrorMessageAddInCart(IWebElement element)
        {
            return element.Displayed;
       }
    }
}
