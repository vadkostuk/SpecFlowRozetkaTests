using OpenQA.Selenium;

namespace SpecFlowRozetkaTests.Pages
{
    class CartComponent
    {
        public readonly IWebDriver driver;
        public CartComponent(IWebDriver driver)
        {
            this.driver = driver;
        }

        private IWebElement productTitle => driver.FindElement(By.XPath("//a[@class='cart-product__title']"),5);

        public string GetProductTitleText()
        {
            return productTitle.Text;
        }
    }

}
