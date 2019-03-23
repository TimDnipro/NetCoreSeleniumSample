using DosvitTests.Utils;
using NUnit.Framework;

namespace DosvitTests.Tests
{
    public class DosvitTest : TestBase
    {
        private LoginPage LoginPage { get; set; }

        [OneTimeSetUp]
        public void SetUpGoogle()
        {
            LoginPage = LoginPage.Open(Driver);
        }

        public DosvitTest(BrowserType browserType) : base(browserType)
        {
        }

        [Test]
        public void ShouldLoginToAdminPanel()
        {
            LoginPage.Login(Configuration.Settings["UserName"], Configuration.Settings["PassWord"]);
            Assert.That(Driver.Title, Is.EqualTo("Admin Dosvit"), "");
            Assert.That(LoginPage.IsLoggedIn, Is.True, "Logged in successfully");
        }

        [Test]
        public void ShouldValidateEmptyFields()
        {
            LoginPage.Login(string.Empty, string.Empty);
            Assert.That(LoginPage.UserName.IsValid, Is.False, "Username field is valid");
            Assert.That(LoginPage.PassWord.IsValid, Is.False, "Password field is valid");
            Assert.That(LoginPage.IsLoggedIn, Is.False, "Logged in successfully");
        }

        [Test]
        public void ShouldShowMessageForWrongPassword()
        {
            LoginPage.Login(Configuration.Settings["UserName"], "wrong_password");
            Assert.That(LoginPage.UserName.IsValid, Is.True, "Username field is valid");
            Assert.That(LoginPage.PassWord.IsValid, Is.True, "Password field is valid");
            Assert.That(LoginPage.IsLoggedIn, Is.False, "Logged in successfully");
            Assert.That(LoginPage.Message, Is.EqualTo("Введена пара логін та пароль не вірна"), "Logged in successfully");
        }
    }
}