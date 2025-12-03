using NUnit.Framework;
using OpenQA.Selenium;
using SauceDemoTests.Pages;
using SauceDemoTests.Utilities;

namespace SauceDemoTests.Tests
{
    [TestFixture]
    public class LoginTests
    {
        private IWebDriver? driver;
        private LoginPage? loginPage;
        private ProductsPage? productsPage;

        [SetUp]
        public void Setup()
        {
            driver = DriverManager.GetDriver("chrome");
            driver.Navigate().GoToUrl("https://www.saucedemo.com/");
            
            loginPage = new LoginPage(driver);
            productsPage = new ProductsPage(driver);
        }

        [Test]
        public void ValidLogin_ShouldSucceed()
        {
            // Add a pause so you can see the page load
            Thread.Sleep(2000); // 2 seconds
            
            // Arrange & Act
            loginPage!.Login("standard_user", "secret_sauce");
            
            // Pause to see the login action
            Thread.Sleep(2000);

            // Assert
            Assert.That(productsPage!.IsProductsPageDisplayed(), Is.True, 
                "User should be redirected to products page after successful login");
            
            // Pause to see the products page
            Thread.Sleep(3000);
        }

        [Test]
        public void InvalidLogin_ShouldShowError()
        {
            Thread.Sleep(2000);
            
            // Arrange & Act
            loginPage!.Login("invalid_user", "wrong_password");
            
            Thread.Sleep(2000);

            // Assert
            Assert.That(loginPage.IsErrorDisplayed(), Is.True, 
                "Error message should be displayed for invalid credentials");
            
            Thread.Sleep(3000);
        }

        [TearDown]
        public void TearDown()
        {
            driver?.Quit();
            driver?.Dispose();
        }
    }
}