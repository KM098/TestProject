using OpenQA.Selenium;

namespace PageObjects
{
    public class SearchPageObjects : ISearchPageObjects
    {
        private IWebDriver _driver;
        public SearchPageObjects(IWebDriver driver)
        {
            _driver = driver;
        }
    }
}
