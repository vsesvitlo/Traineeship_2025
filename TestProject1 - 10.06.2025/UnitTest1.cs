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
            driver.Navigate().GoToUrl("https://www.youtube.com/");
            driver.Manage().Window.Maximize();
            driver.FindElement(By.XPath("/html/body/ytd-app/ytd-consent-bump-v2-lightbox/tp-yt-paper-dialog/div[4]/div[2]/div[6]/div[1]/ytd-button-renderer[1]/yt-button-shape/button/yt-touch-feedback-shape/div")).Click();
            driver.FindElement(By.Name("search_query")).SendKeys("SanQA Mastery");
            driver.FindElement(By.XPath("/html/body/ytd-app/div[1]/div[2]/ytd-masthead/div[4]/div[2]/yt-searchbox/button")).Click();
         

            //<div class="yt-spec-touch-feedback-shape__fill"></div>
            //System.ArgumentException : elementDictionary (Parameter 'The specified dictionary does not contain an element reference')
            // driver.Quit();
            //Assert.Pass();
        }
    }
}