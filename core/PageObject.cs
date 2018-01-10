using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.PageObjects;

namespace GmailTestingApp.core
{
    public class PageObject
    {
        protected IWebDriver driver;

        public PageObject(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, page: this);
        }
    }
}
