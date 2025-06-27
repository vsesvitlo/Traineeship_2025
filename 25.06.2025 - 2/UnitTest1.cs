using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace _25._06._2025___2
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
          // var baseDir = AppDomain.CurrentDomain.BaseDirectory; 
          // var extensionFilePath = Path.Combine(baseDir, "../../../Extensions/webextensions-selenium-example.crx");

          //  options.AddExtension(extensionFilePath);
           
           // options.AddArgument("--disable-features=DisableLoadExtensionCommandLineSwitch");
           // string userDataDir = System.IO.Path.Combine(System.IO.Path.GetTempPath(), System.IO.Path.GetRandomFileName());

            IWebDriver driver = new ChromeDriver(options);
           //driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/login");
           driver.Navigate().GoToUrl("https://www.saucedemo.com/");
           
            driver.Manage().Window.Maximize();
          //  driver.Manage().Cookies.DeleteAllCookies();
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(10);// ?
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            // driver.Navigate().GoToUrl("https://account.habr.com/");
            driver.FindElement(By.XPath("//*[@id=\"user-name\"]")).SendKeys("standard_user");
            driver.FindElement(By.XPath("//*[@id=\"password\"]")).SendKeys("secret_sauce");
            driver.FindElement(By.XPath("//*[@id=\"login-button\"]")).Click();
            driver.FindElement(By.XPath("//*[@id=\"add-to-cart-sauce-labs-backpack\"]")).Click();
            driver.FindElement(By.XPath("//*[@id=\"add-to-cart-sauce-labs-bike-light\"]")).Click();
            driver.FindElement(By.XPath("//*[@id=\"add-to-cart-sauce-labs-fleece-jacket\"]")).Click();
            driver.FindElement(By.XPath("//*[@id=\"shopping_cart_container\"]/a")).Click();
            
            // driver.FindElement(By.XPath("//*[@id=\"username\"]")).SendKeys("tomsmith");
            //driver.FindElement(By.XPath("//*[@id=\"password\"]")).SendKeys("SuperSecretPassword!");
            //driver.FindElement(By.XPath("//*[@id=\"auth-form\"]/div/div[2]/button[2]")).Click();
            //driver.FindElement(By.XPath("//*[@id=\"login\"]/button")).Click();

            //*[@id="app"]/div/header/div/div/div[2]/a[2]/button

            options.AddArgument("--start-maximized");
            options.AddExcludedArgument("disable-popup-blocking");
            //driver.Quit();

           // driver.manage().window().maximize();
          //driver.manage().deleteAllCookies();
                //driver.manage().timeouts().pageLoadTimeout(40, TimeUnit.SECONDS);
                //driver.manage().timeouts().implicitlyWait(30, TimeUnit.SECONDS);
                //driver.get("https://login.yahoo.com/account/create");
               // driver.findElement(By.xpath("//input[@id='usernamereg-firstName']")).sendKeys("Your-Name"); // Will send values to First Name tab
                //driver.findElement(By.xpath("//input[@id='usernamereg-lastName']")).sendKeys("Your-Last_name"); //xpath for last name box
               // driver.findElement(By.xpath("//input[@id='usernamereg-yid']")).sendKeys("email@yahoo.com"); //xpath for email box
               // driver.findElement(By.xpath("//input[@id='usernamereg-phone']")).sendKeys("123456789"); //xpath for phone number box
                //driver.findElement(By.xpath("//select[@id='usernamereg-month']")).click(); //xpath for usermonth box
                //driver.findElement(By.xpath("//input[@id='usernamereg-day']")).sendKeys("01"); //xpath for userday box
                //driver.findElement(By.xpath("//input[@id='usernamereg-year']")).sendKeys("1999");// xpath for user year
               // driver.findElement(By.xpath("//button[@id='reg-submit-button']")).click();// xpath for submit button
          
        
    }
    }
}
