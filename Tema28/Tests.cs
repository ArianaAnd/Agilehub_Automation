using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Tema28.PageObjects;
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
        //public void GoogleImage()
        //{
        //    Driver.Manage().Window.Maximize();


        //    Driver.Navigate().GoToUrl("http://google.com/");
        //    // Arrange
        //    Google homePage = new Google(Driver);

        //    // Act
        //    Driver.SwitchTo().Frame(0);
        //    homePage.AcceptGoogleTerms();
        //    homePage.SearchGoogleImage("paris");
        //    homePage.SelectGoogleImage();

        //    Driver.Navigate().Back();

        //    //Assert
        //    NUnit.Framework.Assert.IsTrue(!homePage.imageFrame.Displayed);

        //}


        //public void DemoqaForm()
        //{
        //    Driver.Manage().Window.Maximize();


        //    Driver.Navigate().GoToUrl("https://demoqa.com/automation-practice-form");
        //    // Arrange
        //    Demoqa formPage = new Demoqa(Driver);


        //    //Act
        //    formPage.FillDemoqaForm();

        //    //Assert

        //    NUnit.Framework.Assert.IsTrue(formPage.VerifyElementDisplayed(formPage.submitButton));
        //}    


        //public void DemoqaTextBoxTest()
        //{
        //    Driver.Manage().Window.Maximize();
        //    Driver.Navigate().GoToUrl("https://demoqa.com/text-box");

        //    //Arrange
        //    DemoqaTextBox textboxPage = new DemoqaTextBox(Driver);

        //    //Act
        //    textboxPage.FillDemoqaTextBox();

        //    //Assert
        //   NUnit.Framework.Assert.IsTrue(textboxPage.VerifyElementDisplayed(textboxPage.submit));
        //}

        //public void TeatruSicaTest()
        //{
        //    Driver.Manage().Window.Maximize();
        //    Driver.Navigate().GoToUrl("https://www.teatrulsicaalexandrescu.ro/?lang=en");

        //    //Arrange
        //    TeatruSica testPage = new TeatruSica(Driver);

        //    //Act
        //    testPage.GoToTeatruSicaPage();

        //    //Assert
        //    NUnit.Framework.Assert.IsTrue(testPage.NameShowReturn.Displayed);
        //}

        //public void Untold()
        //{
        //    Driver.Manage().Window.Maximize();
        //    Driver.Navigate().GoToUrl("https://untold.com/");

        //    //Arrange
        //    Untold untoldTest = new Untold(Driver);

        //    //Act
        //    untoldTest.GoToUntoldPage();

        //    //Assert
        //    NUnit.Framework.Assert.IsTrue(untoldTest.logo.Displayed);
        //}

        //public void LoginIntoApplication()
        //{
        //    Driver.Manage().Window.Maximize();
        //    Driver.Navigate().GoToUrl("http://demosite.casqad.org/");
        //    //Arrange
        //    LoginPage myLoginPageuser = new LoginPage(Driver);
        //    HomePage myHomePage = new HomePage(Driver);
        //    //Act
        //    myLoginPageuser.LoginIntoApplication("admin.test3@gmail.com", "password123");
        //    //Assert
        //    NUnit.Framework.Assert.IsTrue(myHomePage.DeconectareButton.Displayed);
        //}
        //[Test]
        //public void LoginIntoApplicationWithInvalidEmailAndPassword()
        //{
        //    Driver.Manage().Window.Maximize();
        //    Driver.Navigate().GoToUrl("http://demosite.casqad.org/");
        //    //Arrage
        //    HomePage myHomePage = new HomePage(Driver);
        //    myHomePage.GoToAutentificarePage();
        //    LoginPage myLoginPageadmin = new LoginPage(Driver);
        //    //Act
        //    myLoginPageadmin.LoginIntoApplication("abcedfs@gmail.com", "dasdcsdfds");
        //    //Asert
        //    NUnit.Framework.Assert.IsTrue(myLoginPageadmin.VerifyElementDisplayed(myHomePage.DeconectareButton));
        //}
        //public void AdaugaInCosUtilizator()
        //{
        //    Driver.Manage().Window.Maximize();
        //    Driver.Navigate().GoToUrl("http://demosite.casqad.org/");
            
        //    //Arrange
        //    LoginPage myLoginPage = new LoginPage(Driver);
        //    ProductPage myProductPage = new ProductPage(Driver);
        //    HomePage myHomePage = new HomePage(Driver);
        //    //Act
        //    myProductPage.AdaugaInCos();
        //    //Assert
        //    NUnit.Framework.Assert.IsTrue(myHomePage.DeconectareButton.Displayed);
        //}

        //public void Inscriere()
        //{
        //    Driver.Manage().Window.Maximize();
        //    Driver.Navigate().GoToUrl("http://demosite.casqad.org/auth/register");
        //    //Arrange
        //    InregistrationPage inscriere = new InregistrationPage(Driver);
        //    HomePage myhomepage = new HomePage(Driver);
        //    //Act
        //    inscriere.GoToInregistrationPage();
        //    myhomepage.GoToAutentificarePage();
        //    //Assert
        //    NUnit.Framework.Assert.IsTrue(myhomepage.DeconectareButton.Displayed);
        //}

        //public void ClickNavbar()
        //{
        //    Driver.Manage().Window.Maximize();
        //    Driver.Navigate().GoToUrl("http://demosite.casqad.org/");
        
        //    Navbar myNavbar = new Navbar(Driver);
        //    myNavbar.Navigare();
        //     NUnit.Framework.Assert.IsTrue(myNavbar.laptopuri.Displayed);
            
        //}

        public void ClickAdmin()
        {
            Driver.Manage().Window.Maximize();
            Driver.Navigate().GoToUrl("http://demosite.casqad.org/");
            //Arrange
            LoginPage myLoginPageuser = new LoginPage(Driver);
            HomePage myHomePage = new HomePage(Driver);
            //Act
            myLoginPageuser.LoginClickAdmin("admin.test3@gmail.com", "password123");
            //Assert
            NUnit.Framework.Assert.IsTrue(myHomePage.DeconectareButton.Displayed);
        }

    }
       



    }


