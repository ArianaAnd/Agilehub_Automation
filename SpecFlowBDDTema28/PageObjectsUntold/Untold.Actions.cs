using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowBDDTema28.PageObjectsUntold
{
    partial class Untold
    {
        private IWebDriver _driver;
        private WebDriverWait _driverWait;
        public Untold(IWebDriver driver)
        {
            _driver = driver;

            _driverWait = new WebDriverWait(_driver, TimeSpan.FromSeconds(30));

            _driverWait.IgnoreExceptionTypes();

        }
       

        public void GoToUntoldPage()
        {
            menuButton.Click();
            homeButton.Click();
        }
    }
}
