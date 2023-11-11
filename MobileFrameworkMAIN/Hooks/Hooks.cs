using Newtonsoft.Json.Linq;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.Enums;
using OpenQA.Selenium.Chrome;
using MobileFrameworkMAIN.Drivers;
using OpenQA.Selenium;
using BoDi;
using TechTalk.SpecFlow;

namespace MobileFrameworkMAIN.Hooks
{
    [Binding]
    public class Hooks
    {
        private readonly IObjectContainer _objectContainer;
        private AndroidDriver<AndroidElement> _driver;

        //private readonly AppiumDriver<> _appiumDriver;

        public Hooks(IObjectContainer objectContainer)
        {
            _objectContainer = objectContainer;
        }

        [BeforeScenario]
        public void BeforeScenario()
        {
            _driver = MobileDriver.InitializeAndroidDriver();
            _objectContainer.RegisterInstanceAs<IWebDriver>(_driver);
        }

        [AfterScenario]
        public void AfterScenario()
        {
            MobileDriver.CloseDriver();
        }
    }
}
