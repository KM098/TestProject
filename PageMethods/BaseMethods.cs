using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace PageMethods
{
    public abstract class BaseMethods
    {
        private IWebDriver _driver;
        public string PageTitle;
        public string PageUrl;
        public WebDriverWait Wait;

        public void InitializePage(IWebDriver driver, string pageTitle, string pageUrl)
        {
            _driver = driver;
            PageTitle = pageTitle;
            PageUrl = pageUrl;
            Wait = new WebDriverWait(_driver, TimeSpan.FromMinutes(2));
        }

        public bool IsDisplayed(IWebElement element) => element == null ? false : element.Displayed;

        public void GoTo(string paramUrl) => _driver.Navigate().GoToUrl(paramUrl);

        public virtual bool IsAt() => GetTitle() == PageTitle;

        public string GetTitle() => Wait.Until<string>((d) => { return _driver.Title; });
    }
}
