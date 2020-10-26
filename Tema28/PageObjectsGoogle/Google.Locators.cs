﻿using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema28.PageObjects
{
    partial class Google
    {
        private IWebDriver _driver;

        public Google(IWebDriver driver)
        {
            _driver = driver;
        }

        private IWebElement searchTextBox => _driver.FindElement(By.XPath("//*[@id='tsf']/div[2]/div[1]/div[1]/div/div[2]/input"));
        private IWebElement searchButton =>_driver.FindElement(By.XPath("//input[@type='submit' and @name='btnK' and @data-ved='0ahUKEwiR4ffex8fsAhUyi8MKHdqCCvsQ4dUDCAs']"));
        private IWebElement imageButton => _driver.FindElement(By.XPath("//*[@id='hdtb-msb-vis']/div[2]/a"));
        private IWebElement firstImage => _driver.FindElement(By.XPath("//*[@id='islrg']/div[1]/div[1]/a[1]/div[1]/img"));
        public IWebElement imageFrame => _driver.FindElement(By.XPath("//*[@id='Sva75c']"));
        private IWebElement acceptButton => _driver.FindElement(By.XPath("//*[@id='introAgreeButton']"));


    }
}
