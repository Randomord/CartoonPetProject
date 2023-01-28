using OpenQA.Selenium;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CartoonPetProject.Pages
{
    class RickAndMortyMainPage
    {
        private readonly IWebDriver _driver;

        public RickAndMortyMainPage(IWebDriver driver)
        {
            _driver = driver;
        }

        #region Элементы страницы
        readonly By SeasonNumbers = By.ClassName("numberSeason");
        


        #endregion

        public void SelectCertainSeason()
        {
                  

        }

        public void SelectCertainEphisode()
        {


        }

        public void SelectNewEphisode()
        {



        }

    }
}
