using System;
using TechTalk.SpecFlow;

namespace SpecflowBDD_PhpTravel.StepDefinitions
{
    [Binding]
    public class HotelReservationSteps
    {
        [Given(@"I navigate to my home page")]
        public void GivenINavigateToMyHomePage()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I complete fields with neccessary information")]
        public void WhenICompleteFieldsWithNeccessaryInformation()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
