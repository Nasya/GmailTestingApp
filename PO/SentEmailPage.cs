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
    class SentEmailPage : core.PageObject
    {
        //[FindsBy(How = How.XPath, Using = "//tbody//tr[@class = 'zA yO']//td//div[@role = 'link']//span[@class = 'bog']")]
        //private IWebElement myMessage;
        private readonly By myMessage = By.XPath("//div[@role = 'link']//span[@class = 'bog'] [text() = 'some subject is here']");
        //[FindsBy(How = How.XPath, Using = "//td//div[@role = 'checkbox']//div[@class = 'T-Jo-auh']")]
        //    //"//span[@role = 'checkbox']//div[@role = 'presentation']")]
        //private IWebElement checkBox;


        //tr[@class = 'zA yO']//td//div[@class = 'yW']//span


        //td//div[@role = 'link']//span[@class = 'bog']
        //td//div[@role = 'link']

        //text(),'some subject is here'
        //"//span[@class = 'bog']")]
        ///span[contains(text(), 'fred')]
        ///
        //[FindsBy(How = How.XPath, Using = "//div[@role = 'button'][@act = '10']//div[@class = 'asa']")]
        //private IWebElement deleteBtn;

        [FindsBy(How = How.XPath, Using = "//div[@class='y6']/span")]
        private IList<IWebElement> subjectSended;


        public SentEmailPage(IWebDriver driver) : base(driver) {
            PageFactory.InitElements(driver, page: this);
        }

        public MessageShowPage MessageShow()
        {
            myMessage.WaitAndClick(driver);
            return new MessageShowPage(driver);
        }

        //public SentEmailPage TickInCheckBox(IWebDriver driver)
        //{
        //    checkBox.WaitAndClick(driver);
        //    return new SentEmailPage(driver);
        //}

        //public void TickInCheck()
        //{
        //    checkBox.WaitAndClick(driver);
        //  //  return new SentEmailPage(driver);
        //}
        //public SentEmailPage DeleteBtnClick(IWebDriver driver)
        //{
        //    this.deleteBtn.Click();
        //    return new SentEmailPage(driver);
        //}

        //public Boolean VerifyEmail(String subMessage)
        //{
        //    return myMessage.Text.ToString().Equals(subMessage);
        //}

        public Boolean VerifyMessage(String mySubject)
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
