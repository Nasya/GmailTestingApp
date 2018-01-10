using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.IO;
using System.Windows.Forms;
using System.Reflection;
using GmailTestingApp.core;

namespace GmailTestingApp.PO
{
    class PasswordPage : core.PageObject
    {
        //[FindsBy(How = How.XPath, Using = "//*[@id='password']//input")]
        //private IWebElement enterPass;

        private readonly By enterPass = By.XPath("//*[@id='password']//input");

        [FindsBy(How = How.XPath, Using = "//*[@id=\"passwordNext\"]/content/span")]
        private IWebElement submitPassBtn;

        public PasswordPage(IWebDriver driver) : base(driver) { }


        public void PassEnter(String inputPass)
        {
           // this.enterPass.Wait(driver);
            this.enterPass.WaitAndType(driver, inputPass);
        }

        public GoogleAccPage clickPass()
        {
            this.submitPassBtn.Click();
            return new GoogleAccPage(driver);
        }
    }
}
