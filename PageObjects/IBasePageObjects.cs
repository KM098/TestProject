using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace PageObjects
{
    public interface IBasePageObjects
    {
        IWebDriver Driver { get; set; }
        string PageTitle { get; set; }
        string PageUrl { get; set; }
        WebDriverWait Wait { get; set; }
    }
}