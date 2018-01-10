using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace GmailTestingApp.PO
{
    class GoogleAccPage : core.PageObject
    {
        [FindsBy(How = How.CssSelector, Using = "div[role='navigation'] a[href*='mail']")]
        private IWebElement gmailBtn;

        public GoogleAccPage(IWebDriver driver) : base(driver) { }

        public MainPage clickGmail()
        {
            this.gmailBtn.Click();
            return new MainPage(driver);
        }
    }
}
