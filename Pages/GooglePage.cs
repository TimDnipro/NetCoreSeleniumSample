using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;

namespace dotnet_mstest
{
    class GooglePage : Page
    {

        private IWebElement searchBar => Driver.FindElement(By.Name("q"));

        public static GooglePage At(IWebDriver driver)
        {
            driver.Url = "http://www.google.com";
            GooglePage Page = new GooglePage(driver);

            return Page.VerifyOnPage<GooglePage>();
        }

        private GooglePage(IWebDriver driver) : base(driver) { }

        protected override T VerifyOnPage<T>()
        {
            Assert.IsNotNull(this.searchBar);

            return GetPageObject<T>();
        }

        public void Search(string query)
        {
            searchBar.Clear();
            searchBar.SendKeys(query);
            searchBar.Submit();
        }

    }
}