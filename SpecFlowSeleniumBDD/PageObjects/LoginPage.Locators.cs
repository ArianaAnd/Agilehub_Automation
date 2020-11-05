using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;

namespace SpecFlowSeleniumBDD.PageObjects
{
    partial class LoginPage
    {
        public IWebElement EmailFieldTextBox => _driver.FindElement(By.CssSelector("input[type=email]"));
        public IWebElement PasswordFieldTextBox => _driver.FindElement(By.CssSelector("input[type=password]"));
        //private IWebElement AutentificareButtonLoginPage => _driver.FindElement(By.CssSelector("button[type=submit]"));
        private IWebElement AutentificareButtonLoginPage => _driverWait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("button[type=submit]")));
        private IWebElement ErrorMessageAuthentification => _driver.FindElement(By.CssSelector(".alert-danger"));
        private IWebElement ErrorMessageAddInCart => _driver.FindElement(By.CssSelector(".alert-danger"));
        private IWebElement submitButton => _driver.FindElement(By.XPath("/html/body/div/div/div[2]/form/button"));
    }
}
