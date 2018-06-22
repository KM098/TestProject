using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace PageObjects
{
    public class BasePageObjects : IBasePageObjects
    {
        public IWebDriver Driver { get; set; }       
        public string PageTitle { get; set; }
        public string PageUrl { get; set; }
        public WebDriverWait Wait { get; set; }
    }
}
