using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using PageObjectModel.Source.Pages;

namespace PageObjectModel.Tests
{
    public class LoginTests
    {
        private IWebDriver _driver;

        [SetUp]
        public void InitScript()
        {

            _driver = new ChromeDriver();
        }


        [Test]

        public void Login_ValidCredentials_Test()
        {
            LoginPage lp = new LoginPage(_driver);
            _driver.Navigate().GoToUrl("https://qa.source2.link/");
        }

        [TearDown]
        public void Cleanup()
        {
            _driver.Quit();
        }
    }
}