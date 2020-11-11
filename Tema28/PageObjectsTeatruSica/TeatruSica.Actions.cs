using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema28.PageObjectsTeatruSica
{
    partial class TeatruSica
    {
        private IWebDriver _driver;
        private WebDriverWait _driverWait;

        public TeatruSica(IWebDriver driver)
        {
            _driver = driver;

            _driverWait = new WebDriverWait(_driver, TimeSpan.FromSeconds(3));


            _driverWait.IgnoreExceptionTypes();
        }
        public void GoToTeatruSicaPage()
        {
           teamButton.Click();            ((IJavaScriptExecutor)_driver).ExecuteScript("window.scrollTo(0,500)");
            artistButton.Click();
            ((IJavaScriptExecutor)_driver).ExecuteScript("window.scrollTo(0,600)");
            artistClickImage.Click();
            firstShow.Click();



        }
       
    }
}
