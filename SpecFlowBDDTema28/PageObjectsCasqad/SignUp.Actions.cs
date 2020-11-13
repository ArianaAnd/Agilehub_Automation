using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowBDDTema28.PageObjects
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

        public void ClickSignUp()
        {
            SignUpButton.Click();
        }

        public void SigUpFormFill()
        {
            NameTextBox.SendKeys("Andrisan Ariana");
            EmailTextBox.SendKeys("ariana@yahoo.com");
            PhoneTextBox.SendKeys("0711111111");
            AddressTextBox.SendKeys("Brasov");
            PasswordTextBox.SendKeys("parola123");
            PasswordRepeatTextBox.SendKeys("parola123");
            SignUpButton.Click();
        }
    }
}
