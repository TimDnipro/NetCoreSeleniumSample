using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace dotnet_mstest
{
    public class TestBase
    {
        protected IWebDriver Driver { get; private set; }

        [OneTimeSetUp]
        public void SetUp() => OpenBrowser();

        [OneTimeTearDown]
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