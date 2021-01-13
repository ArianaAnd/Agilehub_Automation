using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace SpecflowBDD_PhpTravel.PageObjects
{
    partial class HomePage
    {
        private IWebDriver _driver;
        private WebDriverWait _driverWait;

        public HomePage(IWebDriver driver)
        {
            _driver = driver;

            _driverWait = new WebDriverWait(_driver, TimeSpan.FromSeconds(200));

            _driverWait.IgnoreExceptionTypes();

        }

    




        }
    
}

