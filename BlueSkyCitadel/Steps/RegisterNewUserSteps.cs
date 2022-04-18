 using System;
using TechTalk.SpecFlow;

namespace BlueSkyCitadel.Steps
{
    [Binding]
    public class RegisterNewUserSteps
    {

        [When(@"I click on My Account button")]
        public void WhenIClickOnMyAccountButton()
        {
            ScenarioContext.Current.Pending();
        }


        [Then(@"i should be able to view the Register With Us page")]
        public void ThenIShouldBeAbleToViewTheRegisterWithUsPage()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
