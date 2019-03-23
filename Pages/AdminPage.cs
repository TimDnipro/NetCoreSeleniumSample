using System.Linq;
using OpenQA.Selenium;

namespace DosvitTests
{
    class AdminPage : Page
    {
        public AdminPage(IWebDriver driver) : base(driver)
        {
        }

        protected override T VerifyOnPage<T>()
        {
            WaitForElement(Driver.FindElement(By.CssSelector("nav[class*='-Nav']")));
            return GetPageObject<T>();
        }

        public bool IsOverlayed => Driver.FindElements(By.CssSelector("div[class*='-Overlay']")).Any();
    }
}