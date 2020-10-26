using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema28.PageObjectsCasqad
{
    partial class InregistrationPage
    {
        private IWebDriver _driver;
        private WebDriverWait _driverWait;
        public InregistrationPage(IWebDriver driver)
        {
           
            _driver = driver;
            // setam driverul sa astepte cate 3 secunde pentru fiecere element unde e folosit
            _driverWait = new WebDriverWait(_driver, TimeSpan.FromSeconds(3));

            //ignora exceptiile in momentul in care nu gaseste elementul
            _driverWait.IgnoreExceptionTypes();

        }

        public void GoToInregistrationPage()
        {
            inscriereField.Click();
            nameField.SendKeys("Ariana");
            emailField.SendKeys("test@yahoo.com");
            phoneField.SendKeys("045555668");
            addressField.SendKeys("Brasov Brasov");
            passwordField.SendKeys("abcdef");
            passwordRetryField.SendKeys("abcdef");

        }
     
    }
}
