using System;
using Demosite.Casqad.PageObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace Demosite.Casqad.StepDefinitions
{
    [Binding]
    public class LoginAndLogoutSteps:Hooks

    {

    private readonly ScenarioContext _scenarioContext;

    public LoginAndLogoutSteps(ScenarioContext scenarioContext)
    {
        _scenarioContext = scenarioContext;
    }

    [Given(@"I am logged on site with following credentials")]
    public void GivenIAmLoggedOnSiteWithFollowingCredentials(Table table)
    {
        HomePage homePage = new HomePage(Driver);
        homePage.AuthenticateStep();
        var user = table.CreateInstance<UserDto>();
        LoginPage myLoginPage = new LoginPage(Driver);
        myLoginPage.AddCredentials(user);
    }

    [When(@"I click disconnect button")]
    public void WhenIClickDisconnectButton()
    {
        Driver.FindElement(By.XPath("//*[@id='collapsibleNavbar']/ul[2]/li[2]/a")).Click();
    }

    [Then(@"I am successfully logged out")]
    public void ThenIAmSuccessfullyLoggedOut()
    {
        Assert.IsTrue(Driver.FindElement(By.XPath("//*[@id='collapsibleNavbar']/ul[2]/li[1]/a")).Displayed);
    }

    }
}
