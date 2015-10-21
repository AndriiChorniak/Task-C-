using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using NUnit.Framework;

namespace HomeTask
{
    class HomePage
    {
        private IWebDriver driver;
        private String sign_In = "//a[contains(@class,'sign-in')]";
        private String urlLoginPage = "https://www.canadiantire.ca/en/login.html";

        public HomePage(IWebDriver driver) {
            this.driver = driver;
        }

        public void clickSignIn() {
            driver.FindElement(By.XPath(sign_In)).Click();
            Assert.True(driver.Url.Equals(urlLoginPage));
        }
    }
}
