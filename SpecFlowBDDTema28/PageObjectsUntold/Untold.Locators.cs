using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowBDDTema28.PageObjectsUntold
{
    partial class Untold
    {
        private IWebElement menuButton => _driverWait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id='untold-container']/header/div[2]/div[3]/div/button")));
       
        private IWebElement homeButton => _driverWait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id='untold-container']/header/div[2]/div[2]/div[1]/nav/div[1]/a[1]")));
        public IWebElement logo => _driverWait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id='logo']/img")));
    }
}
