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
    class BadEmailPage : core.PageObject
    {
        //div[@role = 'alertdialog']//span[@role = 'heading']
        [FindsBy(How = How.XPath, Using = "//div[@class='Kj-JD'][not(following-sibling::div)]//span[@role='heading']")]
        private IWebElement errorMessage;
        //div[@class='Kj-JD'][not(following-sibling::div)]//span[@role='heading']

        //div[@role = 'alertdialog']//div//button[@name = 'ok']
        [FindsBy(How = How.XPath, Using = "//div[@role = 'alertdialog']//div//button[@name = 'ok']")]
        private IWebElement okBtn;
        //div[@class='Kj-JD'][not(following-sibling::div)]//button

        public BadEmailPage(IWebDriver driver) : base(driver) { }

        public Boolean checkError()
        {
            if (errorMessage.Displayed) return true;
            else return false;
        }

        public CreateMessagePage reWriteMessage()
        {
            okBtn.Click();
            return new CreateMessagePage(driver);
        }
    }
}
