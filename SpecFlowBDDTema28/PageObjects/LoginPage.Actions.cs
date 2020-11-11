using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumProjectJsonFile.PageObjects
{
    partial class LoginPage
    {
        private IWebDriver _driver;
        private WebDriverWait _driverWait;
        public LoginPage(IWebDriver driver)
        {
            _driver = driver;

            _driverWait = new WebDriverWait(_driver, TimeSpan.FromSeconds(20));

            _driverWait.IgnoreExceptionTypes();

        }

        public void AddVal(string user, string password)
        {
            emailTextBox.Click();
            emailTextBox.SendKeys(user);
            passwordTextBox.SendKeys(password);
            submitButton.Click();
        }

        internal void VerifyElementContainsText(IWebElement alertMessage, string v)
        {
            throw new NotImplementedException();
        }
    }
}
