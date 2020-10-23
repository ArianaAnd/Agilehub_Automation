﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace SeleniumTestProject.PageObjects
{
    partial class HomePage
    {
        private IWebDriver _driver;

        public HomePage(IWebDriver driver)
        {
            _driver = driver;
        }
        private IWebElement AutentificareButton => _driver.FindElement(By.XPath("//a[text()='Autentificare']"));
        private IWebElement InscriereButton => _driver.FindElement(By.XPath("//a[text()='Înscriere']"));
        public IWebElement DeconectareButton => _driver.FindElement(By.XPath("//a[text()='Deconectare']"));

        private IWebElement VeziDetaliiButon => _driver.FindElement(By.CssSelector(".btn-primary"));
    }
}
