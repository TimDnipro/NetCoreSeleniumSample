using NUnit.Framework;

namespace DosvitTests
{
    [TestFixture]
    public class DosvitTest : TestBase
    {

        LoginPage LoginPage { get; set; }

        [OneTimeSetUp]
        public void SetUpGoogle()
        {
            LoginPage = LoginPage.Open(Driver);
        }

        [Test]        
        public void ShouldLoginToAdminPanel()
        {
            LoginPage.Login(Configuration.Settings["UserName"], Configuration.Settings["PassWord"]);
            Assert.That(Driver.Title, Is.EqualTo("Admin Dosvit"));
        }

    }
}
