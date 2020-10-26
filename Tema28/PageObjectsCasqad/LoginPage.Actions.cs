using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Tema28.PageObjectsCasqad
{
    partial class LoginPage
    {
        private IWebDriver _driver;
        private WebDriverWait _driverWait;

        
        public LoginPage(IWebDriver driver)
        {
            _driver = driver;
            // setam driverul sa astepte cate 3 secunde pentru fiecere element unde e folosit
            _driverWait = new WebDriverWait(_driver, TimeSpan.FromSeconds(3));

            //ignora exceptiile in momentul in care nu gaseste elementul
            _driverWait.IgnoreExceptionTypes();

        }
        public void LoginIntoApplication(string emailUser, string passwordUser)
        {
            EmailFieldTextBox.SendKeys(emailUser);
            PasswordFieldTextBox.SendKeys(passwordUser);
            Thread.Sleep(2000);
           
        }

        public void LoginDisconnect(string emailUser, string passwordUser)
        {
            EmailFieldTextBox.SendKeys(emailUser);
            PasswordFieldTextBox.SendKeys(passwordUser);
            AutentificareButton.Click();
            DeconectareButton.Click();
            Thread.Sleep(2000);

        }

        public void LoginClickAdmin(string emailUser, string passwordUser)
        {
            EmailFieldTextBox.SendKeys(emailUser);
            PasswordFieldTextBox.SendKeys(passwordUser);
            AutentificareButton.Click();
            Administrare.Click();
            DeconectareButton.Click();
            Thread.Sleep(2000);

        }


     
        public bool VerifyElementDisplayed(IWebElement element)
        {
            return element.Displayed;
        }
    }
    //public void VerifyErrorMessageAuthentification(string expectedMessage)
    //{
    //    //string expectedMessage = "Cont inexitent! Incercati din nou sau creati un cont aici.";
    //    Assert.IsTrue(ErrorMessageAuthentification.Text.Contains(expectedMessage));
    //}

}


