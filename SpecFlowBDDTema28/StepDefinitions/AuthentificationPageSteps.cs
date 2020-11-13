﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;
using SpecFlowBDDTema28.PageObjects;
using TechTalk.SpecFlow.Assist;
using SpecFlowBDDTema28.Dto;

namespace SpecFlowBDDTema28.StepDefinitions
{
    [Binding]
    public class AuthentificationPageSteps:Hooks
    {
        [Given(@"I navigate to authentication page")]
        public void GivenINavigateToAuthenticationPage()
        {
        HomePage myHomePage = new HomePage(Driver);

        
        }
        
        [When(@"I login with following credentials")]
        public void WhenILoginWithFollowingCredentials(Table table)
        {
            var user = table.CreateInstance<UserDto>();
            LoginPage loginPage = new LoginPage(Driver);
            loginPage.LoginIntoApplication(user);
        }
        
        [Then(@"I am logged in")]
        public void ThenIAmLoggedIn()
        {
            HomePage homePage = new HomePage(Driver);
            Assert.IsTrue(homePage.logOutButton.Displayed);
        }
    }
}