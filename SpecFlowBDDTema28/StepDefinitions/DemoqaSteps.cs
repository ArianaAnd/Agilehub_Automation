using SpecFlowBDDTema28.Dto;
using SpecFlowBDDTema28.PageObjectsDemoqa;
using System;
using System.Threading;
using TechTalk.SpecFlow;
using SpecFlowBDDTema28.PageObjectsDemoqa;
using TechTalk.SpecFlow.Assist;
using SpecFlowBDDTema28.PageObjectsDemoqa;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SpecFlowBDDTema28.StepDefinitions
{
    [Binding]
    public class DemoqaSteps:Hooks
    {
        [When(@"I fill in the registration form")]
        public void WhenIFillInTheRegistrationForm(Table table)
        {
            var myUser = table.CreateInstance<DemoqaUserDto>();
            Demoqa demoqaFormPage = new Demoqa(Driver);
            demoqaFormPage.NavigateToUrl("https://demoqa.com/automation-practice-form.");
            demoqaFormPage.FillDemoqaForm();
            


        }

        [Then(@"I should see the confirmation that the form was submitted")]
        public void ThenIShouldSeeTheConfirmationThatTheFormWasSubmitted()
        {
            Demoqa demoQaFormPage = new Demoqa(Driver);
            Assert.IsTrue(demoQaFormPage.VerifyElementDisplayed(demoQaFormPage.submitButton));
        }

        [When(@"I fill in the text box form")]
        public void WhenIFillInTheTextBoxForm(Table table)
        {
            var myUser = table.CreateInstance<DemoqaUserDto>();
            DemoqaTextBox demoqaTextBoxPage = new DemoqaTextBox(Driver);
            demoqaTextBoxPage.FillDemoqaTextBox();
            
        }

        [Then(@"I should see the confirmation panel")]
        public void ThenIShouldSeeTheConfirmationPanel()
        {
            DemoqaTextBox demoqaTextBoxPage = new DemoqaTextBox(Driver);
            Assert.IsTrue(demoqaTextBoxPage.VerifyElementDisplayed(demoqaTextBoxPage.submit));
        }
    }
}
