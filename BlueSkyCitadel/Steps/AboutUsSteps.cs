using BlueSkyCitadel.Hooks;
using BlueSkyCitadel.PageObject;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace BlueSkyCitadel.Steps
{
    [Binding]
    public class AboutUsSteps
    {
        public IWebDriver driver = WebHooks.driver;

        AboutUsPage _aboutusPage = new AboutUsPage();

        [Given(@"i navigate to blueskycitadel\.com")]
        public void GivenINavigateToBlueskycitadel_Com()
        {
            driver.Navigate().GoToUrl(@"https://user-68906616-work.colibriwp.com/bluesky-citadel/");
        }



        [When(@"i click on About Us button")]
        public void WhenIClickOnAboutUsButton()
        {
            _aboutusPage.ClickAboutUs();
        }
        
        [Then(@"i should be Redirected to the About Us section of the home page")]
        public void ThenIShouldBeRedirectedToTheAboutUsSectionOfTheHomePage()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
