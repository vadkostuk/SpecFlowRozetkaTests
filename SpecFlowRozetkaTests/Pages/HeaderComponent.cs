using OpenQA.Selenium;

namespace SpecFlowRozetkaTests.Pages
{
    class HeaderComponent
    {
        public readonly IWebDriver driver;
        public HeaderComponent (IWebDriver driver)
        {
            this.driver = driver;
        }

        private IWebElement cartButton => driver.FindElement(By.XPath("//li[@class='header-actions__item header-actions__item--cart']"),5);

        public CartComponent ClickOnCartButton()
        {
            cartButton.Click();
            return new CartComponent(driver);
        }
    }
}
