using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Safari;

namespace SauceDemoTests.Utilities
{
    public class DriverManager
    {
        public static IWebDriver GetDriver(string browser = "chrome")
        {
            IWebDriver driver;

            switch (browser.ToLower())
            {
                case "chrome":
                    var chromeOptions = new ChromeOptions();
                    // Uncomment for headless mode
                    // chromeOptions.AddArgument("--headless");
                    driver = new ChromeDriver(chromeOptions);
                    break;
                
                case "safari":
                    driver = new SafariDriver();
                    break;
                
                default:
                    throw new ArgumentException($"Browser {browser} is not supported");
            }

            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            return driver;
        }
    }
}