using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support;
using GmailTestingApp.core;
using System.IO;
using OpenQA.Selenium.Support.PageObjects;
using GmailTestingApp.core;

namespace GmailTestingApp.PO
{
    class LoginPage : PageObject
    {
        [FindsBy(How = How.XPath, Using = "//*[@id=\"identifierId\"]")]
        private IWebElement email;
        //[FindsBy(How = How.XPath, Using = "//*[@id=\"identifierNext\"]/content/span")]
        //private IWebElement submitEmailBtn;
        private readonly By submitEmailBtn = By.XPath("//*[@id=\"identifierNext\"]/content/span");

        public LoginPage(IWebDriver driver) : base (driver) { }

        public void EmailEnter(String inputEmail)
        {
            this.email.Clear();
            this.email.SendKeys(inputEmail);
        }

        public PasswordPage clickEmail()
        {
            submitEmailBtn.WaitAndClick(driver);
            return new PasswordPage(driver);
            
        }
    }
}
