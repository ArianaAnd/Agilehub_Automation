using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumProjectJsonFile.PageObjects
{
    partial class SignUp
    {
        private IWebDriver _driver;
        private WebDriverWait _driverWait;
        public SignUp(IWebDriver driver)
        {
            _driver = driver;

            _driverWait = new WebDriverWait(_driver, TimeSpan.FromSeconds(20));

            _driverWait.IgnoreExceptionTypes();

        }

        public void EnterSignup()
        {
            signUpButton.Click();
        }

        public void SigUpFormFill()
        {
            signUpNameTextBox.SendKeys("Andrisan Ariana");
            signUpEmailTextBox.SendKeys("ariana@yahoo.com");
            signUpPhoneTextBox.SendKeys("0722334455");
            signUpAddressTextBox.SendKeys("Brasov");
            signUpPasswordextBox.SendKeys("parola123");
            signUpPasswordRepeatTextBox.SendKeys("parola123");
            signUpInscriereButton.Click();
        }
    }
}
