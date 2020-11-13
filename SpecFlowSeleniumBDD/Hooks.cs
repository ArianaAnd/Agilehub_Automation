﻿using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using TechTalk.SpecFlow;
using TestContext = NUnit.Framework.TestContext;


namespace SpecFlowSeleniumBDD
{
    public enum BrowserType
    {
        Chrome,
        Firefox
    }
    [Binding]
    public  class Hooks
    {

        private BrowserType _browserType;
        protected IWebDriver Driver;

        // For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks

        [BeforeScenario]
        public void BeforeScenario()
        {
            var browserType = TestContext.Parameters.Get("Browser", "Chrome");

            //TODO: implement logic that has to run before executing each scenario
        }
        public void ChooseDriverInstance(BrowserType browserType)
                    //var optionsChrome = new ChromeOptions();
                    //Driver = new RemoteWebDriver(new Uri(" http://localhost:4446/wd/hub"), optionsChrome);
                    Driver = new ChromeDriver();
                    //var optionsFirefox = new FirefoxOptions();
                    //Driver = new RemoteWebDriver(new Uri(" http://localhost:4446/wd/hub"), optionsFirefox);
                    Driver = new FirefoxDriver();


        [AfterScenario]
        public  void AfterScenario()
        {
            Driver.Quit();
            //TODO: implement logic that has to run after executing each scenario
        }


 

    }
}