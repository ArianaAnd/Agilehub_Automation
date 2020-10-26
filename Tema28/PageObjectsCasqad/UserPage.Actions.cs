using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema28.PageObjectsCasqad
{
    partial class UserPage
    {
        private IWebDriver _driver;
        private WebDriverWait _driverWait;
        public UserPage(IWebDriver driver)
        {
            _driver = driver;
            // setam driverul sa astepte cate 3 secunde pentru fiecere element unde e folosit
            _driverWait = new WebDriverWait(_driver, TimeSpan.FromSeconds(3));

            //ignora exceptiile in momentul in care nu gaseste elementul
            _driverWait.IgnoreExceptionTypes();
        }
        public void GoToEditPage()
        {
            EditareButton.Click();
        }
        public void SelectUserRole(string roleUser)
        {
            SelectElement role = new SelectElement(Dropdown);
            role.SelectByText(roleUser);
        }
    }
}
