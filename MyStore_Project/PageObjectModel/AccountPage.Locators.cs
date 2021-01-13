using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace MyStore_Project.PageObjectModel
{
   partial class AccountPage
    {
        private IWebDriver _driver;
        private WebDriverWait _driverWait;

        public AccountPage(IWebDriver driver)
        {
            _driver = driver;
            // setam driverul sa astepte cate 3 secunde pentru fiecere element unde e folosit
            _driverWait = new WebDriverWait(_driver, TimeSpan.FromSeconds(3));

            //ignora exceptiile in momentul in care nu gaseste elementul
            _driverWait.IgnoreExceptionTypes();
        }

        public void CheckWishList()
        {
            ((IJavaScriptExecutor)_driver).ExecuteScript("window.scrollTo(0, 0)");
            accountButton.Click();
            Thread.Sleep(500);
            myWishListButton.Click();
            firstWishListInTableBttn.Click();
        }
    }
}
