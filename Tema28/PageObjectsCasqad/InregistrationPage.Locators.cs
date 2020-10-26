using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema28.PageObjectsCasqad
{
    partial class InregistrationPage
    {
        private IWebElement inscriereField => _driver.FindElement(By.XPath("//*[@id='collapsibleNavbar']/ul[2]/li[2]/a"));
        private IWebElement nameField => _driver.FindElement(By.XPath("//*[@name='name']"));
        private IWebElement emailField => _driver.FindElement(By.XPath("//*[@type='email']"));
        private IWebElement phoneField => _driver.FindElement(By.XPath("//*[@name='phone']"));
        private IWebElement addressField => _driver.FindElement(By.XPath("//*[@name='address']"));
        private IWebElement passwordField => _driver.FindElement(By.XPath("//*[@parola='password_1']"));
        private IWebElement passwordRetryField => _driver.FindElement(By.XPath("//*[@parola='password_2']"));
        private IWebElement inscriereButton => _driver.FindElement(By.XPath("//*[@type='submit']"));
    }
}
