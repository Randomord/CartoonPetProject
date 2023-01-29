using OpenQA.Selenium;
using PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Tests
{
    public class SmokeTest : BaseTest
    {
        [Fact]
        public void FirstTest()
        {

            MainPage main = new MainPage(driver);

        }


    }
}
