using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace AutomationCore.Web.Driver
{
    public static class DriverSetUp
    {
        public static IWebDriver CreateDriver()
        {
            IWebDriver driver;
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            return driver;
        }

    }
}
