using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema28.PageObjectsCasqad
{
    partial class Navbar
    {
         public IWebElement laptopuri => _driver.FindElement(By.XPath("//*[@id='collapsibleNavbar']/ul[1]/li[1]/a"));
        private IWebElement Telefoane => _driver.FindElement(By.XPath("//*[@id='collapsibleNavbar']/ul[1]/li[2]/a"));
        private IWebElement Foto => _driver.FindElement(By.XPath("//*[@id='collapsibleNavbar']/ul[1]/li[3]/a"));
        private IWebElement Carti => _driver.FindElement(By.XPath("//*[@id='collapsibleNavbar']/ul[1]/li[4]/a"));
        private IWebElement Accesorii => _driver.FindElement(By.XPath("//*[@id='collapsibleNavbar']/ul[1]/li[5]/a"));
        private IWebElement AllNavbar => _driver.FindElement(By.XPath("//*[@id='collapsibleNavbar']/ul[1]"));
    }
}
