using BoDi;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace TestSpecSelProj
{
    public enum BrowserType
    {
        Chrome,
        Firefox
    }
    [Binding]
    public sealed class Hooks
    {
        // For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks
        private readonly IObjectContainer _objectContainer;
        private BrowserType _browserType;
        public static IWebDriver _driver;
        public Hooks(IObjectContainer objectContainer)
        {
            _objectContainer = objectContainer;
        }

        public void CreateDriver()
        {
            var browserType = TestContext.Parameters.Get("Browser", "Chrome");
            _browserType = (BrowserType)Enum.Parse(typeof(BrowserType), browserType);
            ChooseDriverInstance(_browserType);
            _driver.Manage().Window.Maximize();
        }

        public void ChooseDriverInstance(BrowserType browserType)
        {
            switch (browserType)
            {
                case BrowserType.Chrome:
                    _driver = new ChromeDriver();
                    _objectContainer.RegisterInstanceAs<IWebDriver>(_driver);
                    break;
                case BrowserType.Firefox:
                    _driver = new FirefoxDriver();
                    _objectContainer.RegisterInstanceAs<IWebDriver>(_driver);
                    break;
            }
        }
        [BeforeScenario]
        public void BeforeScenario()
        {
            CreateDriver();
        }

        [AfterScenario]
        public void AfterScenario()
        {
            {
                _driver.Quit();
            }
        }
    }
}
