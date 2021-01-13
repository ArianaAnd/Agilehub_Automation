using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace SpecflowBDD_PhpTravel.PageObjects
{
    partial class MyAccount
    {
        public IWebElement MyAccountDroplist =>
            _driver.FindElement(By.XPath("//*[@id='header-waypoint-sticky']/div[1]/div/div/div[2]/div/ul/li[3]/div"));
        public IWebElement LoginDroplist =>
            _driver.FindElement(By.XPath("//*[@id='header-waypoint-sticky']/div[1]/div/div/div[2]/div/ul/li[3]/div/div/div/a[1]"));
        public IWebElement SignUpDroplist =>
            _driver.FindElement(By.XPath("//*[@id='header-waypoint-sticky']/div[1]/div/div/div[2]/div/ul/li[3]/div/div/div/a[2]"));

    }
}
