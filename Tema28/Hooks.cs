using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow.Infrastructure;
using Tema28.TestData;

namespace Tema28
{
    public class Hooks
    {
        protected IWebDriver Driver;
        protected MyTestData TestObject;

        [SetUp]
        public void Setup()
        {
            Driver = new ChromeDriver();

            Driver.Manage().Window.Maximize();
            //vrem sa ne incarcam lista de obiecte dupa care sa cautam intre obiecte dupa care sa ne returneze primul obiect unde numele va fi egal cu numele metodei pentru testul din contextul curent
            TestObject = MyTestData.LoadValuesFromJsonFile().Find(obj=>obj.TestCaseName==TestContext.CurrentContext.Test.MethodName);




        }
        [TearDown]
        public void TearDown()
        {
            Driver.Quit();

        }
    }
}
