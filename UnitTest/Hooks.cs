using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest
{
    public class Hooks
    {

        //aici se trec instantele 
        //Manage Nuget Selenium, Chrome Selenium, Firefoc Selenium
        protected IWebDriver Driver;
        [SetUp]
        public void Setup()
        {
            Driver = new ChromeDriver();
            Driver.Manage().Window.Maximize();
            Driver.Navigate().GoToUrl("http://demosite.casqad.org/");


        }
        [TearDown]
        public void TearDown()
        {
            Driver.Quit();
        }

    }
}
