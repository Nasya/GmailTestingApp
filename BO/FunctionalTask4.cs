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
    public class FunctionalTask4 : FuncTestSetUp
    {
        private MainPage mainPage;
        private BadEmailPage badEmailPage;
        private CreateMessagePage createMesPage;

        public void init(IWebDriver driver)
        {
            LoginPage loginPage = new LoginPage(driver);
            loginPage.EmailEnter(inputEmail: "anastasiyasheptur@gmail.com");
            PasswordPage enterPass = loginPage.clickEmail();
            enterPass.PassEnter(inputPass: "fdflfrt,fyf");
            GoogleAccPage gAccPage = enterPass.clickPass();
            mainPage = gAccPage.clickGmail();
        }

        public void createBadMessage(IWebDriver driver)
        {
            createMesPage = mainPage.clickCompose();
            createMesPage.AdressEnter(inputEmail: "jkhg" + OpenQA.Selenium.Keys.Tab + OpenQA.Selenium.Keys.Tab);
            createMesPage.SubjectEnter(inputSubject: "some subject is here");
            createMesPage.MessageEnter(inputText: "Hop hey lalalei");

            badEmailPage = createMesPage.clickSendWithBadEmail();
        }

        public Boolean assertVerifyError()
        {
            return badEmailPage.checkError();
        }
    }
}
