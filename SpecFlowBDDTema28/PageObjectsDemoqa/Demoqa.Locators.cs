using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowBDDTema28.PageObjectsDemoqa
{
    partial class Demoqa
    {
       

        //Asteriscul (*) implică orice etichetă cu aceeași valoare.

        private IWebElement firstName => _driver.FindElement(By.XPath("//input[@type='text' and @placeholder='First Name' and @id='firstName']"));
        private IWebElement lastName => _driver.FindElement(By.XPath("//input[@type='text' and @placeholder='Last Name' and @id='lastName']"));
        private IWebElement email => _driver.FindElement(By.XPath("//*[@id='userEmail']"));
        private IWebElement genderRadioButton => _driver.FindElement(By.XPath("//*[@id='genterWrapper']/div[2]/div[1]/label"));
        private IWebElement mobileField => _driver.FindElement(By.XPath("//input[@placeholder='Mobile Number' and @type='text' and @id='userNumber' ]"));
        private IWebElement dateOfBirth => _driver.FindElement(By.XPath("//input[@type='text' and @id='dateOfBirthInput' and @class='form-control']"));
        private IWebElement dayClick => _driver.FindElement(By.XPath("//*[@id='dateOfBirth']/div[2]/div[2]/div/div/div[2]/div[2]/div[4]/div[5]"));
        private IWebElement subjectField => _driverWait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//input[@id='subjectsInput']")));

        private IWebElement hobbiesSport => _driver.FindElement(By.XPath("//*[@id='hobbies-checkbox-1']"));
        private IWebElement hobbiesReading=> _driver.FindElement(By.XPath("//*[@id='hobbies-checkbox-2']"));
        private IWebElement hobbiesMusic => _driver.FindElement(By.XPath("//*[@id='hobbies-checkbox-3']"));
        private IWebElement hobbiesCheckbox =>  _driver.FindElement(By.XPath("//*[@id='hobbiesWrapper']/div[2]"));
        private IWebElement pictureSelect => _driver.FindElement(By.XPath("//input[@id='uploadPicture']"));

        private IWebElement currentAddressField => _driver.FindElement(By.XPath("//*[@id='currentAddress']"));

        private IWebElement stateField => _driver.FindElement(By.XPath("//*[@id='react-select-3-input']"));
        private IWebElement cityField => _driver.FindElement(By.XPath("//*[@id='react-select-4-input']"));

        public IWebElement submitButton => _driver.FindElement(By.XPath("//*[@id='submit' and @type='submit']"));
          public IWebElement confirmationDialogTitle => _driver.FindElement(By.Id("example-modal-sizes-title-lg"));


    }
}
