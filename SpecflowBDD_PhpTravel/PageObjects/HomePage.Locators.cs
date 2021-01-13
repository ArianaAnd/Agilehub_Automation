using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace SpecflowBDD_PhpTravel.PageObjects
{
    partial class HomePage
    {
        //Tabel locators
        public IWebElement HotelsButton => _driver.FindElement(By.XPath("//a[contains(text(),'Hotels')]"));
        public IWebElement FlightsButton => _driver.FindElement(By.XPath("//a[contains(text(),'Flights')]"));
        public IWebElement BoatsButton => _driver.FindElement(By.XPath("//a[contains(text(),'Boats')]"));
        public IWebElement RentalsButton => _driver.FindElement(By.XPath("//a[contains(text(),'Rentals')]"));
        public IWebElement ToursButton => _driver.FindElement(By.XPath("//a[contains(text(),'Tours')]"));
        public IWebElement CarsButton => _driver.FindElement(By.XPath("//a[contains(text(),'Cars')]"));
        public IWebElement VisaButton => _driver.FindElement(By.XPath("//a[contains(text(),'Visa')]"));

        //Home Page Blog

        public IWebElement LatestOnBlogs => _driver.FindElement(By.XPath("//*[@id='MenuHorizon28_01']/div/div/div[1]/div/a/div[1]/img"));
        public IWebElement FeaturedHotels => _driver.FindElement(By.XPath("////*[@id='MenuHorizon28_01']/div/div/div[2]"));
    }
}
