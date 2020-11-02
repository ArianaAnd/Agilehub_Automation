using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Tema28;
using Tema28.PageObjectsG;
using Tema28.PageObjectsCasqad;
using Tema28.PageObjectsDemoqa;
using Tema28.PageObjectsTeatruSica;
using Tema28.PageObjectsUntold;



namespace Tema28
{
    [TestFixture]
    public class Tests : Hooks
    {
        [Test]
        public void GoogleImage()
        {
            Driver.Manage().Window.Maximize();


            Driver.Navigate().GoToUrl("http://google.com/");
            // Arrange
            GoogleSearch homePage = new GoogleSearch(Driver);

            // Act
            Driver.SwitchTo().Frame(0);
            homePage.AcceptGoogleTerms();
            homePage.SearchGoogleImage("paris");
            homePage.SelectGoogleImage();

            Driver.Navigate().Back();

            //Assert
            Assert.IsTrue(!homePage.imageFrame.Displayed);

        }




        [Test]
        public void DemoqaForm()
        {
            Driver.Manage().Window.Maximize();


            Driver.Navigate().GoToUrl("https://demoqa.com/automation-practice-form");
            // Arrange
            Demoqa formPage = new Demoqa(Driver);


            //Act
            formPage.FillDemoqaForm();

            //Assert

            Assert.IsTrue(formPage.VerifyElementDisplayed(formPage.submitButton));
           
        }
        [Test]

        public void DemoqaTextBoxTest()
        {
            Driver.Manage().Window.Maximize();
            Driver.Navigate().GoToUrl("https://demoqa.com/text-box");

            //Arrange
            DemoqaTextBox textboxPage = new DemoqaTextBox(Driver);

            //Act
            textboxPage.FillDemoqaTextBox();

            //Assert
            Assert.IsTrue(textboxPage.VerifyElementDisplayed(textboxPage.submit));
        }




        [Test]
        public void TeatruSicaTest()
        {
            Driver.Manage().Window.Maximize();
            Driver.Navigate().GoToUrl("https://www.teatrulsicaalexandrescu.ro/?lang=en");

            //Arrange
            TeatruSica testPage = new TeatruSica(Driver);

            //Act
            testPage.GoToTeatruSicaPage();
          

            //Assert
            //  ((IJavaScriptExecutor)Driver).ExecuteScript("window.scrollTo(0, 500)"); 
            //Assert.IsTrue(testPage.NameShowReturn.Displayed);
            //Assert.IsTrue(Driver.FindElement(By.XPath("//*[@id='av-layout-grid-1']/div[1]/div/div[2]/div/a/span")).Displayed);
            Assert.IsTrue(testPage.cumparaBiletButton.Displayed);
        }






        [Test]
        public void Untold()
        {
            Driver.Manage().Window.Maximize();
            Driver.Navigate().GoToUrl("https://untold.com/");

            //Arrange
            Untold untoldTest = new Untold(Driver);

            //Act
            untoldTest.GoToUntoldPage();

            //Assert
           // Assert.IsTrue(Driver.FindElement(By.XPath("//*[@id='logo']/img")).Displayed);
            Assert.AreEqual("https://untold.com/", Driver.Url);
        }




    }
       



    }


