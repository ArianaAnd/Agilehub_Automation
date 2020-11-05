using System;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace SpecFlowSeleniumBDD.PageObjects
{
    partial class LoginPage
    {
        private IWebDriver _driver;
        private WebDriverWait _driverWait;
        public LoginPage(IWebDriver driver)
        {
            _driver = driver;
            _driverWait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
            _driverWait.IgnoreExceptionTypes(typeof(NoSuchElementException));
        }


        public void EnterCredentials(string user, string password)
        {
            EmailFieldTextBox.Click();
            EmailFieldTextBox.SendKeys(user);
            PasswordFieldTextBox.SendKeys(password);
            submitButton.Click();
        }
        public void LoginIntoApplication(UserDto user)
        {
            EmailFieldTextBox.SendKeys(user.userEmail);
            PasswordFieldTextBox.SendKeys(user.userPassword);
            AutentificareButtonLoginPage.Click();
        }
       
    }
}
