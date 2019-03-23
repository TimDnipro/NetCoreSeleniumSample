using System;
using DosvitTests.Utils;
using NUnit.Framework;
using OpenQA.Selenium;

namespace DosvitTests
{
    [Explicit]
    [TestFixture(BrowserType.Chrome)]
    [TestFixture(BrowserType.Firefox)]
    public class TestBase
    {
        private readonly BrowserType _browserType;

        public TestBase(BrowserType browserType)
        {
            _browserType = browserType;
        }

        protected IWebDriver Driver { get; private set; }

        [OneTimeSetUp]
        public void SetUp()
        {
            OpenBrowser();
        }

        [OneTimeTearDown]
        public void TearDown()
        {
            if (Driver != null) Driver.Quit();
        }

        protected void OpenBrowser()
        {
            Driver = BrowserSetup.GetDriver(_browserType.ToString());
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        }
    }
}