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
        //public IWebElement EmailPopUp => FindElementNull(_driver, By.ClassName("signup-offer-form"));

        //public IWebElement FindElementNull(IWebDriver driver, By by)
        //{
        //    try
        //    {
        //        return driver.FindElement(by);
        //    }
        //    catch (NoSuchElementException)
        //    {
        //        return null;
        //    }
        //}
    }
}
