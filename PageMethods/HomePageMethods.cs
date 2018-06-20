using OpenQA.Selenium;
using PageObjects;

namespace PageMethods
{
    public class HomePageMethods : BaseMethods
    {
        public HomePageMethods HomePage;    
        private readonly IHomePageObjects _IHomePageObjects;

        public HomePageMethods(IHomePageObjects iHomePageObjects, IWebDriver driver)
        {
            _IHomePageObjects = iHomePageObjects;
            InitializePage(driver, "Lowe's Canada: Home Improvement, Appliances, Tools, Bathroom, Kitchen", "https://www.lowes.ca");
        }

        public bool IsEmailPopUpDisplayed()=> IsDisplayed(_IHomePageObjects.EmailPopUp); 
    }
}
