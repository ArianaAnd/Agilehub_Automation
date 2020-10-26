using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema28.PageObjectsCasqad
{
    partial class UserPage
    {
        private IWebElement EditareButton => _driver.FindElement(By.XPath("//a[@href='/user/edit/4']"));

        private IWebElement Dropdown => _driver.FindElement(By.CssSelector("select[name=role]"));

    }
}
