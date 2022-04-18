using BlueSkyCitadel.Hooks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlueSkyCitadel.PageObject
{
    class RegistrationPage
    {
        public IWebDriver driver;

        public RegistrationPage()
        {
            driver = WebHooks.driver;
        }


        private By MyAccount = By.CssSelector("#menu-item-753 > a");
        private By UsernameField = By.CssSelector("#forminator-field-text-1");
        private By PasswordField = By.CssSelector("#forminator-field-password-1");
        private By ConfirmPasswordField = By.CssSelector("#forminator-field-confirm_password-1");
        private By FullNameField = By.CssSelector("#forminator-field-name-2");
        private By EmailAddressField = By.CssSelector("#forminator-field-email-1");
        private By PhoneNumberField = By.CssSelector("#forminator-field-phone-1");
        private By SelectCountryField = By.XPath("//*[@id='address-1']/div/div/div/span/span[1]/span/span[2]/span");
        private By RegisterButton = By.XPath("//*[@id='forminator-module-1081']/div[10]/div/div/button");
        private By SuccessMessage = By.CssSelector("#forminator-module-1081 > div.forminator-response-message.forminator-show.forminator-success");







        public void ClickMyAccount()
        {
            driver.FindElement(MyAccount).Click();
        }

        public void EnterUsername(string Username)
        {
            driver.FindElement(UsernameField).SendKeys(Username);
        }

        public void EnterPassWord(string Password)
        {
            driver.FindElement(PasswordField).SendKeys(Password);

        }

        public void ConfirmPassword(string ConfirmPassword)
        {
            driver.FindElement(ConfirmPasswordField).SendKeys(ConfirmPassword);

        }

        public void EnterFullName(string FullName)
        {
            driver.FindElement(FullNameField).SendKeys(FullName);

        }

        public void EnterEmailAddress(string EmailAddress)
        {
            driver.FindElement(EmailAddressField).SendKeys(EmailAddress);

        }

        public void EnterPhoneNumber(string Number)
        {
            driver.FindElement(PhoneNumberField).SendKeys(Number);
        }

        public void SelectNigeriaFromCountry()
        {
            SelectElement select = new SelectElement(driver.FindElement(SelectCountryField));
            select.SelectByText("Nigeria");
        }

        public void ClickRegisterButton()
        {
            driver.FindElement(RegisterButton).Click();
        }

        public bool SuccessMessageIsDisplayed()
        {
            return driver.FindElement(SuccessMessage).Displayed;
        }

    }
}
