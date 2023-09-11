using FacebookAutomationTests.Pages;

namespace FacebookAutomationTests.Tests
{
    [TestClass]
    public class LoginTests: TestBase.TestBase
    {
        [TestMethod] //// Test to login to Facebook ////
        public void LoginTest()
        {
            string JIRA = jira(1234);
            var loginPage = new LoginPage(driver);
            loginPage.NavigateTo();
            loginPage.Login();
            Assert.IsTrue(new FeedPage(driver).isAt(), JIRA);
        }

        [TestMethod] //// Test navigation to friends page ////
        public void FeedToFriendsNavigation()
        {
            string JIRA = jira(1235);
            var loginPage = new LoginPage(driver);
            loginPage.NavigateTo();
            loginPage.Login();
            var feedPage = new FeedPage(driver);
            feedPage.pushFriendsPageButton();
            Assert.IsTrue(new FriendsPage(driver).isAt(), JIRA);
        }

        [TestMethod] //// Test navigation to timeline page ////
        public void FeedToTimelineNavigation()
        {
            string JIRA = jira([1236,1237]);
            var loginPage = new LoginPage(driver);
            loginPage.NavigateTo();
            loginPage.Login();
            var feedPage = new FeedPage(driver);
            feedPage.pushTimeLineButton();
            Assert.IsTrue(new TimelinePage(driver).isAt(), JIRA);
        }
    }
}