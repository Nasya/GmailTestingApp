using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using GmailTestingApp.core;

namespace GmailTestingApp.PO
{
    class MessageShowPage : core.PageObject
    {
        private readonly By deleteBtn = By.XPath("//div[@class='iH']//div[@class='ar9 T-I-J3 J-J5-Ji']");
       // private IWebElement deleteBtn;

        public MessageShowPage(IWebDriver driver) : base(driver) { }

        //public SentEmailPage TickInCheckBox(IWebDriver driver)
        //{
        //    checkBox.WaitAndClick(driver);
        //    return new SentEmailPage(driver);
        //}
        public void deleteMessage()
        {
            this.deleteBtn.WaitAndClick(driver);
        }
    }
}

