using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SpecFlowBDDTema28.Dto;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SpecFlowBDDTema28.PageObjects
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

        //public void AddVal(string user, string password)
        //{
        //    emailTextBox.Click();
        //    emailTextBox.SendKeys(user);
        //    passwordTextBox.SendKeys(password);
        //    submitButton.Click();
        //}

        //internal void VerifyElementContainsText(IWebElement alertMessage, string v)
        //{
        //    throw new NotImplementedException();
        //}
        public void EnterCredentials(string user, string password)
        {
            emailTextBox.Click();
            emailTextBox.SendKeys(user);
            passwordTextBox.SendKeys(password);
            submitButton.Click();
        }
        public void LoginIntoApplication(UserDto user)
        {
            emailTextBox.SendKeys(user.userEmail);
            passwordTextBox.SendKeys(user.userPassword);
            AutentificareButtonLoginPage.Click();
        }
        public void VerifyElementContainsText(IWebElement element, string text)
        {
            Assert.IsTrue(element.Text.Contains(text));
        }
        public void VerifyElementIsDisplayed(IWebElement element)
        {
            Assert.IsTrue(element.Displayed);
        }
        public void NavigateToUrl(string pageUrl)
        {
            _driver.Navigate().GoToUrl(pageUrl);
        }
    }
}
