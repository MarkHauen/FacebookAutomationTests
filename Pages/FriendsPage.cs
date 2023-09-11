namespace FacebookAutomationTests.Pages
{
    internal class FriendsPage: TestBase.TestBase 
    {
        private IWebDriver driver;

        private IWebElement pageTitle => driver.FindElements(By.TagName("a")).FirstOrDefault(x => x.GetAttribute("aria-label") == "Friends");

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
