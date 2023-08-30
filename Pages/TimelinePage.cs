namespace FacebookAutomationTests.Pages
{
    public class TimelinePage : TestBase.TestBase
    {
        private IWebDriver driver;


        private IWebElement timeLineButton => driver.FindElements(By.TagName("a")).Where(x => x.GetAttribute("aria-label") == "Michi Ramon's Timeline").FirstOrDefault();
        
        //the addToFeedInputBoxShell is located in a div which is the direct next sibling of the div containing the timeLineButton
        private IWebElement addToFeedInputBoxShell  => timeLineButton.FindElement(By.XPath("following-sibling::div"));

        // the addtoFeedInputBox is located in a span which is a distant child of addToFeedInputBoxShell
        private IWebElement addToFeedInputBox => addToFeedInputBoxShell.FindElement(By.XPath("descendant::span"));

        public TimelinePage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public bool isAt()
        {
            return timeLineButton.Enabled;
        }


   
    }
}
