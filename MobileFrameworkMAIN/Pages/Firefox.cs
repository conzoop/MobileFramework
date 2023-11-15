using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.MultiTouch;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace MobileFrameworkMAIN.Pages.Firefox
{
    public class Firefox
    {

        private readonly AndroidDriver<AndroidElement> _driver;

        public Firefox(AndroidDriver<AndroidElement> driver)
        {
            _driver = driver;
        }
        private By acceptCookies => By.XPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[1]/android.widget.FrameLayout/android.webkit.WebView/android.view.View/android.view.View[1]/android.view.View[1]/android.widget.Button");
        private By homeIcon => By.XPath("//android.view.View[@content-desc=\"Amazon\"]/android.view.View");
        private By basicsLink => By.XPath("//android.view.View[@content-desc=\"Amazon Basics\"]/android.view.View");
        private By basicsPageIcon => By.XPath("//android.view.View[@content-desc=\"Amazon Basics Logo\"]/android.widget.Image");
        //private By searchBar => By.XPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[1]/android.widget.FrameLayout/android.webkit.WebView/android.view.View/android.view.View[1]/android.view.View/android.view.View[2]/android.view.View[1]/android.widget.EditText");
        private By searchButton => By.XPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[1]/android.widget.FrameLayout/android.webkit.WebView/android.view.View/android.view.View[1]/android.view.View/android.view.View[2]/android.widget.Button");
        private By productOne => By.XPath("(//android.view.View[@content-desc=\"The Legend of Zelda: Tears of the Kingdom - For Nintendo Switch\"])[2]/android.view.View");
        private By productHeader => By.XPath("(//android.view.View[@content-desc=\"The Legend of Zelda: Tears of the Kingdom - For Nintendo Switch\"])[1]/android.view.View");
        private By addToCartButton => By.XPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[1]/android.widget.FrameLayout/android.webkit.WebView/android.view.View/android.view.View/android.view.View/android.view.View/android.view.View/android.view.View[7]/android.view.View/android.view.View/android.view.View/android.view.View/android.view.View/android.view.View[5]/android.view.View/android.view.View/android.view.View/android.widget.Button");
        private By CartButton => By.XPath("//android.view.View[@content-desc=\"Cart\"]/android.view.View/android.view.View");
        private By CartContents => By.XPath("//android.view.View[@content-desc=\"The Legend of Zelda: Tears of the Kingdom - For Nintendo Switch\"]");
        private By removeFromCartButton => By.XPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[1]/android.widget.FrameLayout/android.webkit.WebView/android.view.View/android.view.View[2]/android.view.View/android.view.View[3]/android.view.View/android.view.View/android.view.View[2]/android.view.View/android.widget.ListView/android.view.View[1]/android.view.View/android.widget.Image");
        private By emptyCart => By.XPath("//android.view.View[@content-desc=\"Your Amazon Cart is empty\"]/android.view.View");

        //private By searchBar => By.XPath("//*[@resource-id='org.mozilla.firefox:id/nav-search-keywords']");
        private static By searchBar => By.ClassName("android.widget.EditText");

        public void NavigateByUrl(string url)
        {
            _driver.Navigate().GoToUrl(url);
        }

        public void ValidateHomePage()
        {
            Assert.IsNotNull(homeIcon);
        }

        public void GoToAmazonbasics()
        {
            Thread.Sleep(30000);
            _driver.FindElement(basicsLink).Click();
        }
        public void ValidateBasicsPage()
        {
            Assert.IsNotNull(basicsPageIcon);
        }
        public void SearchFor()
        {
            Thread.Sleep(50000);
            _driver.FindElement(acceptCookies).Click();
            Thread.Sleep(30000);
            //_driver.FindElement(searchBar).Click();
            _driver.FindElement(searchBar).SendKeys("Zelda Tears of the Kingdom");
            _driver.FindElement(searchButton).Click();
        }

        public void ClickItem()
        {
            Thread.Sleep(50000);
            _driver.FindElement(productOne).Click();
        }

        public void ValidateZeldaPage(string expectedProduct)
        {
            
            Thread.Sleep(40000);
            _driver.FindElement(productHeader);
            var Test = _driver.FindElement(productHeader).Text;
            string ActualResult = _driver.FindElement(productHeader).Text;
            Assert.That(ActualResult, Is.EqualTo(expectedProduct), $"The result {ActualResult} is not equal to the expected result: {expectedProduct}");
        }

        public void AddToCart()
        {
            
            _driver.FindElement(addToCartButton).Click();
        }

        public void GoToCart()
        {
            _driver.FindElement(CartButton).Click();
        }

        public void ValidateCart(string expectedProduct)
        {
            Thread.Sleep(20000);
            _driver.FindElement(CartContents);
            var Test = _driver.FindElement(CartContents).Text;
            string ActualResult = _driver.FindElement(CartContents).Text;
            Assert.That(ActualResult, Is.EqualTo(expectedProduct), $"The result {ActualResult} is not equal to the expected result: {expectedProduct}");
        }

        public void RemoveFromCart()
        {
            _driver.FindElement(removeFromCartButton).Click();
        }

        public void ValidateEmptyCart(string expectedProduct)
        {
            Thread.Sleep(20000);
            _driver.FindElement(emptyCart);
            var Test = _driver.FindElement(emptyCart).Text;
            string ActualResult = _driver.FindElement(emptyCart).Text;
            Assert.That(ActualResult, Is.EqualTo(expectedProduct), $"The result {ActualResult} is not equal to the expected result: {expectedProduct}");
        }

        public void Scroll()
        {
            var size = _driver.Manage().Window.Size;
            int startX = size.Width / 2;
            int startY = (int)(size.Height * 0.8);
            int endY = (int)(size.Height * 0.0);

            TouchAction touchAction = new TouchAction(_driver);
            touchAction.Press(startX, startY).Wait(2000).MoveTo(startX, endY).Release().Perform();

        }

    }
}


