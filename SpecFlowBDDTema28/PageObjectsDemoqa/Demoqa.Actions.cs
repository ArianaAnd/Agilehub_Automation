using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SpecFlowBDDTema28.PageObjectsDemoqa
{

    partial class Demoqa
    {
        private IWebDriver _driver;
        private WebDriverWait _driverWait;

        public Demoqa(IWebDriver driver)
        {
            _driver = driver;
            // setam driverul sa astepte cate 3 secunde pentru fiecere element unde e folosit
            _driverWait = new WebDriverWait(_driver, TimeSpan.FromSeconds(3));

            //ignora exceptiile in momentul in care nu gaseste elementul
            _driverWait.IgnoreExceptionTypes();

        }

        public object ConfirmationDialogTitle { get; internal set; }

        public void FillDemoqaForm()
        {
            firstName.SendKeys("Andrisan");
            lastName.SendKeys("Ariana");
            email.SendKeys("ariana@yahoo.com");
            genderRadioButton.Click();
            mobileField.SendKeys("0711111111");
            dateOfBirth.Click();
            dayClick.Click();

            subjectField.Click();
            subjectField.SendKeys("English");
            subjectField.SendKeys(Keys.Tab);
            currentAddressField.SendKeys("Brasov, Brasov");
            //hobbiesMusic.Click();
            //hobbiesReadin.Click();
            //hobbiesSport.Click();

            //https://www.guru99.com/checkbox-and-radio-button-webdriver.html

            var check = hobbiesCheckbox.FindElements(By.TagName("label"));

             check.Where(i => i.Text.Equals("Reading")).FirstOrDefault().Click();
            
          
            stateField.SendKeys("NCR");
            stateField.SendKeys(Keys.Tab);
            cityField.SendKeys("Delhi");
            cityField.SendKeys(Keys.Tab);
            submitButton.Click();

            Thread.Sleep(400);


        }
        public bool VerifyElementDisplayed(IWebElement element)
        {
            return element.Displayed;
        }
        public void NavigateToUrl(string pageUrl)
        {
            _driver.Navigate().GoToUrl(pageUrl);
        }



    }
}
