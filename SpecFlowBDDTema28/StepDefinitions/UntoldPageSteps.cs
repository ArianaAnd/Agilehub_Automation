using System;
using TechTalk.SpecFlow;
using SpecFlowBDDTema28.PageObjectsUntold;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SpecFlowBDDTema28.StepDefinitions
{
    [Binding]
    public class UntoldPageSteps:Hooks
    {
        [When(@"I go to home page from the navigation menu")]
        public void WhenIGoToHomePageFromTheNavigationMenu()
        {
            Untold festivalPage = new Untold(Driver);
            festivalPage.NavigateToUrl("https://wwww.untold.com/");
            festivalPage.GoToUntoldPage();
        }
        
        [Then(@"I should see the home page")]
        public void ThenIShouldSeeTheHomePage()
        {
             Assert.AreEqual("https://untold.com/", Driver.Url);
        }
    }
}
