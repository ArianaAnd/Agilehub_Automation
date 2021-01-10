using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace Demosite.Casqad.PageObjects
{
    partial class SignUp
    {
        private IWebElement EmailTextBox => _driver.FindElement(By.XPath("/html/body/div/div/div[2]/form/div[2]/input"));
        private IWebElement NameTextBox => _driver.FindElement(By.XPath("/html/body/div/div/div[2]/form/div[1]/input"));
        private IWebElement PhoneTextBox => _driver.FindElement(By.XPath("/html/body/div/div/div[2]/form/div[3]/input"));
        private IWebElement AddressTextBox => _driver.FindElement(By.XPath("/html/body/div/div/div[2]/form/div[4]/textarea"));
        private IWebElement PasswordRepeatTextBox => _driver.FindElement(By.XPath("/html/body/div/div/div[2]/form/div[6]/input"));
        private IWebElement Button => _driver.FindElement(By.XPath("//*[@id='collapsibleNavbar']/ul[2]/li[2]/a"));
        public IWebElement InscriereButton => _driver.FindElement(By.XPath("/html/body/div/div/div[2]/form/button"));

        private IWebElement PasswordTextBox => _driver.FindElement(By.XPath("/html/body/div/div/div[2]/form/div[5]/input"));
        private IWebElement userEmailTextBox => _driver.FindElement(By.XPath("/html/body/div/div/div[2]/form/div[1]/input"));
        private IWebElement userPasswordTextBox => _driver.FindElement(By.XPath("/html/body/div/div/div[2]/form/div[2]/input"));
        private IWebElement userAuthenticateButton => _driver.FindElement(By.XPath("/html/body/div/div/div[2]/form/button"));

        public IWebElement Deconectare => _driver.FindElement(By.XPath("/html/body/div/nav/div/ul[2]/li[2]/a"));


    }
}
