﻿using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using TechTalk.SpecFlow;

namespace MyStore_Project
{
    public enum BrowserType
    {
        Chrome,
        Firefox
    }

    public class Hooks
    {
        // For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks

        private BrowserType _browserType;
        protected IWebDriver Driver;



        [BeforeScenario]
        public void BeforeScenario()
        {
            //TODO: implement logic that has to run before executing each scenario
            var browserType = TestContext.Parameters.Get("Browser", "Chrome");
            _browserType = (BrowserType)Enum.Parse(typeof(BrowserType), browserType);
            if (Driver is null)
            {
                ChooseDriverInstance(_browserType);
                Driver.Manage().Window.Maximize();
            }

            Driver.Navigate().GoToUrl("http://demosite.casqad.org/");

        }

        public void ChooseDriverInstance(BrowserType browserType)
        {
            switch (browserType)
            {
                case BrowserType.Chrome:
                    //var optionsChrome = new ChromeOptions();
                    //Driver = new RemoteWebDriver(new Uri(" http://localhost:4446/wd/hub"), optionsChrome);
                    Driver = new ChromeDriver();
                    break;
                case BrowserType.Firefox:
                    Driver = new FirefoxDriver();
                    break;
            }
        }


        [AfterScenario]
        public void AfterScenario()
        {
            //TODO: implement logic that has to run after executing each scenario

            if (!(Driver is null))
            {
                Driver.Quit();
                Driver = null;
            }

        }
    }
}

