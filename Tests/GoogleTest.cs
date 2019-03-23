using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace dotnet_mstest
{
    [TestFixture]
    public class GoogleTest : TestBase
    {

        GooglePage Google { get; set; }

        [OneTimeSetUp]
        public void SetUpGoogle()
        {
            Google = GooglePage.At(Driver);
        }

        [Test]        
        public void ShouldLoadGooglePage()
        {
            Assert.AreEqual("Google", Driver.Title);
        }

    }
}
