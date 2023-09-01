using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace PageObjectModel.Source.Pages
{
    public class LoginPage
    {
        private IWebDriver _driver;

        [FindsBy(How = How., Using = "")]
        private IWebElement _email;

        [FindsBy(How = How.Id, Using = "")]
        private IWebElement _password;

        [FindsBy(How = How.Id, Using = "")]
        private IWebElement _loginButton;

        public LoginPage(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(driver, this);
        }

        public void Login_Valid_Credentials()
        {
            _email.SendKeys(email);
            _password.SendKeys(password);

            _loginButton.Click();
        }

        public void Login_InValid_Credentials()
        {
            _email.SendKeys(email);
            _password.SendKeys(password);

            _loginButton.Click();
        }

    }
}