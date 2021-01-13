using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace SpecflowBDD_PhpTravel.PageObjects
{
    partial class Login
    {
        public IWebElement Email => _driver.FindElement(By.XPath("//*[@id='loginfrm']/div[3]/div[1]/label/input"));
        public IWebElement Password => _driver.FindElement(By.XPath("//*[@id='loginfrm']/div[3]/div[2]/label/input"));
        public IWebElement RememberMe => _driver.FindElement(By.XPath("//*[@id='loginfrm']/div[3]/div[3]/label"));
        public IWebElement LoginButton => _driver.FindElement(By.XPath("//*[@id='loginfrm']/button"));
        public IWebElement SignUpButton => _driver.FindElement(By.XPath("//*[@id='loginfrm'']/div[4]/div[1]/a"));
        public IWebElement ForgetPasswordButton => _driver.FindElement(By.XPath("//*[@id='loginfrm']/div[4]/div[3]/a"));

    }
}
