using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace SpecflowBDD_PhpTravel.PageObjects
{
    partial class Flights
    {

       
        public IWebElement PageHeading => _driver.FindElement(By.XPath("//h3[@class='heading-title']/span[2]"));
        public IWebElement HeadingFrom => _driver.FindElement(By.XPath("//h3/span[1]"));
        public IWebElement HeadingTo => _driver.FindElement(By.XPath("//h3/span[2]"));

        public IWebElement OneWay => _driver.FindElement(By.XPath("//*[@id='flights'']/div/div/form/div/div/div[1]/div[1]/div/div[1]/label"));

        public IWebElement RoundTrip =>
            _driver.FindElement(By.XPath("//*[@id='flights'']/div/div/form/div/div/div[1]/div[1]/div/div[2]/label"));

        public IWebElement Economy => _driver.FindElement(By.XPath("//*[@id='flights']/div/div/form/div/div/div[1]/div[2]/div/div"));
        public IWebElement From => _driver.FindElement(By.XPath("//*[@id='s2id_location_from']/a/span[1]"));
        public IWebElement To => _driver.FindElement(By.XPath("//*[@id='s2id_location_to'']/a/span[1]"));
        public IWebElement Depart => _driver.FindElement(By.XPath("//*[@id='FlightsDateStart']"));
        public IWebElement AdultsButton => _driver.FindElement(By.XPath("//*[@id='flights']/div/div/form/div/div/div[3]/div/div/div/div/div/div/div[1]/div/div[2]/div"));
        public IWebElement ChildButton => _driver.FindElement(By.XPath("//*[@id='flights']/div/div/form/div/div/div[3]/div/div/div/div/div/div/div[2]/div/div[2]/div"));
        public IWebElement SearchButton => _driver.FindElement(By.XPath("//body/div[2]/div[1]/div[1]/div[3]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/form[1]/div[1]/div[1]/div[4]/button[1]"));
        public IWebElement InfantsButton => _driver.FindElement(By.XPath("//*[@id='flights']/div/div/form/div/div/div[3]/div[3]/div/div/div[3]/div/div[2]/div/input"));
        
    }
}
