using OpenQA.Selenium;

namespace PageObjects
{
    public class HomePageObjects : IHomePageObjects
    {
        private IWebDriver _driver;
        public HomePageObjects(IWebDriver driver)
        {
            _driver = driver;
        }

        public IWebElement EmailPopUp => _driver.FindElement(By.ClassName("signup-offer-form"));
    }
}
