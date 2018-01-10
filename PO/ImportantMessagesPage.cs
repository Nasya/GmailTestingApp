using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace GmailTestingApp.PO
{
    class ImportantMessagesPage : core.PageObject
    {
        [FindsBy(How = How.XPath, Using = "//div[@role='main']//tr//div[@role='checkbox']/div")]
        private IList<IWebElement> impMail;


        public ImportantMessagesPage(IWebDriver driver) : base(driver) { }

        public Boolean VerifyImportantMessage()
        {
            int count = impMail.Count;
            if (count > 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
