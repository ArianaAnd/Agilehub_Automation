using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema28.PageObjectsCasqad
{
    partial class ProductPage
    {
        ////input[@id=’UserName’] => RelativeXPath
        ////html/body/div[2]/div[1]/div/div/div[5]/input => AbsoluteXPath
        private IWebElement AdaugaInCosButton => _driver.FindElement(By.XPath("//a[@class='btn btn-primary btn-block']"));
    }
}
