using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace GmailTestingApp.PO
{
    class InboxMessagesPage : core.PageObject
    {
        public InboxMessagesPage(IWebDriver driver) : base(driver) { }
    }
}
