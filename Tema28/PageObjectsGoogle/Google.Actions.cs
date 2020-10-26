using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema28.PageObjects
{
    partial class Google
    {
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

            acceptButton.Click();

        }

    }
}
