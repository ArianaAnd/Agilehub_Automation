using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace SpecflowBDD_PhpTravel.PageObjects
{
    partial class SignUp
    {
        private IWebDriver _driver;
        private WebDriverWait _driverWait;

        public SignUp(IWebDriver driver)
        {
            _driver = driver;

            _driverWait = new WebDriverWait(_driver, TimeSpan.FromSeconds(200));

            _driverWait.IgnoreExceptionTypes();

        }
        public void EnterSignup()
        {
           
        }

        public void SigUpFormFill(UserDto user)
        {
            signUpNameTextBox.SendKeys(user.userName);
            signUpEmailTextBox.SendKeys(user.userEmail);
            signUpPhoneTextBox.SendKeys(user.userPhone);
            signUpAddressTextBox.SendKeys(user.userAddress);
            signUpPasswordextBox.SendKeys(user.userPassword);
            signUpPasswordRepeatTextBox.SendKeys(user.userPasswordRepeat);

        }

        public void AuthenticateNewUser(UserDto user)
        {
            userEmailTextBox.SendKeys(user.userEmail);
            userPasswordTextBox.SendKeys(user.userPassword);
            userAAuthenticateButton.Click();
        }
    }
}
