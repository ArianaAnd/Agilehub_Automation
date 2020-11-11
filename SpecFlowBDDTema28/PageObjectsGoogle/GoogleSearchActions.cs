using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowBDDTema28.PageObjectsG
{
    partial class GoogleSearch
    {
        private IWebDriver _driver;
        private WebDriverWait _driverWait;

        public GoogleSearch(IWebDriver driver)
        {
            _driver = driver;
            // setam driverul sa astepte cate 3 secunde pentru fiecere element unde e folosit
            _driverWait = new WebDriverWait(_driver, TimeSpan.FromSeconds(3));

            //ignora exceptiile in momentul in care nu gaseste elementul
            _driverWait.IgnoreExceptionTypes();

        }
        public void SearchGoogleImage(string text)
        {
            //Utilizat pentru a introduce continut modificabil in campurile text si parola in timpul executarii testului
            searchTextBox.SendKeys(text);
            searchTextBox.SendKeys(Keys.Return);
        }
        public void SelectGoogleImage()
        {
            imageButton.Click();
            firstImage.Click();
        }

        public void AcceptGoogleTerms()
        {

            _driver.SwitchTo().Frame(Iframe);
            acceptButton.Click();
            _driver.SwitchTo().DefaultContent();

        }
        public void ReturnImage()
        {
            backToImages.Click();
        }

       

    }
}
