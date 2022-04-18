using BlueSkyCitadel.Hooks;
using BlueSkyCitadel.PageObject;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace BlueSkyCitadel.Steps
{
    [Binding]
    public class RegistrationSteps
    {
        public IWebDriver driver = WebHooks.driver;

        RegistrationPage _registrationPage = new RegistrationPage();

        [Given(@"I navigate to blueskycitadel\.com")]
        public void GivenINavigateToBlueskycitadel_Com()
        {
            driver.Navigate().GoToUrl(@"https://user-68906616-work.colibriwp.com/bluesky-citadel/");
        }

        [When(@"I click on My Account")]
        public void WhenIClickOnMyAccount()
        {
            _registrationPage.ClickMyAccount();
        }

        [When(@"I enter Username ""(.*)""")]
        public void WhenIEnterUsername(string Username)
        {
            _registrationPage.EnterUsername(Username);
        }

        [When(@"I enter Password ""(.*)""")]
        public void WhenIEnterPassword(string Password)
        {
            _registrationPage.EnterPassWord(Password);
        }

        [When(@"I enter Confirm Password ""(.*)""")]
        public void WhenIEnterConfirmPassword(string ConfirmPassword)
        {
            _registrationPage.ConfirmPassword(ConfirmPassword);
        }
        
        [When(@"I enter Full Name ""(.*)""")]
        public void WhenIEnterFullName(string FullName)
        {
            _registrationPage.EnterFullName(FullName);
        }
        
        [When(@"I enter Email Address ""(.*)""")]
        public void WhenIEnterEmailAddress(string EmailAddress)
        {
            _registrationPage.EnterEmailAddress(EmailAddress);
        }
        
        [When(@"I enter Phone Number ""(.*)""")]
        public void WhenIEnterPhoneNumber(Decimal number)
        {
            _registrationPage.EnterPhoneNumber("07155622926");
        }
        
        [When(@"I select Nigeria as Country from the drop down menu")]
        public void WhenISelectNigeriaAsCountryFromTheDropDownMenu()
        {
            Thread.Sleep(5000);
            _registrationPage.SelectNigeriaFromCountry();
        }

        [When(@"I click on the Register button")]
        public void WhenIClickOnTheRegisterButton()
        {
            _registrationPage.ClickRegisterButton();
        }

        [Then(@"the successful message ""(.*)"" is displayed on the page")]
        public void ThenTheSuccessfulMessageIsDisplayedOnThePage(string p0)
        {
            Assert.IsTrue(_registrationPage.SuccessMessageIsDisplayed());
        }

    }
}
