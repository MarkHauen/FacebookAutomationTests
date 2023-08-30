namespace FacebookAutomationTests.Pages
{
    internal class FeedPage: TestBase.TestBase
    {

        private IWebDriver driver;

        public FeedPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        private IWebElement friendsPageButton => driver.FindElements(By.TagName("a")).Where(x => x.GetAttribute("aria-label") == "Friends").FirstOrDefault();
        private IWebElement timeLineButton => driver.FindElements(By.TagName("a")).Where(x => x.GetAttribute("aria-label") == "Michi Ramon's Timeline").FirstOrDefault();



        public void pushFriendsPageButton()
        {
            friendsPageButton.Click();
        }
        public void pushTimeLineButton()
        {
            timeLineButton.Click();
        }

        public bool isAt()
        {
            return driver.Title == "Facebook";
        }
      

    }
}
