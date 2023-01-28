using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace CartoonPetProject.Pages
{
    class MainPage
    {
        private readonly IWebDriver _driver;
        
        #region Элементы страницы
        
        readonly By ImgMenuItem = By.Id("rickandmorty");
        


        #endregion 

        public MainPage(IWebDriver driver)
        {
            _driver = driver;

        }

        public void OpenCartoonSeasons()
        {
            _driver.FindElement(ImgMenuItem).Click();
            
        }
       
    }
}
