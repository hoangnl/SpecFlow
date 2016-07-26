using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using TechTalk.SpecFlow;

namespace SpecFlowDemo.Steps
{
    [Binding]
    public class LogIn_Steps
    {
        public IWebDriver driver;
        [Given(@"User is at the Home Page")]
        public void GivenUserIsAtTheHomePage()
        {
            driver = new ChromeDriver(@"C:\Selenium\driver");
            driver.Url = "http://www.store.demoqa.com";
        }

        [Given(@"Navigate to LogIn Page")]
        public void GivenNavigateToLogInPage()
        {
            driver.FindElement(By.XPath(".//*[@id='account']/a")).Click();
        }

        [When(@"User enter UserName and Password")]
        public void WhenUserEnterUserNameAndPassword()
        {
            driver.FindElement(By.Id("log")).SendKeys("testuser_1");
            driver.FindElement(By.Id("pwd")).SendKeys("Test@123");
        }

        [When(@"Click on the LogIn button")]
        public void WhenClickOnTheLogInButton()
        {
            driver.FindElement(By.Id("login")).Click();
        }

        [When(@"User LogOut from the Application")]
        public void WhenUserLogOutFromTheApplication()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"Successful LogIN message should display")]
        public void ThenSuccessfulLogINMessageShouldDisplay()
        {
            //This Checks that if the LogOut button is displayed
            true.Equals(driver.FindElement(By.XPath(".//*[@id='account_logout']/a")).Displayed);
        }

        [Then(@"Successful LogOut message should display")]
        public void ThenSuccessfulLogOutMessageShouldDisplay()
        {
            ScenarioContext.Current.Pending();
        }
    }
}