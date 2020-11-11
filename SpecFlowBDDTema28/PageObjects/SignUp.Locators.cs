using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumProjectJsonFile.PageObjects
{
    partial class SignUp
    {
        //private IWebElement NameTextBox => _driver.FindElement(By.XPath("/html/body/div/div/div[2]/form/div[1]/input"));
        //private IWebElement EmailTextBox => _driver.FindElement(By.XPath("/html/body/div/div/div[2]/form/div[2]/input"));

        //private IWebElement PhoneTextBox => _driver.FindElement(By.XPath("/html/body/div/div/div[2]/form/div[3]/input"));
        // private IWebElement AddressTextBox => _driver.FindElement(By.XPath("/html/body/div/div/div[2]/form/div[4]/textarea"));
        //private IWebElement PasswordTextBox => _driver.FindElement(By.XPath("/html/body/div/div/div[2]/form/div[6]/input"));
        //private IWebElement InscriereButton => _driver.FindElement(By.XPath("/html/body/div/div/div[2]/form/button"));
        public IWebElement NameTextBox => _driver.FindElement(By.XPath("//input[@name='name']"));
        public IWebElement EmailTextBox => _driver.FindElement(By.XPath("//input[@name='email']"));
        public IWebElement PhoneTextBox => _driver.FindElement(By.XPath("//input[@name='phone']"));
        public IWebElement AddressTextBox => _driver.FindElement(By.XPath("//textarea[@name='address']"));
        public IWebElement PasswordTextBox => _driver.FindElement(By.XPath("//input[@name='password_1']"));
        public IWebElement PasswordRepeatTextBox => _driver.FindElement(By.XPath("//input[@name='password_2']"));
        public IWebElement SignUpButton => _driver.FindElement(By.XPath("//button[@type='submit']"));



    }
}
