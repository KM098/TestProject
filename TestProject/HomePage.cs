using System;
using System.IO;
using System.Reflection;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using PageMethods;
using PageObjects;

namespace TestProject
{
    [TestFixture]
    public class HomePage
    {
        private IWebDriver _driver;
        public HomePageMethodsPhil Homepage;
        private IHomePageObjects _iHomePageObjects;
        private IBasePageObjects _iBasePageObjects;


        [OneTimeSetUp]
        public void TestInitialize()
        {
            _driver = InitializeDriver(); ;
            InitializePageMethods();
        }

        [Test]
        public void OpneHomePage()
        {
            Homepage.GoTo("https://www.lowes.ca");
            Assert.IsTrue(Homepage.IsAt(), "Homepage doesn't open");
            Assert.IsTrue(Homepage.IsEmailPopUpDisplayed(), "Eamil pop up doesn't open");
        }

        [Test]
        public void CloseEmailPopBox()
        {
            Homepage.GoTo("https://www.lowes.ca");
            Homepage.CloseEmailPopUp();
            Assert.IsFalse(Homepage.IsEmailPopUpDisplayed(), "Eamil pop up is not closed");
        }

        [TearDown]
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
