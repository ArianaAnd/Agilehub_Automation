using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowBDDTema28.PageObjects
{
    partial class LoginPage
    {
        //private IWebElement emailTextBox => _driver.FindElement(By.XPath("/html/body/div/div/div[2]/form/div[1]/input"));
        private IWebElement emailTextBox => _driver.FindElement(By.CssSelector("input[type=email]"));
        //private IWebElement passwordTextBox => _driver.FindElement(By.XPath("/html/body/div/div/div[2]/form/div[2]/input"));
         private IWebElement passwordTextBox => _driver.FindElement(By.CssSelector("input[type=password]"));
        //private IWebElement submitButton => _driver.FindElement(By.XPath("/html/body/div/div/div[2]/form/button"));
        private IWebElement submitButton => _driver.FindElement(By.CssSelector("button[type=submit]"));
         public IWebElement AlertMessage => _driver.FindElement(By.ClassName("alert"));
       private IWebElement AutentificareButtonLoginPage => _driverWait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("button[type=submit]")));
    }
}
