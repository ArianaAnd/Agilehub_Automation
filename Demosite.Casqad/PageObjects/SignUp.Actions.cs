using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Demosite.Casqad.PageObjects
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

        public void FormFill(UserDto user)
        {
            NameTextBox.SendKeys(user.userName);
            EmailTextBox.SendKeys(user.userEmail);
            PhoneTextBox.SendKeys(user.userPhone);
            AddressTextBox.SendKeys(user.userAddress);
            PasswordextBox.SendKeys(user.userPassword);
            PasswordRepeatTextBox.SendKeys(user.userPasswordRepeat);

        }
        public void EnterSignup()
        {
            Button.Click();
        }

    }
}
