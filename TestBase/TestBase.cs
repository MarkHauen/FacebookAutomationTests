namespace FacebookAutomationTests.TestBase
{
    [TestClass]
    public class TestBase
    {

        protected IWebDriver driver;

        protected string baseURL = "http://facebook.com/";

        protected string email = "";
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
            driver.Quit();
            driver.Dispose();
            Console.WriteLine("UI TEST CLEANUP COMPLETE");
        }

   

        public string jira(int ticketNumber)
        {
            return $"\nhttps://jira.com/JiraProjectName-{ticketNumber}";
        }

        public string jira(int[] ticketNumbers)
        {
            string tickets = "";
            foreach (int ticket in ticketNumbers)
            {
                tickets += $"\nhttps://jira.com/JiraProjectName-{ticket}, ";
            }
            return tickets;
        }
















       
    }
}
