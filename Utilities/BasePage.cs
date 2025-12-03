using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace SauceDemoTests.Utilities
{
    public class BasePage
    {
        protected IWebDriver driver;
        protected WebDriverWait wait;

        public BasePage(IWebDriver driver)
        {
            this.driver = driver;
            this.wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        }

        // Common methods all pages can use
        protected void Click(By locator)
        {
            wait.Until(d => d.FindElement(locator)).Click();
        }

        protected void Type(By locator, string text)
        {
            var element = wait.Until(d => d.FindElement(locator));
            element.Clear();
            element.SendKeys(text);
        }

        protected string GetText(By locator)
        {
            return wait.Until(d => d.FindElement(locator)).Text;
        }

        protected bool IsDisplayed(By locator)
        {
            try
            {
                return wait.Until(d=> d.FindElement(locator)).Displayed;
            }
            catch (WebDriverTimeoutException)
            {
                return false;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }
    }
}