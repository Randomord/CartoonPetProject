using OpenQA.Selenium;
using System;



namespace PageObjects
{

    public class BasePage
    {
        protected IWebDriver driver;
        public BasePage(IWebDriver webDriver)
        {

            driver = webDriver;

        }

    }
}