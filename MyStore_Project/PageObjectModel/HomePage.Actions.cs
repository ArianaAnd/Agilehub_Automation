using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace MyStore_Project.PageObjectModel
{
    partial class HomePage
    {
        private IWebDriver _driver;
        private WebDriverWait _driverWait;

        public HomePage(IWebDriver driver)
        {
            _driver = driver;
            // setam driverul sa astepte cate 3 secunde pentru fiecere element unde e folosit
            _driverWait = new WebDriverWait(_driver, TimeSpan.FromSeconds(3));

            //ignora exceptiile in momentul in care nu gaseste elementul
            _driverWait.IgnoreExceptionTypes();

        }

        public void AuthentificatePage()
        {
            signInButton.Click();
        }

        public void AddDressToCartPage()
        {
            homeButton.Click();
            ((IJavaScriptExecutor)_driver).ExecuteScript("window.scrollTo(0, 600)");
            printedDressButton.Click();
            System.Threading.Thread.Sleep(2000);
            printedDressAddToCartButton.Click();


        }
    }
}
