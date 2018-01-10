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
    public class FunctionalTask1 : FuncTestSetUp
    {
        private MainPage mainPage;
        private SentEmailPage sentEmailPage;
        private MessageShowPage messageShowPage;
       
        public void singIn(IWebDriver driver)
        {
            LoginPage loginPage = new LoginPage(driver);
            loginPage.EmailEnter(inputEmail: "anastasiyasheptur@gmail.com");
            PasswordPage enterPass = loginPage.clickEmail();
            enterPass.PassEnter(inputPass: "fdflfrt,fyf");
            GoogleAccPage gAccPage = enterPass.clickPass();
            mainPage = gAccPage.clickGmail();
        }
        
        public void composeMessage(IWebDriver driver)
        {
            CreateMessagePage createMessage = mainPage.clickCompose();
            createMessage.AdressEnter(inputEmail: "nasya2611@gmail.com" + OpenQA.Selenium.Keys.Tab + OpenQA.Selenium.Keys.Tab);
            createMessage.SubjectEnter(inputSubject: "some subject is here");
            createMessage.MessageEnter(inputText: "Hop hey lalalei");
           // createMessage.clickSendMessage();
            //sentEmailPage = mainPage.clickSent();
            mainPage = createMessage.clickSendMessage();
            sentEmailPage = mainPage.clickSent();

           // sentEmailPage.TickInCheckBox(driver);


            // messageShowPage = sentEmailPage.MessageShow();
            //sentMessages(driver);


            //sentEmailPage.DeleteBtnClick(driver);
        }
        public Boolean AssertVerify()
        {
           // MessageBox.Show("Result" + " " + sentEmailPage.VerifyMessage("some subject is here"));
            return sentEmailPage.VerifyMessage("some subject is here");
        }

        public void deleteSendedMessage()
        {
            MessageShowPage messageShowPage = sentEmailPage.MessageShow();
            messageShowPage.deleteMessage();
        }

    }
}
