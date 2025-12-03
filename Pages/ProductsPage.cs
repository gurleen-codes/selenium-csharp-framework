using OpenQA.Selenium;
using SauceDemoTests.Utilities;

namespace SauceDemoTests.Pages
{
    public class ProductsPage : BasePage
    {
        private By pageTitle = By.ClassName("title");
        private By shoppingCartBadge = By.ClassName("shopping_cart_badge");
        private By firstProductAddToCart = By.Id("add-to-cart-sauce-labs-backpack");

        public ProductsPage(IWebDriver driver) : base(driver)
        {
        }

        public bool IsProductsPageDisplayed()
        {
            return GetText(pageTitle) == "Products";
        }

        public void AddFirstProductToCart()
        {
            Click(firstProductAddToCart);
        }

        public string GetCartItemCount()
        {
            return GetText(shoppingCartBadge);
        }
    }
}