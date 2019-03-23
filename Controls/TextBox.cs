using OpenQA.Selenium;

namespace DosvitTests.Controls
{
    public class TextBox : BaseControl
    {

        public TextBox(IWebElement container) : base(container)
        {
        }

        public string Text { get => Container.Text; set => Container.SendKeys(value); }

        public bool IsValid => Container.GetAttribute("aria-invalid").Equals("false");
    }
}
