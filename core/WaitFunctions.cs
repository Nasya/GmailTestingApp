using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;


namespace GmailTestingApp.core
{
    public static class WaitFunctions
    {
        private static readonly TimeSpan Timeout =
           TimeSpan.FromSeconds(30);

        public static void WaitAndClick(this By by, IWebDriver driver)
        {
            new WebDriverWait(driver, Timeout).Until(ExpectedConditions.ElementToBeClickable(by));

            driver.FindElement(by).Click();
        }

        public static void WaitAndType(this By by, IWebDriver driver, string text, int index = 0)
        {
            new WebDriverWait(driver, Timeout).Until(ExpectedConditions.ElementIsVisible(by));

            driver.FindElement(by).SendKeys(text);
        }

        public static string WaitAndRead(this By by, IWebDriver driver)
        {
            new WebDriverWait(driver, Timeout).Until(ExpectedConditions.ElementIsVisible(by));

            return driver.FindElement(by).Text;
        }

        public static void Wait(this By by, IWebDriver driver)
        {
            new WebDriverWait(driver, Timeout).Until(ExpectedConditions.ElementIsVisible(by));
        }
    }
}

