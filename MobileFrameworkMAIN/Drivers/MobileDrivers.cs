using Newtonsoft.Json.Linq;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.Enums;
using OpenQA.Selenium.Chrome;



namespace MobileFrameworkMAIN.Drivers
{
    public static class MobileDriver 
    {
        private static AndroidDriver<AndroidElement> _androidDriver;
        private static string apkPath = Path.Combine(Path.GetDirectoryName(Directory.GetParent(TestContext.CurrentContext.TestDirectory).Parent.FullName), "APK"); //gets directory name etc.
        private static string screenshotPath = ("\\ROQ Framework-final\\MobileFrameworkMAIN\\MobileFrameworkMAIN\\MobileScreenshots");


        //private readonly AppiumDriver<Drivers> appiumDriver;

        public static AndroidDriver<AndroidElement> GetAndroidDriver()
        {
        //    //if (_androidDriver == null)
        //    {
        //        InitializeAndroidDriver();

        //    }
            return _androidDriver;
        }

        [BeforeScenario]
        public static AndroidDriver<AndroidElement> InitializeAndroidDriver()
        {
            _androidDriver = new AndroidDriver<AndroidElement>(new Uri("http://127.0.0.1:4723/wd/hub"), GetAppiumOptions());

            return _androidDriver;
        }
        

        private static AppiumOptions GetAppiumOptions()
        {
            var nunitCategories = TestContext.CurrentContext.Test?.Properties["Category"]; 
            var appNameTag = nunitCategories.OfType<string>().FirstOrDefault(stringToCheck => stringToCheck.Contains("App:"));

            AppiumOptions appiumOptions = new AppiumOptions();

            switch (appNameTag)
            {
                case "App:Calculator":
                    appiumOptions.AddAdditionalCapability(MobileCapabilityType.App, apkPath + "\\Calculator_8.4.1 (520193683)_Apkpure.apk");
                    break;               
                case "App:Firefox":
                    appiumOptions.AddAdditionalCapability(MobileCapabilityType.App, apkPath + "\\fenix-100.0.0-beta.1.multi.android-arm64-v8a.apk");
                    break;
                default:
                    throw new InvalidOperationException($"Test tag {appNameTag} was not valid");
            }

            appiumOptions.AddAdditionalCapability(MobileCapabilityType.PlatformName, "Android");
            appiumOptions.AddAdditionalCapability(MobileCapabilityType.DeviceName, "emulator-5554");

            return appiumOptions;
        }

        public static void CloseDriver()
        {
            if (_androidDriver != null)
            {
                _androidDriver.Quit();
                _androidDriver = null;
            }
        }
       

        [AfterScenario]
        public static void CloseDriverAfterTest()
        {
            
            _androidDriver.Quit();


          
        }
    }
}