using OpenQA.Selenium;

namespace DosvitTests.Controls
{
    public class Button : BaseControl
    {
        public Button(IWebElement container) : base(container)
        {
        }

        public void Click() => Container.Click();
    }
}
