namespace FacebookAutomationTests.Pages
{
    internal class FriendsPage: TestBase.TestBase 
    {
        private IWebDriver driver;

        private IWebElement pageTitle => driver.FindElements(By.TagName("a")).Where(x => x.GetAttribute("aria-label") == "Friends").FirstOrDefault();

        public FriendsPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public bool isAt()
        {
            return pageTitle.Enabled;
        }
    }
}
