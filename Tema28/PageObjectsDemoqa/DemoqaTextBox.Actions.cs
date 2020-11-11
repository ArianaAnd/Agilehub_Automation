using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema28.PageObjectsDemoqa
{
    partial class DemoqaTextBox
    {
        private IWebDriver _driver;
        private WebDriverWait _driverWait;

        public DemoqaTextBox(IWebDriver driver)
        {
            _driver = driver;
            // setam driverul sa astepte cate 3 secunde pentru fiecere element unde e folosit
            _driverWait = new WebDriverWait(_driver, TimeSpan.FromSeconds(3));

            //ignora exceptiile in momentul in care nu gaseste elementul
            _driverWait.IgnoreExceptionTypes();

        }
        public void FillDemoqaTextBox()
        {
            fullName.SendKeys("Andrisan Ariana");
            emailField.SendKeys("ariana@yahoo.com");
            ((IJavaScriptExecutor)_driver).ExecuteScript("window.scrollTo(0, 500)");
            currentAddressField.SendKeys("Brasov Brasov");
            ((IJavaScriptExecutor)_driver).ExecuteScript("window.scrollTo(0, 500)");
            permanentAddressField.SendKeys("Brasov Brasov");
            submit.Click();
        }
        public bool VerifyElementDisplayed(IWebElement element)
        {
            return element.Displayed;
        }
    }
}
