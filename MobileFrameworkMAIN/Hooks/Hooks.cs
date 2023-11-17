using Newtonsoft.Json.Linq;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.Enums;
using OpenQA.Selenium.Chrome;
using MobileFrameworkMAIN.Drivers;
using OpenQA.Selenium;
using BoDi;
using TechTalk.SpecFlow;
using NUnit.Framework;
using OpenQA.Selenium.Support.Extensions;

namespace MobileFrameworkMAIN.Hooks
{
    [Binding]
    public class Hooks
    {
        private readonly IObjectContainer _objectContainer;
        private static AndroidDriver<AndroidElement> _driver;
        private readonly ScenarioContext _scenarioContext;

        public static string SolutionDir = Path.GetDirectoryName(Directory.GetParent(TestContext.CurrentContext.TestDirectory).Parent.Parent.FullName);
        public static string ScreenshotPath = Path.Combine(SolutionDir, "Screenshots");


        public Hooks(IObjectContainer objectContainer, ScenarioContext scenarioContext)
        {
            _objectContainer = objectContainer;
            _scenarioContext = scenarioContext;
        }

        [BeforeScenario]
        public void BeforeScenario()
        {
            _driver = MobileDriver.InitializeAndroidDriver();
            _objectContainer.RegisterInstanceAs<IWebDriver>(_driver);
        }

        [AfterScenario]
        public void Screenshot()
        {
            if (_scenarioContext.TestError != null)
            {
                Screenshot screenshot = _driver.GetScreenshot();
                string screenshotLocation = Path.Combine(ScreenshotPath, $"{_scenarioContext.ScenarioInfo.Title}.png"); 
                screenshot.SaveAsFile(screenshotLocation, ScreenshotImageFormat.Png);
            }
        }
        [AfterScenario]
        public void AfterScenario()
        {
            MobileDriver.CloseDriver();
        }
    }
}
