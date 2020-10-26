using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema28.PageObjectsTeatruSica

{
    partial class TeatruSica
    {
     
        //Copy Xpath
        private IWebElement teamButton => _driverWait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id='menu-item-2914']/a/span[2]")));
        private IWebElement artistButton => _driverWait.Until(ExpectedConditions.ElementIsVisible(By.XPath("/html/body/div[2]/div/div[2]/div[1]/div/div[5]/div/a[1]/figure/div/div")));
        private IWebElement artistClickImage => _driverWait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id='av-layout-grid-1']/div[1]/div/div[1]/section/div/p[2]/a/strong")));
        private IWebElement firstShow => _driverWait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id='av-layout-grid-1']/div[1]/div/div[1]/section/div/p[2]/a")));
        public IWebElement NameShowReturn => _driverWait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id='av-layout-grid-1']/div[2]/div/div/h3")));
       
    }
}
