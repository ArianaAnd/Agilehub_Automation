using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace SpecFlowBDDTema28.StepDefinitions
{
    [Binding]
    public class HelpSteps : Hooks
    {
        [Given (@"I go to the '(.*)' website")]

        public void GivenIGoToTheWebsite(string siteUrl)
        {
            Actions actionsPage = new Actions(Driver);
            actionsPage.NavigateToUrl(siteUrl);

        }

      
    }
}
