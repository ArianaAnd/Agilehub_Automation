using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Tema28.PageObjectsCasqad
{
    partial class HomePage
    {
        private IWebDriver _driver;
        private WebDriverWait _driverWait;
        public HomePage(IWebDriver driver)
        {
            
            _driver = driver;
            // setam driverul sa astepte cate 3 secunde pentru fiecere element unde e folosit
            _driverWait = new WebDriverWait(_driver, TimeSpan.FromSeconds(3));

            //ignora exceptiile in momentul in care nu gaseste elementul
            _driverWait.IgnoreExceptionTypes();

        }
        public void GoToAutentificarePage()
        {
            AutentificareButton.Click();
        }
        public void GoToVeziDetaliiPage()
        {
            VeziDetaliiButton.Click();
        }
        public void GoToCosPage()
        {
            CosButton.Click();
        }
        public void GoToAdministrarePage()
        {
            AdministratorButton.Click();
        }
        public void GoToUtilizatoriPage()
        {
            UtilizatorButton.Click();
        }
        public void GoToCategorieAdministrator(string categoryAdmin)
        {
            CategoryAdministrationButton(categoryAdmin).Click();
        }
        public void VerificarePaginaDeschisa(string pageAdmin)
        {
            Assert.IsTrue(AdaugareButton(pageAdmin).Displayed);
        }
        public void VerificarePaginaUtilizator()
        {
            Assert.IsTrue(Tabel.Displayed);
        }

    }
}




    
