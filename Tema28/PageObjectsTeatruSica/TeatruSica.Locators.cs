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
     
        //Copy Xpath Selector
        private IWebElement teamButton => _driverWait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id='menu-item-2914']/a/span[2]")));
        private IWebElement artistButton => _driverWait.Until(ExpectedConditions.ElementIsVisible(By.XPath("/html/body/div[2]/div/div[2]/div[1]/div/div[5]/div/a[1]/figure/div/div")));
        private IWebElement artistClickImage => _driverWait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id='av-layout-grid-1']/div[1]/div/div[1]/section/div/p[2]/a/strong")));
        //public IWebElement firstShow => _driverWait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//div/p/a/strong"))); ////*[@id='av-layout-grid-1']/div[1]/div/div[1]/section/div/p[2]/a/strong
        public IWebElement firstShow => _driver.FindElement(By.XPath("//div/p/a/strong"));
        public IWebElement NameShowReturn => _driverWait.Until(ExpectedConditions.ElementIsVisible(By.XPath("/html/body/div[2]/div/div[2]/div[2]/div/div/h3"))); // //*[@id='av-layout-grid-1']/div[2]/div/div/h3
        public IWebElement ShowImage => _driverWait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id='av-layout-grid-1']/div[1]/div/div[2]/div/a/span")));
        public IWebElement cumparaBiletButton => _driver.FindElement(By.XPath("//span[text()='CUMPARA BILET']"));
       
    }
}
