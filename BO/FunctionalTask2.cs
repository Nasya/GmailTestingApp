using System;
using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Chrome;
using GmailTestingApp.PO;
using System.Windows.Forms;
using OpenQA.Selenium.Support.UI;
using System.Threading;
using GmailTestingApp.core;

namespace GmailTestingApp.BO
{
    public class FunctionalTask2 : FuncTestSetUp
    {
        private MainPage mainPage;
        private DraftsMessagesPage draftsPage;

        public void init(IWebDriver driver)
        {
            LoginPage loginPage = new LoginPage(driver);
            loginPage.EmailEnter(inputEmail: "anastasiyasheptur@gmail.com");
            PasswordPage enterPass = loginPage.clickEmail();
            enterPass.PassEnter(inputPass: "fdflfrt,fyf");
            GoogleAccPage gAccPage = enterPass.clickPass();
            mainPage = gAccPage.clickGmail();
        }

        public void createDraftMessage(IWebDriver driver)
        {
            CreateMessagePage createMessage = mainPage.clickCompose();
            createMessage.AdressEnter(inputEmail: "nasya2611@gmail.com" + OpenQA.Selenium.Keys.Tab + OpenQA.Selenium.Keys.Tab);
            createMessage.SubjectEnter(inputSubject: "some subject is here");
            createMessage.MessageEnter(inputText: "Hop hey lalalei");
            mainPage = createMessage.clickClose();
            draftsPage = mainPage.clickDrafts();
        }

        public Boolean AssertVerifyInDraft()
        {
            return draftsPage.VerifyMessageInDraft("some subject is here");
        }

        public void sendMessageFromDraft()
        {
            CreateMessagePage reSend = draftsPage.openDraftClick();
            reSend.clickSendMessage();
        }
    }
}
