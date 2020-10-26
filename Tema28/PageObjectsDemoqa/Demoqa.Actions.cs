using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Tema28.PageObjectsDemoqa
{

    partial class Demoqa
    {
        public void FillDemoqaForm()
        {
            firstName.SendKeys("Andrisan");
            lastName.SendKeys("Ariana");
            email.SendKeys("ariana@yahoo.com");
            genderRadioButton.Click();
            mobileField.SendKeys("07235689101");
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



    }
}
