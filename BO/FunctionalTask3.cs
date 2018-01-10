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
    public class FunctionalTask3 : FuncTestSetUp
    {
        private MainPage mainPage;

        public void init(IWebDriver driver)
        {
            LoginPage loginPage = new LoginPage(driver);
            loginPage.EmailEnter(inputEmail: "anastasiyasheptur@gmail.com");
            PasswordPage enterPass = loginPage.clickEmail();
            enterPass.PassEnter(inputPass: "fdflfrt,fyf");
            GoogleAccPage gAccPage = enterPass.clickPass();
            mainPage = gAccPage.clickGmail();
        }

        public Boolean verifyImportantTranfer()
        {
            mainPage.SelectImp();
            ImportantMessagesPage impPage = mainPage.clickImportant();
            bool temp = impPage.VerifyImportantMessage();
            return temp;
        }
    }
}
