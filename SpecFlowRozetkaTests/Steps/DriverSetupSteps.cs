using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using BoDi;

namespace SpecFlowRozetkaTests.Steps
{
    [Binding]
    class DriverSetupSteps
    {
        private readonly IObjectContainer container;

        public DriverSetupSteps(IObjectContainer container)
        {
            this.container = container;
        }
       
        [BeforeScenario]
        public void CreateWebDriver()
        {
          IWebDriver driver = new ChromeDriver("C:\\Users\\vkostiu\\Downloads\\chromedriver_win32");
          container.RegisterInstanceAs(driver);  
        }

        [AfterScenario]
        public void CloseWebDriver()
        {
            IWebDriver driver = container.Resolve<IWebDriver>();
            driver.Close();
            driver.Dispose();
        }
    }
}
