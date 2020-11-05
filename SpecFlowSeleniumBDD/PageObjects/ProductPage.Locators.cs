using OpenQA.Selenium;

namespace SpecFlowSeleniumBDD.PageObjects
{
    partial class ProductPage
    {
        private IWebElement AdaugaInCosButton => _driver.FindElement(By.CssSelector(".btn-primary"));
    }
}
