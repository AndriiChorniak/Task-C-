using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using NUnit.Framework;
using System.Configuration;

namespace HomeTask
{
    class LoginPage
    {
          
        private IWebDriver driver;
        private String loginInput = "//input[@placeholder='youremail@email.com']";
        private String passwordInput = "//input[@name='password' and contains(@class,'sign-in-form')]";
        private String signInButton = "//a[contains(@class,'sign-in-button')]";
        private String loginCred;
        private String passwordCred;

        public LoginPage(IWebDriver driver) {
            this.driver = driver;
            AppSettingsReader appSettingsReader = new AppSettingsReader();
            loginCred = (string)appSettingsReader.GetValue("login", typeof(string));
            passwordCred = (string)appSettingsReader.GetValue("password", typeof(string));
        }

        public void fillForm() {
            driver.FindElement(By.XPath(loginInput)).Clear();
            driver.FindElement(By.XPath(loginInput)).SendKeys(loginCred);
            driver.FindElement(By.XPath(passwordInput)).Clear();
            driver.FindElement(By.XPath(passwordInput)).SendKeys(passwordCred);
            driver.FindElement(By.XPath(signInButton)).Click();
        }
    }
}
