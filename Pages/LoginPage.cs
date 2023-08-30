namespace FacebookAutomationTests.Pages
{
    internal class LoginPage: TestBase.TestBase
    {

        private IWebDriver driver;

        private IWebElement emailField => driver.FindElement(By.Name("email"));
        private IWebElement passwordField => driver.FindElement(By.Name("pass"));
        private IWebElement loginButton => driver.FindElement(By.Name("login"));


        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void NavigateTo()
        {
            driver.Navigate().GoToUrl(baseURL);
        }

        public void Login()
        {
            emailField.SendKeys(email);
            passwordField.SendKeys(password);
            loginButton.Click();
        }

    }
}
