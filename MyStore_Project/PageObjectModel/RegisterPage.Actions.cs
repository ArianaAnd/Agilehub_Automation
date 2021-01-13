using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace MyStore_Project.PageObjectModel
{
    partial class RegisterPage
    {
        private IWebDriver _driver;
        private WebDriverWait _driverWait;

        public RegisterPage(IWebDriver driver)
        {
            _driver = driver;
            // setam driverul sa astepte cate 3 secunde pentru fiecere element unde e folosit
            _driverWait = new WebDriverWait(_driver, TimeSpan.FromSeconds(3));

            //ignora exceptiile in momentul in care nu gaseste elementul
            _driverWait.IgnoreExceptionTypes();
        }
        public void AddRegistrationCredentials(UserDto user)
        {
            System.Threading.Thread.Sleep(2000);
            maleGenderRadio.Click();
            firstNameTextBox.Click();
            firstNameTextBox.SendKeys(user.userFirstName);
            LastNameTextBox.SendKeys(user.userLastName);
            passwordTextBox.Click();
            passwordTextBox.SendKeys(user.userPassword);
            daysDropdown.Click();
            day1DropdownOption.Click();
            monthsDropdown.Click();
            firstMonthDropdownOption.Click();
            yearsDropdown.Click();
            YearDropdownOption.Click();
            addressFirstNameTextBox.Click();
            addressFirstNameTextBox.SendKeys(user.userAddressFirstName);
            addressLastNameTextBox.SendKeys(user.userAddressLastName);
            addressTextBox.Click();
            addressTextBox.SendKeys(user.userAddress);
            cityTextBox.Click();
            cityTextBox.SendKeys(user.userCity);
            stateDropdown.Click();
            stateDropdownOption.Click();
            phoneTextBox.Click();
            phoneTextBox.SendKeys(user.userPhone);

        }
    }
}
