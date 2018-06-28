using OpenQA.Selenium;

namespace PageObjects
{
    public interface IHomePageObjects
    {
        IWebElement EmailPopUp { get; }
        IWebElement EmailPopUpCloseButton { get; }
    }
}
