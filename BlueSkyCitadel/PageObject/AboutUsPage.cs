using BlueSkyCitadel.Hooks;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlueSkyCitadel.PageObject
{
    class AboutUsPage
    {
        public IWebDriver driver;

        public AboutUsPage()
        {
            driver = WebHooks.driver;
        }


        private By AboutUs = By.CssSelector("#menu-item-146 > a");


        public void ClickAboutUs()
        {
            driver.FindElement(AboutUs).Click();
        }

    }
}
