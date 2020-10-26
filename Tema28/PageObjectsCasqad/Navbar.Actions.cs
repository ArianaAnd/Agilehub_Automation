using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema28.PageObjectsCasqad
{
    partial class Navbar
    {
        private IWebDriver _driver;
        private WebDriverWait _driverWait;

        public Navbar(IWebDriver driver)
        {
            _driver = driver;
            // setam driverul sa astepte cate 3 secunde pentru fiecere element unde e folosit
            _driverWait = new WebDriverWait(_driver, TimeSpan.FromSeconds(3));

            //ignora exceptiile in momentul in care nu gaseste elementul
            _driverWait.IgnoreExceptionTypes();

        }

        public void Navigare()
        {
            laptopuri.Click();
            Telefoane.Click();
            Foto.Click();
            Carti.Click();
            Accesorii.Click();
        }
        public bool VerifyErrorMessageAddInCart(IWebElement element)
        {
            return element.Displayed;
        }
    }
}
