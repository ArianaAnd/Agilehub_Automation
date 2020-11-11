using SeleniumProjectJsonFile;
using SeleniumProjectJsonFile.PageObjects;
using Newtonsoft.Json;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using SeleniumProjectJsonFile.PageObjects;

namespace SeleniumProjectJsonFile
{
    

  

        [TestFixture]
        public class Tests : Hooks
        {

            public List<UserTest> ReadJSON()
            {
                var jsonString = File.ReadAllText("C:\\Users\\Ariana\\Desktop\\Agilehub_Automation\\SeleniumProjectJsonFile\\UsersTest.json");
                var jsonModel = JsonConvert.DeserializeObject<List<UserTest>>(jsonString);

                return jsonModel;
            }

            public void Authenticate()
            {
                Driver.Manage().Window.Maximize();
                Driver.Navigate().GoToUrl("http://demosite.casqad.org/");
                // Arrange
                HomePage homePage = new HomePage(Driver);

                // Act
                homePage.Authenticate();
            

                //Assert
                ((IJavaScriptExecutor)Driver).ExecuteScript("window.scrollTo(0, 500)"); 
                Assert.IsTrue(Driver.FindElement(By.XPath("//a[text()='Autentificare']")).Displayed);
            }

            [Test]
            public void LoginAdmin()
            {
                var jsonModel = ReadJSON();
                Authenticate();


                // Arrange
                LoginPage loginPage = new LoginPage(Driver);

                // Act
                loginPage.AddVal(jsonModel[2].Email, jsonModel[2].Password);

                //Assert
                Assert.IsTrue(Driver.FindElement(By.XPath("//a[text()='Deconectare']")).Displayed);
            }


            public void SignUp()
            {
                Driver.Manage().Window.Maximize();
                Driver.Navigate().GoToUrl("http://demosite.casqad.org/");
                // Arrange
                SignUp signUp = new SignUp(Driver);

                // Act
                signUp.ClickSignUp();
                signUp.SigUpFormFill();

                //Assert
              Assert.IsTrue(Driver.FindElement(By.XPath("/html/body/div/div/div[2]/div/button")).Displayed);
            }

            public void LogOut()
            {
                Driver.FindElement(By.XPath("//*[@id='collapsibleNavbar']/ul[2]/li[2]/a")).Click();
            }

           
            [Test]
            public void AddToCartUSERS()
            {
            Driver.Manage().Window.Maximize();
            Driver.Navigate().GoToUrl("http://demosite.casqad.org/");
      
                // Arrange

                var jsonModel = ReadJSON();
            Authenticate();
                SignUp signUp = new SignUp(Driver);
                HomePage homePage = new HomePage(Driver);
                LoginPage loginPage = new LoginPage(Driver);

            // Act
            loginPage.AddVal(jsonModel[0].Email, jsonModel[0].Password);
            homePage.viewDetails.Click();

                //Assert
            Assert.IsTrue(Driver.FindElement(By.XPath("//*[text()='Laptop ASUS X509FJ']")).Text == "Laptop ASUS X509FJ");
            }


            
            [Test]
            public void AuthenticateAndLogin()
            {
           
            Driver.Manage().Window.Maximize();
            Driver.Navigate().GoToUrl("http://demosite.casqad.org/");
            //Arrange
             Authenticate();
            SignUp signUp = new SignUp(Driver);
            HomePage homePage = new HomePage(Driver);
            LoginPage loginPage = new LoginPage(Driver);
            //Act
            SignUp();
                LoginAdmin();
            //Assert
                   Assert.IsTrue(Driver.FindElement(By.XPath("//a[text()='Autentificare']")).Displayed);

            }

            [Test]
            public void LoginLogOut()
            {
            Driver.Manage().Window.Maximize();
            Driver.Navigate().GoToUrl("http://demosite.casqad.org/");
            //Arrange
            SignUp signUp = new SignUp(Driver);
            HomePage homePage = new HomePage(Driver);
            LoginPage loginPage = new LoginPage(Driver);
            //Act
            LoginAdmin();
                LogOut();
            //Assert
              Assert.IsTrue(Driver.FindElement(By.XPath("//a[text()='Coș']")).Displayed);
            }

          
            [Test]
            public void ClickEveryMenu()
            {
                Driver.Manage().Window.Maximize();
                Driver.Navigate().GoToUrl("http://demosite.casqad.org/");

                //Arrange
                HomePage homePage = new HomePage(Driver);

                //Act
                homePage.ClickeveryMenu();

                //Assert
               Assert.IsTrue(Driver.FindElement(By.XPath("//*[@class='card-title']")).Text == "Rucsac laptop Trust Lima");
            }


            [Test]
            public void ClickAdminBtn()
            {
                LoginAdmin();

                HomePage homePage = new HomePage(Driver);
                AdminPage adminPage = new AdminPage(Driver);

                homePage.adminButton.Click();

              Assert.IsTrue(adminPage.addProductButton.Displayed);
            }


            [Test]
            public void ClickUsersBtn()
            {
                LoginAdmin();

                HomePage homePage = new HomePage(Driver);
                AdminPage adminPage = new AdminPage(Driver);

                homePage.adminButton.Click();
                adminPage.ClickUsersBtn();

               Assert.IsTrue(Driver.FindElement(By.XPath("//*[text()='Acțiuni']")).Text == "Acțiuni");
            }

        [Test]
        public void EditUsers()
        {
            var jsonModel = ReadJSON();
            LoginAdmin();

            HomePage homePage = new HomePage(Driver);
            AdminPage adminPage = new AdminPage(Driver);

            homePage.adminButton.Click();
            adminPage.EditUsers(jsonModel[1].Name, jsonModel[1].Email, jsonModel[1].Phone);

          Assert.IsTrue(Driver.FindElement(By.XPath("/html/body/div/div")).Text.Contains("The user has been successfully updated"));
        }

        }
    }
