using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTestProject.PageObjects
{
    partial class HomePage
    {
        public void GoToAuthentification()
        {
            AutentificareButton.Click();
        }

        public bool VerifyElementDisplayed(IWebElement element)
        {
            return element.Displayed;
        }

    
    }
}
