using OpenQA.Selenium;

namespace DosvitTests.Controls
{

    public class BaseControl
    {
        public readonly IWebElement Container;

        public BaseControl(IWebElement container)
        {
            Container = container;
        }
    }
}
