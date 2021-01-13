using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace SpecflowBDD_PhpTravel.PageObjects
{
    partial class Hotels
    {
        public IWebElement DestinationField => _driver.FindElement(By.XPath("//div[@id='s2id_autogen16']"));
        public IWebElement CheckInCalendar => _driver.FindElement(By.XPath("//input[@id='checkin']"));
        public IWebElement CheckOutCalendar => _driver.FindElement(By.XPath("//input[@id='checkout']"));
        public IWebElement AdultsButton => _driver.FindElement(By.XPath("//*[@id='hotels']/div/div/form/div/div/div[3]/div/div/div/div/div/div/div[1]/div/div[2]/div"));
        public IWebElement ChildButton => _driver.FindElement(By.XPath("//*[@id='hotels']/div/div/form/div/div/div[3]/div/div/div/div/div/div/div[2]/div/div[2]/div"));
        public IWebElement SearchButton => _driver.FindElement(By.XPath("//body/div[2]/div[1]/div[1]/div[3]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/form[1]/div[1]/div[1]/div[4]/button[1]"));
    }
}
