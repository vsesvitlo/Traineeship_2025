using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Selenium_Automation
{
    internal class Program
    {
        static void Main(string[] args)
        {
        IWebDriver driver = new ChromeDriver();
    
        driver.Navigate().GoToUrl("https://www.google.com");
        driver.Manage().Window.Maximize();

            IWebElement searchbox = driver.FindElement(By.Id("input"));

            searchbox.SendKeys("This is...");

            driver.Quit();
        }
    }
}
