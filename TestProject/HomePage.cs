using System;
using System.IO;
using System.Reflection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using PageMethods;
using PageObjects;
using Selenium;

namespace TestProject
{
    [TestClass]
    public class HomePage
    {
        private IWebDriver _driver;
        public HomePageMethods Homepage;
        private IHomePageObjects _iHomePageObjects;
        

        [TestInitialize]
        public void TestInitialize()
        {
            _driver = InitializeDriver(); ;
            InitializePageMethods();
        }

        [TestMethod]
        public void OpneHomePage()
        {
            Homepage.GoTo("https://www.lowes.ca");
            Assert.IsTrue(Homepage.IsAt(), "Homepage doesn't open");
            Assert.IsTrue(Homepage.IsEmailPopUpDisplayed(), "Eamil pop up doesn't open");
        }

        [TestCleanup]
        public void TestCleanup()
        {
            _driver.Quit();
        }

        public void InitializePageMethods()
        {
            _iHomePageObjects = new HomePageObjects(_driver);            
            Homepage = new HomePageMethods(_iHomePageObjects, _driver);
        }

        public IWebDriver InitializeDriver()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("--disable-extensions");
            options.AddArgument("disable-infobars");            
            _driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), options, TimeSpan.FromSeconds(120));
            _driver.Manage().Window.Maximize();
            _driver.Manage().Cookies.DeleteAllCookies();
            return _driver;
        }
    }
}
