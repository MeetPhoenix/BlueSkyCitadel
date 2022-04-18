using BlueSkyCitadel.Hooks;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlueSkyCitadel.PageObject
{
    class RegisterNewUserPage
    {
        public IWebDriver driver;

        public RegisterNewUserPage()
        {
            driver = WebHooks.driver;
        }


    }
}
