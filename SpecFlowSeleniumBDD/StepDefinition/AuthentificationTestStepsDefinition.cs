﻿using NUnit.Framework;
using OpenQA.Selenium;
using SpecFlowSeleniumBDD.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;


namespace SpecFlowSeleniumBDD.StepDefinition
{
     //Clasa e legata de un FeatureFile

    [Binding]
    public sealed class AuthenticationStepDefinitions : Hooks
    {
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        private readonly ScenarioContext _scenarioContext;

        public AuthenticationStepDefinitions(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [Given(@"I login with valid user")]
        public void GivenILoginWithValidUser()
        {
            HomePage myHomePage = new HomePage(Driver);

        }

    }
}
