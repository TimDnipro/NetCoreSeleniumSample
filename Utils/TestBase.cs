using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace dotnet_mstest
{
    public class TestBase
    {
        protected IWebDriver Driver { get; private set; }

        [TestInitialize]
        public void SetUp() => OpenBrowser();

        [TestCleanup]
        public void TearDown()
        {
            if (Driver != null) Driver.Quit();
        }

        protected void OpenBrowser()
        {
            Driver = BrowserSetup.GetDriver("Chrome");
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }

    }
}