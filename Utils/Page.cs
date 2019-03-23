using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace DosvitTests
{
    abstract class Page
    {
        protected IWebDriver Driver { get; private set; }
        private WebDriverWait Wait { get; set; }

        protected Page(IWebDriver driver)
        {
            Driver = driver;
            Wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
        }

        protected abstract T VerifyOnPage<T>() where T : Page;

        protected T GetPageObject<T>() => (T)Convert.ChangeType(this, typeof(T));

        public IWebElement WaitForElement(IWebElement element)
        {
            return Wait.Until(WaitConditions.IsVisible(element));
        }
    }
}