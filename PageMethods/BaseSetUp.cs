using OpenQA.Selenium;
using PageObjects;

namespace PageMethods
{
    public abstract class BaseSetUp
    {
        private readonly IBasePageObjects _iBasePageObjects;

        public BaseSetUp(IBasePageObjects iBasePageObjects)
        {
            _iBasePageObjects = iBasePageObjects;           
        }

        public bool IsDisplayed(IWebElement element) => element == null ? false : element.Displayed;

        public void GoTo(string paramUrl) => _iBasePageObjects.Driver.Navigate().GoToUrl(paramUrl);

        public virtual bool IsAt() => GetTitle() == _iBasePageObjects.PageTitle;

        public string GetTitle() => _iBasePageObjects.Wait.Until<string>((d) => { return _iBasePageObjects.Driver.Title; });
    }
}
