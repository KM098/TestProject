using OpenQA.Selenium;

namespace PageObjects
{
    public interface ITopNavigationPageObjects
    {
        IWebElement SearchBox { get; }
        IWebElement SearchSubmitButton { get; }
    }
}
