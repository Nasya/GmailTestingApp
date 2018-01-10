using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace GmailTestingApp.PO 
{
    class CreateMessagePage : core.PageObject
    {
        [FindsBy(How = How.CssSelector, Using = "textarea[name *= 'to']")]
        private IWebElement inputTo;
        [FindsBy(How = How.CssSelector, Using = "input[name *= 'subjectbox']")]
        public IWebElement inputSub;
        [FindsBy(How = How.CssSelector, Using = "div[role *= 'textbox']")]
        private IWebElement inputTextMessage;
        [FindsBy(How = How.XPath, Using = "//tr[@class = 'btC']//td[@class = 'gU Up']//div[@role = 'button']")]
        private IWebElement sendBtn;

        [FindsBy(How = How.XPath, Using = "//div[@role='button'][@data-tooltip-delay='800']")]
        private IWebElement sendBtn2;

        [FindsBy(How = How.XPath, Using = "//div[@class='AD']//img[@class='Ha']")]
        private IWebElement closeButton;


        public CreateMessagePage(IWebDriver driver) : base(driver) { }

        public void AdressEnter(String inputEmail)
        {
            this.inputTo.Clear();
            this.inputTo.SendKeys(inputEmail);
        }

        public void SubjectEnter(String inputSubject)
        {
            this.inputSub.Clear();
            this.inputSub.SendKeys(inputSubject);
        }

        public void MessageEnter(String inputText)
        {
            this.inputTextMessage.Clear();
            this.inputTextMessage.SendKeys(inputText);
        }

        public MainPage clickSendMessage()
        {
            this.sendBtn.Click();
            return new MainPage(driver);
        }

        public MainPage clickClose()
        {
            this.closeButton.Click();
            return new MainPage(driver);
        }

        public BadEmailPage clickSendWithBadEmail()
        {
            this.sendBtn2.Click();
            return new BadEmailPage(driver);
        }
    }
}
