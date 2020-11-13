using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowBDDTema28.PageObjectsCasqad
{
    partial class AddToCart
    {
        public IWebElement ComandaAcumButton => _driver.FindElement(By.ClassName("btn-danger"));
    }
}
