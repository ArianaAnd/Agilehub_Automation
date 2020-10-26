using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema28.PageObjectsCasqad
{
    partial class LoginPage
    {
        //Login Page
        public IWebElement AutentificareButton => _driver.FindElement(By.XPath("//a[text()='Autentificare']"));
        public IWebElement DeconectareButton => _driver.FindElement(By.XPath("//a[text()='Deconectare']"));
        private IWebElement EmailFieldTextBox => _driver.FindElement(By.XPath("input[type=email]")); 
        private IWebElement PasswordFieldTextBox => _driver.FindElement(By.XPath("input[type=password]"));
         private IWebElement Administrare => _driver.FindElement(By.XPath("//*[@id='collapsibleNavbar']/ul[2]/li[3]/a"));
        
    }
}
