using OpenQA.Selenium;

namespace PageObjects
{
    public class TopNavigationPageObjects : ITopNavigationPageObjects
    {
        private IWebDriver _driver;
        public TopNavigationPageObjects(IWebDriver driver)
        {
            _driver = driver;
        }

        public IWebElement SearchBox => _driver.FindElement(By.Id("tbxsearchtermNew"));
        public IWebElement SearchSubmitButton => _driver.FindElement(By.Id("inpSearchSubmit"));
    }
}
