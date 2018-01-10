using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using GmailTestingApp.core;

namespace GmailTestingApp
{
    public partial class Form1 : Form
    {
        IWebDriver driver;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            driver = new OpenQA.Selenium.Chrome.ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://accounts.google.com/");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(100);
            
            core.PageObject pages = new core.PageObject(driver);
            BO.FunctionalTask1 func = new BO.FunctionalTask1();
            func.singIn(driver);

            func.composeMessage(driver);

            func.AssertVerify();

            func.deleteSendedMessage();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            driver.Quit();
        }
    }
}
