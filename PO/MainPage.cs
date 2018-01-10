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
    class MainPage : core.PageObject
    {
        [FindsBy(How = How.CssSelector, Using = ".aic .z0 div")]
        private IWebElement writeMessage;

        [FindsBy(How = How.CssSelector, Using = ".aim .TO .nU a[href*='inbox']")]
        private IWebElement inboxMessages;

        //[FindsBy(How = How.XPath, Using = "//a[@href='https://mail.google.com/mail/u/0/#sent']")]
        //private IWebElement sentMessages;
        private readonly By sentMessages = By.XPath("//a[@href='https://mail.google.com/mail/u/0/#sent']");

        //.aim .TO .nU a[href*='sent']
        // [FindsBy(How = How.CssSelector, Using = ".aim .TO .nU a[href*='drafts']")]
        //private IWebElement draftsMessages;
        private readonly By draftsMessages = By.XPath("//a[@href = 'https://mail.google.com/mail/u/0/#drafts']");
        //[FindsBy(How = How.CssSelector, Using = ".aim .TO .nU a[href*='imp']")]
        //private IWebElement importantMessages;
        private readonly By importantMessages = By.CssSelector(".aim .TO .nU a[href*='imp']");

        [FindsBy(How = How.CssSelector, Using = ".wT span[role = 'button']")]
        private IWebElement moreBtn;

        [FindsBy(How = How.XPath, Using = "//div[@role='main']//tr//div[@role='img']")]
        private IList<IWebElement> tickImportant;

        public MainPage(IWebDriver driver) : base(driver) { }

        public CreateMessagePage clickCompose()
        {
            this.writeMessage.Click();
            return new CreateMessagePage(driver);
        }

        public SentEmailPage clickSent()
        {
            sentMessages.WaitAndClick(driver);
            return new SentEmailPage(driver);
        }

        public DraftsMessagesPage clickDrafts()
        {
            moreBtn.Click();
            draftsMessages.WaitAndClick(driver);
            return new DraftsMessagesPage(driver);
        }

        public InboxMessagesPage clickInbox()
        {
            this.inboxMessages.Click();
            return new InboxMessagesPage(driver);
        }

        public ImportantMessagesPage clickImportant()
        {
            importantMessages.WaitAndClick(driver);
            return new ImportantMessagesPage(driver);
        }

        public void SelectImp()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60);
            tickImportant[0].Click();
            tickImportant[1].Click();
            tickImportant[2].Click();
        }
    }
}
