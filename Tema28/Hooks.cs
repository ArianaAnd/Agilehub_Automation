﻿using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema28
{
    public class Hooks
    {
        protected IWebDriver Driver;
        [SetUp]
        public void Setup()
        {
            Driver = new ChromeDriver();

            Driver.Manage().Window.Maximize();

            
        }
        [TearDown]
        public void TearDown()
        {
            Driver.Quit();

        }
    }
}
