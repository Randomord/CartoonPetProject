using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObjects
{
    public class CartoonSeriesPage : BasePage
    {
        public CartoonSeriesPage(IWebDriver driver) : base (driver)
        {

        }

        private IWebElement SeasonNumbers => _driver.FindElement(By.ClassName(""));


    }
}
