using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema28.PageObjectsDemoqa
{
    partial class DemoqaTextBox
    {
        public void FillDemoqaTextBox()
        {
            fullName.SendKeys("Andrisan Ariana");
            emailField.SendKeys("ariana@yahoo.com");
            currentAddressField.SendKeys("Brasov Brasov");
            permanentAddressField.SendKeys("Brasov Brasov");
            submit.Click();
        }
        public bool VerifyElementDisplayed(IWebElement element)
        {
            return element.Displayed;
        }
    }
}
