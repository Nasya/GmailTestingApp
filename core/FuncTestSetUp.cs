using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Chrome;


namespace GmailTestingApp.core
{
   public class FuncTestSetUp
    {
        protected static IWebDriver driver;

        
        public static void setUp()
        {
            
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://accounts.google.com/");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
        }

       
        public void cleanUp()
        {
            driver.Manage().Cookies.DeleteAllCookies();
        }

        
        public static void tearDown()
        {
            driver.Close();
        }
    }
}
