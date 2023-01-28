using Xunit;
using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support;
using System.Threading;


namespace CartoonPetProject.Steps
{
    public class Step
    {
        
        [Fact]
        public void Test1()
        {
            IWebDriver driver = new OpenQA.Selenium.Chrome.ChromeDriver();
            driver.Navigate().GoToUrl("https://cn-fan.tv/");
            Thread.Sleep(1000);

            var MainPage = new Pages.MainPage(driver);
            MainPage.OpenCartoonSeasons();

            Thread.Sleep(2000);
            var RAMPAGE = new Pages.RickAndMortyMainPage(driver);
            RAMPAGE.SelectCertainSeason();
           


            Thread.Sleep(1000);

            driver.Close();
            driver.Quit();
        }
    }
}