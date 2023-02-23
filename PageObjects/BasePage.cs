using OpenQA.Selenium;
using System;



namespace PageObjects
{

    public class BasePage
    {
        protected IWebDriver _driver;
        public BasePage(IWebDriver driver)
        {

            _driver = driver;

        }

        public void GoTo()
        {

            _driver.Navigate().GoToUrl("https://cn-fan.tv/");

        }

    }
}