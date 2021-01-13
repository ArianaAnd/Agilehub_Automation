using OpenQA.Selenium;
using TechTalk.SpecFlow;


namespace TestSpecSelProj
{
    [Binding]
    public class BaseSteps
    {
        private IWebDriver _driver;

        public BaseSteps(IWebDriver driver) => _driver = driver;

        [Given(@"I go to the '(.*)' website")]
        public void GivenIGoToTheWebsite(string siteUrl)
        {
            BasePage basePage = new BasePage(_driver);
            basePage.NavigateToUrl(siteUrl);
        }

    }
}
