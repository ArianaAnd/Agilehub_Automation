using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowBDDTema28.PageObjects
{
    partial class AdminPage
    {
        private IWebDriver _driver;
        private WebDriverWait _driverWait;
        public AdminPage(IWebDriver driver)
        {
            _driver = driver;

            _driverWait = new WebDriverWait(_driver, TimeSpan.FromSeconds(20));

            _driverWait.IgnoreExceptionTypes();

        }

        public void ClickUsersBtn()
        {
            usersButton.Click();
        }

        public void EditUsers(string name, string email, string phone)
        {
            ClickUsersBtn();
            editUserButton.Click();
            userNameAdminTextBox.Clear();
            userNameAdminTextBox.SendKeys(name);
            userEmailAdminTextBox.Clear();
            userEmailAdminTextBox.SendKeys(email);
            userPhoneAdminTextBox.Clear();
            userPhoneAdminTextBox.SendKeys(phone);
            updateUserButton.Click();
        }
    }
}
