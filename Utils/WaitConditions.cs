using System;
using OpenQA.Selenium;

namespace dotnet_mstest
{

    class WaitConditions
    {
        public static Func<IWebDriver, IWebElement> IsClickable(IWebElement element) => driver =>
            (element != null && element.Displayed && element.Enabled) ? element : null;

        public static Func<IWebDriver, IWebElement> IsVisible(IWebElement element) => driver =>
            (element != null && element.Displayed) ? element : null;
    }
}
