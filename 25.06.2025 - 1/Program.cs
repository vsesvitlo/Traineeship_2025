namespace _25._06._2025___1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var options = new ChromeOptions();
            var baseDir = AppDomain.CurrentDomain.BaseDirectory;
            var extensionFilePath = Path.Combine(baseDir, "../../../Extensions/webextensions-selenium-example.crx");

            //options.AddExtension(extensionFilePath);
            options.AddArgument("--disable-features=DisableLoadExtensionCommandLineSwitch");
            string userDataDir = System.IO.Path.Combine(System.IO.Path.GetTempPath(), System.IO.Path.GetRandomFileName());
           // var options = new ChromeOptions();
            driver = new ChromeDriver(options);
            options.AddArgument("--start-maximized");
            options.AddExcludedArgument("disable-popup-blocking");
            driver.Quit();
        }
    }
    }
}
