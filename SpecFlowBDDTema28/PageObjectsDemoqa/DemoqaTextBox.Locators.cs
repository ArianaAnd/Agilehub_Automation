using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowBDDTema28.PageObjectsDemoqa
{
    partial class DemoqaTextBox
    {
        

        private IWebElement fullName => _driver.FindElement(By.XPath("//input[@type='text' and @id='userName']"));
        private IWebElement emailField => _driver.FindElement(By.XPath("//input[@type='email' and @id='userEmail']"));
        private IWebElement currentAddressField => _driver.FindElement(By.XPath("//*[@id='currentAddress']"));
        private IWebElement permanentAddressField => _driver.FindElement(By.XPath("//*[@id='permanentAddress']"));
        public IWebElement submit => _driver.FindElement(By.XPath("//*[@id='submit']"));
        public IWebElement confirmationDialogTitle => _driver.FindElement(By.Id("example-modal-sizes-title-lg"));
    }
}
