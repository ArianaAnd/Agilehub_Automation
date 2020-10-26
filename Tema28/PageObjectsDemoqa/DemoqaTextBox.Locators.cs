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

        private IWebElement fullName => _driver.FindElement(By.XPath("//input[@type='text' and @id='userName']"));
        private IWebElement emailField => _driver.FindElement(By.XPath("//input[@type='email' and @id='userEmail']"));
        private IWebElement currentAddressField => _driver.FindElement(By.XPath("//*[@id='currentAddress']"));
        private IWebElement permanentAddressField => _driver.FindElement(By.XPath("//*[@id='permanentAddress']"));
        public IWebElement submit => _driver.FindElement(By.XPath("//*[@id='submit']"));
    }
}
