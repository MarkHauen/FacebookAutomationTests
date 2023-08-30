namespace FacebookAutomationTests.TestBase
{
    [TestClass]
    public class TestBase
    {

        protected IWebDriver driver;

        protected string baseURL = "http://facebook.com/";

        protected string email = "ENTER USER NAME AND PASSWORD IN TestBase/TestBase.cs";
        protected string password = "";

        [TestInitialize]
        public void Setup()
        {
            Console.WriteLine("UI TESTS RUNNING");
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("--disable-notifications");
            driver = new ChromeDriver(options);
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);  
            
        }


        [TestCleanup]
        public void TestCleanup()
        {
            // Clean up resources after each test
            driver.Quit();
            driver.Dispose();
            Console.WriteLine("UI TEST CLEANUP COMPLETE");
        }
    }
}
