using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace _27._06._2025___1
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
            //Assert.Pass();
            var options = new ChromeOptions();

            IWebDriver driver = new ChromeDriver(options);
           
            driver.Navigate().GoToUrl("https://www.theclocktime.com/Kiev");

            driver.Manage().Window.Maximize();
          
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(10);// ?
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
           
            //driver.FindElement(By.XPath("//*[@id=\"user-name\"]")).SendKeys("standard_user");
            //driver.FindElement(By.XPath("//*[@id=\"password\"]")).SendKeys("secret_sauce");
           
            string time = driver.FindElement(By.XPath("//*[@id=\"timeDisplay\"]")).Text;
            
            TimeSpan comparing = TimeSpan.FromSeconds(30);

            TimeSpan now = TimeSpan.ParseExact(time, @"00\:00\:ss", null);

            int result = TimeSpan.Compare(now, comparing);
            if (result == -1)
            {
                driver.Navigate().GoToUrl("https://www.youtube.com/");
            }
            else if(result == 0){
                driver.Navigate().GoToUrl("https://learn.microsoft.com/"); 
            }
            else
            {
                driver.Navigate().GoToUrl("https://www.browserstack.com/");
            }
                options.AddArgument("--start-maximized");
            options.AddExcludedArgument("disable-popup-blocking");
            

        }
    }
}