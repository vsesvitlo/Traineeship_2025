using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TestProject1___10._06._2025
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.youtube.com");
            driver.Manage().Window.Maximize();
            driver.FindElement(By.Name("searcg_query")).SendKeys("SanQA Mastery");

           // driver.Quit();
            Assert.Pass();
        }
    }
}