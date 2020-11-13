using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowBDDTema28.PageObjectsCasqad
{
    partial class ProductPage
    {
        private IWebElement addToCartButton =>
            _driverWait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//a[text()='Adaugă în coș']")));
    }
}
