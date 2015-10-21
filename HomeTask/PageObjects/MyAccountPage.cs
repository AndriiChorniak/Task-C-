using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace HomeTask
{
    class MyAccountPage
    {
        private String urlMyAcountPage = "my-account.html";
        IWebDriver driver;
        

        public MyAccountPage(IWebDriver driver){
            this.driver = driver;
        }

        public void checkLogining() {
            
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));      
            wait.Until(ExpectedConditions.TitleContains("My Account | Canadian Tire"));
            Assert.True(driver.Url.Contains(urlMyAcountPage));
        }
    }
}
