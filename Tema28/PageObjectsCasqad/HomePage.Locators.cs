using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema28.PageObjectsCasqad
{
    partial class HomePage
    {

        //Home Page

        public IWebElement AutentificareButton => _driver.FindElement(By.XPath("//a[text()='Autentificare']"));
        public IWebElement DeconectareButton => _driver.FindElement(By.XPath("//a[text()='Deconectare']"));
        public IWebElement VeziDetaliiButton => _driver.FindElement(By.XPath("//*[@class='btn btn-primary btn-block']"));
        // private IWebElement VeziDetaliiButton => _driver.FindElement(By.CssSelector(".btn-primary"));
        private IWebElement CosButton => _driver.FindElement(By.XPath("//a[text()='Coș']")); ////*[@id="collapsibleNavbar"]/ul[2]/li[1]/a
        public IWebElement ComandaAcumButtton => _driver.FindElement(By.XPath("//a[text()='Comandă Acum']"));
        private IWebElement AdministratorButton => _driver.FindElement(By.XPath("//a[text()='Administrare']"));
        private IWebElement UtilizatorButton => _driver.FindElement(By.XPath("//a[text()='Utilizatori']"));
        private IWebElement CategoryAdministrationButton(string category) => _driver.FindElement(By.XPath($"//a[text()='{category}']"));
        private IWebElement AdaugareButton(string category) => _driver.FindElement(By.XPath($"//a[text()='{category}']"));
        private IWebElement Tabel => _driver.FindElement(By.XPath("//th[text()='Rol']"));


    }
}
