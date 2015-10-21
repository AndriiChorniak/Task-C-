using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Firefox;
using NUnit.Framework;

namespace HomeTask
{
    [TestClass]
    public class TestSignIn
    {
        IWebDriver driver;
        HomePage homePage;
        LoginPage loginPage;
        MyAccountPage nyAccountPage;

        private String urlHomePage = "http://www.canadiantire.ca/en.html";
 
        [TestInitialize]
        public void SetUp()
        {
            driver = new FirefoxDriver();
            driver.Navigate().GoToUrl(urlHomePage);
            driver.Manage().Window.Maximize();
            homePage = new HomePage(driver);
            loginPage = new LoginPage(driver);
            nyAccountPage = new MyAccountPage(driver);
        }

        [TestCleanup]
        public void Quit() {
            driver.Quit();
        }

        [TestMethod]
        public void SignIn() {
            homePage.clickSignIn();
            loginPage.fillForm();
            nyAccountPage.checkLogining();
        }
    }
}
