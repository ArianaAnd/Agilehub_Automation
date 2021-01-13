using NUnit.Framework;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace TestSpecSelProj
{
    [Binding]
    public sealed class DemoQaSteps
    {
        private IWebDriver _driver;

        public DemoQaSteps(IWebDriver driver) => _driver = driver;
        [When(@"I fill in the registration form")]
        public void WhenIFillInTheRegistrationForm()
        {
            DemoQaFormPage demoQaFormPage = new DemoQaFormPage(_driver);
            demoQaFormPage.FillInForm();  //TODO use table for the data
            demoQaFormPage.SubmitForm();
        }

        [Then(@"I should see the confirmation that the form was submitted")]
        public void ThenIShouldSeeTheConfirmationThatTheFormWasSubmitted()
        {
            DemoQaFormPage demoQaFormPage = new DemoQaFormPage(_driver);
            Assert.AreEqual("Thanks for submitting the form", demoQaFormPage.ConfirmationDialogTitle.Text);
        }

        [When(@"I fill in the text box form")]
        public void WhenIFillInTheTextBoxForm()
        {
            DemoQaTextBoxPage demoQaTextBoxPage = new DemoQaTextBoxPage(_driver);
            demoQaTextBoxPage.FillInForm();  //TODO use table for the data
            demoQaTextBoxPage.SubmitForm();
        }

        [Then(@"I should see the confirmation panel")]
        public void ThenIShouldSeeTheConfirmationPanel()
        {
            DemoQaTextBoxPage demoQaTextBoxPage = new DemoQaTextBoxPage(_driver);
            Assert.IsTrue(demoQaTextBoxPage.ConfirmationPanel.Displayed);
        }


    }
}
