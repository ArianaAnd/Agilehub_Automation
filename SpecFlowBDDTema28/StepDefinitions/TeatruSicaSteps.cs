using System;
using NUnit.Framework;
using TechTalk.SpecFlow;
using SpecFlowBDDTema28.PageObjectsTeatruSica;
using TechTalk.SpecFlow.Assist;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;


namespace SpecFlowBDDTema28.StepDefinitions
{
    [Binding]
    public class TeatruSicaSteps:Hooks
    {
        [When(@"I go to the first actor page")]
        public void WhenIGoToTheFirstActorPage()
        {
            TeatruSica teatruPage = new TeatruSica(Driver);
            teatruPage.GoToTeatruSicaPage();
        }
        
        [When(@"I choose the first show")]
        public void WhenIChooseTheFirstShow()
        {
            TeatruSica teatruPage = new TeatruSica(Driver);
            Helper.ClickWithScroll(Driver, teatruPage.firstShow);
        }
        
        [Then(@"I should have the option to buy a ticket")]
        public void ThenIShouldHaveTheOptionToBuyATicket()
        {
             TeatruSica teatruPage = new TeatruSica(Driver);
             Assert.IsTrue(teatruPage.firstShow.Displayed);
        }
    }
}
