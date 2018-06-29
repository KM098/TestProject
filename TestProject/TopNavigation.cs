using System;
using System.IO;
using System.Reflection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using PageMethods;
using PageObjects;

namespace TestProject
{
    [TestClass]
    public class TopNavigation
    {
        private IWebDriver _driver;
        public HomePageMethodsPhil Homepage;
        private IHomePageObjects _iHomePageObjects;
        private IBasePageObjects _iBasePageObjects;
        public TopNavigationPageMethods TopNavigationPage;
        private ITopNavigationPageObjects _iTopNavigationPageObjects;
        public SearchPageMethods SearchPage;
        private ISearchPageObjects _iSearchPageObjects;

        [TestInitialize]
        public void TestInitialize()
        {
            _driver = InitializeDriver(); ;
            InitializePageMethods();
        }

        [TestMethod]
        public void SearchByTerm()
        {
            Homepage.GoTo("https://www.lowes.ca");
            Homepage.CloseEmailPopUp();
            TopNavigationPage.SearchByTerm("Chandeliers");
            Assert.AreEqual("Chandeliers", SearchPage.GetH1Text(), "H1 text is not expected");
        }

        [TestCleanup]
        public void TestCleanup()
        {
            _driver.Quit();
        }

        public void InitializePageMethods()
        {
            _iHomePageObjects = new HomePageObjects(_driver);
            _iBasePageObjects = new BasePageObjects();
            _iBasePageObjects.Driver = _driver;
            _iBasePageObjects.PageTitle = "Lowe's Canada: Home Improvement, Appliances, Tools, Bathroom, Kitchen";
            _iBasePageObjects.PageUrl = "https://www.lowes.ca";
            _iBasePageObjects.Wait = new WebDriverWait(_driver, TimeSpan.FromMinutes(2));
            Homepage = new HomePageMethodsPhil(_iHomePageObjects, _iBasePageObjects);
            _iTopNavigationPageObjects = new TopNavigationPageObjects(_driver);
            TopNavigationPage = new TopNavigationPageMethods(_iTopNavigationPageObjects, _iBasePageObjects);
            _iSearchPageObjects = new SearchPageObjects(_driver);
            SearchPage = new SearchPageMethods(_iSearchPageObjects, _iBasePageObjects);
        }

        public IWebDriver InitializeDriver()
        {
            var options = new ChromeOptions();
            options.AddArgument("--headless");                     
            _driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), options, TimeSpan.FromSeconds(120));
            _driver.Manage().Window.Maximize();
            _driver.Manage().Cookies.DeleteAllCookies();
            return _driver;
        }
    }
}