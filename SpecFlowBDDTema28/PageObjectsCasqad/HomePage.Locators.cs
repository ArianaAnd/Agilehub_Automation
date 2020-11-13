using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowBDDTema28.PageObjects
{
    partial class HomePage
    {
        private IWebElement authenticationButton => _driver.FindElement(By.XPath("/html/body/div/div/div[2]/h3"));
        private IWebElement addToCartButton => _driver.FindElement(By.XPath("/html/body/div/div[1]/div[2]/div/div[2]/a"));

        internal void GoToAuthentificatePage()
        {
            throw new NotImplementedException();
        }

        public IWebElement signUpBuutton => _driver.FindElement(By.XPath("//a[text()='Înscriere']"));
         public IWebElement logOutButton => _driver.FindElement(By.XPath("//a[text()='Deconectare']"));
        public IWebElement orderNowButton => _driver.FindElement(By.XPath("/html/body/div/div[1]/div[2]/table/tbody/tr[3]/th[4]/a"));
        public IWebElement laptopsButton => _driver.FindElement(By.XPath("//*[@id='collapsibleNavbar']/ul[1]/li[1]/a"));

        public IWebElement photoButton => _driver.FindElement(By.XPath("//*[@id='collapsibleNavbar']/ul[1]/li[3]/a"));
        public IWebElement booksButton => _driver.FindElement(By.XPath("//*[@id='collapsibleNavbar']/ul[1]/li[4]/a"));
 
        public IWebElement adminButton => _driver.FindElement(By.XPath("//*[@id='collapsibleNavbar']/ul[2]/li[3]/a"));
               public IWebElement accesoryButton => _driver.FindElement(By.XPath("//*[@id='collapsibleNavbar']/ul[1]/li[5]/a"));
                public IWebElement phonesButton => _driver.FindElement(By.XPath("//*[@id='collapsibleNavbar']/ul[1]/li[2]/a"));
        public IWebElement viewDetails => _driver.FindElement(By.XPath("//a[@class='btn btn-primary btn-block']"));
    }
}
