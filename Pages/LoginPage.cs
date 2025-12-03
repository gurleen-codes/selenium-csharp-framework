using OpenQA.Selenium;
using SauceDemoTests.Utilities;

namespace SauceDemoTests.Pages
{
    public class LoginPage : BasePage
    {
        // Locators (similar to how you'd do in Java)
        private By usernameField = By.Id("user-name");
        private By passwordField = By.Id("password");
        private By loginButton = By.Id("login-button");
        private By errorMessage = By.CssSelector("h3[data-test='error']");

        public LoginPage(IWebDriver driver) : base(driver)
        {
        }

        // Page actions
        public void EnterUsername(string username)
        {
            Type(usernameField, username);
        }

        public void EnterPassword(string password)
        {
            Type(passwordField, password);
        }

        public void ClickLogin()
        {
            Click(loginButton);
        }

        // Combined method for convenience
        public void Login(string username, string password)
        {
            EnterUsername(username);
            EnterPassword(password);
            ClickLogin();
        }

        public string GetErrorMessage()
        {
            return GetText(errorMessage);
        }

        public bool IsErrorDisplayed()
        {
            return IsDisplayed(errorMessage);
        }
    }
}