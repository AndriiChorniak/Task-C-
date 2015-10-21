using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Firefox;
using NUnit.Framework;

namespace HomeTask
{
    [TestFixture]
    public class UnitTest1
    {
        IWebDriver driver;
        HomePage homePage;
        LoginPage loginPage;
        MyAccountPage nyAccountPage;

        private String urlHomePage = "http://www.canadiantire.ca/en.html";
 
        [SetUp]
        public void SetUp()
        {
            driver = new FirefoxDriver();
            driver.Navigate().GoToUrl(urlHomePage);
            driver.Manage().Window.Maximize();
            homePage = new HomePage(driver);
            loginPage = new LoginPage(driver);
            nyAccountPage = new MyAccountPage(driver);

        }

        [TearDown]
        public void Quit() {
            driver.Quit();
        }

        [Test]
        public void SignIn() {
            homePage.clickSignIn();
            loginPage.fillForm();
            nyAccountPage.checkLogining();
        }
    }
}
