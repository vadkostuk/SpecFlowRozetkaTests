using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.PageObjects;


namespace SpecFlowRozetkaTests.Pages
{
   public class NotebooksPage
    {
        public readonly IWebDriver driver;
        public NotebooksPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        private IWebElement itemCartButton => driver.FindElement(By.XPath("//app-buy-button[@goods_id='237822937']"),5);
        private IWebElement itemTitle => driver.FindElement(By.XPath("//div[@data-goods-id='237822937']//span[@class='goods-tile__title']"), 5);

        public void ClickItemCartButton()
        {
            itemCartButton.Click();
        }

        public string GetItemTitle()
        {
            return itemTitle.Text;
        }
    }
}
