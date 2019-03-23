using DosvitTests.Controls;
using NUnit.Framework;
using OpenQA.Selenium;

namespace DosvitTests
{
    class LoginPage : Page
    {
        public static LoginPage Open(IWebDriver driver)
        {
            driver.Url = $"{Configuration.Settings["BaseUrl"]}/admin";
            var Page = new LoginPage(driver);
            return Page.VerifyOnPage<LoginPage>();
        }

        private LoginPage(IWebDriver driver) : base(driver) { }

        protected override T VerifyOnPage<T>()
        {
            Assert.That(Driver.Title, Is.EqualTo("Admin Dosvit"), "Page title");
            return GetPageObject<T>();
        }

        public TextBox UserName => new TextBox(Driver.FindElement(By.CssSelector("input#login")));
        public TextBox PassWord => new TextBox(Driver.FindElement(By.CssSelector("input#password")));




        public void Login(string userName, string passWord)
        {
            UserName.Text = userName;
            PassWord.Text = passWord;
            Driver.FindElement(By.CssSelector("button[type='submit']")).Click();
            this.WaitForElement(Driver.FindElement(By.CssSelector("[class*='ApplicationWrapper']")));
        }
    }
}