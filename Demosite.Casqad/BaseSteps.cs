using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace Demosite.Casqad
{
    public class BaseSteps
    {
        [Given(@"I go to the '(.*)' website")]
        public void GivenIGoToTheWebsite(string siteUrl)
        {
            BasePage basePage = new BasePage();
            basePage.NavigateToUrl(siteUrl);
        }
    }
}
