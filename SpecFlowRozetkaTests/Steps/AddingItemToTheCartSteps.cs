using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SpecFlowRozetkaTests.Pages;
using NUnit.Framework;

namespace SpecFlowRozetkaTests.Steps
{   
    [Binding]
    class AddingItemToTheCartSteps 
    {
        private IWebDriver driver;
        private NotebooksPage notebooksPage;

        public AddingItemToTheCartSteps(IWebDriver driver)
        {
            this.driver = driver;
        }

        [Given("I navigate to Notebooks page")]
        public void NavigateToNotebooksPage()
        {
            driver.Navigate().GoToUrl("https://rozetka.com.ua/ua/notebooks/c80004/");
            notebooksPage = new NotebooksPage(driver);
        }

        [Given("I click on the cart button")]
        public void ClickOnTheCartButton()
        {
            notebooksPage.ClickItemCartButton();
        }

        [Then("I check that notebook was added to the cart")]
        public void CheckTheCart()
        {
            CartComponent cartComponent = new HeaderComponent(driver).ClickOnCartButton();
            Assert.AreEqual(notebooksPage.GetItemTitle(), cartComponent.GetProductTitleText());
        }
    }
}
