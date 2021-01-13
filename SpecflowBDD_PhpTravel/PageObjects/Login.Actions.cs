using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace SpecflowBDD_PhpTravel.PageObjects
{
   partial class Login
    {
        private IWebDriver _driver;
        private WebDriverWait _driverWait;

        public Login(IWebDriver driver)
        {
            _driver = driver;

            _driverWait = new WebDriverWait(_driver, TimeSpan.FromSeconds(200));

            _driverWait.IgnoreExceptionTypes();

        }
        public void EnterCredentials(UserDto user)
        {
            Email.Click();
            var validUser = user.GetUservalid();
            Email.SendKeys(validUser.userEmail);
            Password.SendKeys(validUser.userPassword);
            SignUpButton.Click();
        }

        public void EnterCredentials(string user, string password)
        {
            Email.Click();
            Email.SendKeys(user);
            Password.SendKeys(password);
            SignUpButton.Click();
        }
    }
}
