using FacebookAutomationTests.Pages;

namespace FacebookAutomationTests.Tests
{
    [TestClass]
    public class LoginTests: TestBase.TestBase
    {
        [TestMethod]
        public void LoginTest()
        {
            var loginPage = new LoginPage(driver);
            loginPage.NavigateTo();
            loginPage.Login();
            Assert.IsTrue(new FeedPage(driver).isAt());
        }

        [TestMethod]
        public void FeedToFriendsNavigation()
        {
            var loginPage = new LoginPage(driver);
            loginPage.NavigateTo();
            loginPage.Login();
            var feedPage = new FeedPage(driver);
            feedPage.pushFriendsPageButton();
            Assert.IsTrue(new FriendsPage(driver).isAt());
        }

        [TestMethod]
        public void FeedToTimelineNavigation()
        {
            var loginPage = new LoginPage(driver);
            loginPage.NavigateTo();
            loginPage.Login();
            var feedPage = new FeedPage(driver);
            feedPage.pushTimeLineButton();
            Assert.IsTrue(new TimelinePage(driver).isAt());
        }
    }
}