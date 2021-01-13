using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace SpecflowBDD_PhpTravel.PageObjects
{
    partial class SignUp
    {
        public IWebElement FirstName => _driver.FindElement(By.XPath("//*[@id='headersignupform']/div[3]/div[1]/div/label/input"));
        public IWebElement LastName => _driver.FindElement(By.XPath("//*[@id='headersignupform']/div[3]/div[2]/div/label/input"));
        public IWebElement MobileNumber => _driver.FindElement(By.XPath("//*[@id='headersignupform']/div[4]/label/input"));
        public IWebElement Email => _driver.FindElement(By.XPath("//*[@id='headersignupform']/div[5]/label/input"));
        public IWebElement Password => _driver.FindElement(By.XPath("//*[@id='headersignupform']/div[6]/label/input"));
        public IWebElement ConfirmPassword => _driver.FindElement(By.XPath("//*[@id='headersignupform']/div[7]/label/input"));
        public IWebElement SignUpButton => _driver.FindElement(By.XPath("//*[@id='headersignupform']/div[8]/button"));
    }
}
