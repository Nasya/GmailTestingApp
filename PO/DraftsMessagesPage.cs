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
    class DraftsMessagesPage : core.PageObject
    {
        private readonly By draftMessage = By.XPath("//div[@role = 'link']//span[@class = 'bog'] [text() = 'some subject is here']");

        [FindsBy(How = How.XPath, Using = "//div[@class='y6']/span")]
        private IList<IWebElement> subjectSended;

        public DraftsMessagesPage(IWebDriver driver) : base(driver) { }

        public CreateMessagePage openDraftClick()
        {
            draftMessage.WaitAndClick(driver);
            return new CreateMessagePage(driver);
        }


        public Boolean VerifyMessageInDraft(String mySubject)
        {
            for (int i = 0; i < subjectSended.Count; i++)
            {
                if (subjectSended[i].Text.Equals(mySubject))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
