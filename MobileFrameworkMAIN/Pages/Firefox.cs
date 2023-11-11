using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
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
        private By searchBar => By.XPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[1]/android.widget.FrameLayout/android.webkit.WebView/android.view.View/android.view.View[1]/android.view.View/android.view.View[2]/android.view.View[1]/android.widget.EditText");
        private By searchButton => By.XPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[1]/android.widget.FrameLayout/android.webkit.WebView/android.view.View/android.view.View[1]/android.view.View/android.view.View[2]/android.widget.Button");
        private By productOne => By.XPath("(//android.view.View[@content-desc=\"The Legend of Zelda: Tears of the Kingdom - For Nintendo Switch\"])[2]/android.view.View");
        private By productHeader => By.XPath("(//android.view.View[@content-desc=\"The Legend of Zelda: Tears of the Kingdom - For Nintendo Switch\"])[1]/android.view.View");
        private By addToCartButton => By.XPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[1]/android.widget.FrameLayout/android.webkit.WebView/android.view.View/android.view.View/android.view.View/android.view.View/android.view.View/android.view.View[7]/android.view.View/android.view.View/android.view.View/android.view.View/android.view.View/android.view.View[5]/android.view.View/android.view.View/android.view.View/android.widget.Button");
        private By CartButton => By.XPath("//android.view.View[@content-desc=\"Cart\"]/android.view.View/android.view.View");
        private By CartContents => By.XPath("//android.view.View[@content-desc=\"The Legend of Zelda: Tears of the Kingdom - For Nintendo Switch\"]");
        private By removeFromCartButton => By.XPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[1]/android.widget.FrameLayout/android.webkit.WebView/android.view.View/android.view.View[2]/android.view.View/android.view.View[3]/android.view.View/android.view.View/android.view.View[2]/android.view.View/android.widget.ListView/android.view.View[1]/android.view.View/android.widget.Image");
        private By emptyCart => By.XPath("//android.view.View[@content-desc=\"Your Amazon Cart is empty\"]/android.view.View");

        //private By searchBar => By.XPath("//*[@resource-id='org.mozilla.firefox:id/nav-search-keywords']");


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














    }
}










//        //private By usernameBox => By.XPath("//*[@resource-id='org.mozilla.firefox_beta:id/user-name']");
//        //private By usernameBox => MobileBy.AccessibilityId("user-name");
//        private By usernameBox => By.XPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[1]/android.widget.FrameLayout/android.webkit.WebView/android.view.View/android.view.View[2]/android.view.View/android.view.View[1]/android.widget.EditText");

//        private By resultBox => By.XPath("//*[@resource-id='com.google.android.calculator:id/result_preview']");

//        private By passwordBox => By.XPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[1]/android.widget.FrameLayout/android.webkit.WebView/android.view.View/android.view.View[2]/android.view.View/android.view.View[2]/android.widget.EditText");

//        private By loginButton => By.XPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[1]/android.widget.FrameLayout/android.webkit.WebView/android.view.View/android.view.View[2]/android.view.View/android.widget.Button");

//        private By sideBarButton => By.XPath("\t\r\n/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[1]/android.widget.FrameLayout/android.webkit.WebView/android.view.View/android.view.View/android.view.View/android.view.View[1]/android.view.View[3]/android.view.View");

//        private By backPack => By.XPath("(//android.view.View[@content-desc=\"Sauce Labs Backpack\"])[1]/android.widget.Image");

//        //[FindsBy(How = How.CssSelector, Using = "div[class='inventory_item_name']")]
//        //private readonly IWebElement cartItem1;

//        //[FindsBy(How = How.CssSelector, Using = "button[class='btn btn_action btn_medium checkout_button']")]
//        //private readonly IWebElement checkoutButton;

//        //[FindsBy(How = How.CssSelector, Using = "input[placeholder = 'First Name']")]
//        //private readonly IWebElement firstNameBox;

//        //[FindsBy(How = How.CssSelector, Using = "input[placeholder = 'Last Name']")]
//        //private readonly IWebElement lastNameBox;

//        //[FindsBy(How = How.CssSelector, Using = "input[placeholder = 'Zip/Postal Code']")]
//        //private readonly IWebElement postcodeBox;

//        //[FindsBy(How = How.CssSelector, Using = "[class='submit-button btn btn_primary cart_button btn_action']")]
//        //private readonly IWebElement continueButton;

//        //[FindsBy(How = How.CssSelector, Using = "button[class='btn btn_action btn_medium cart_button']")]
//        //private readonly IWebElement finishButton;

//        //[FindsBy(How = How.CssSelector, Using = "div[ class = 'app_logo']")]
//        //private readonly IWebElement homeIcon;

//        //[FindsBy(How = How.CssSelector, Using = "span[class='title']")]
//        //private IWebElement productIcon;

//        //[FindsBy(How = How.CssSelector, Using = "button[id='react-burger-menu-btn']")]
//        //private readonly IWebElement sideBarButton;

//        //[FindsBy(How = How.CssSelector, Using = "a[id = 'logout_sidebar_link']")]
//        //private readonly IWebElement logoutButton;

//        //[FindsBy(How = How.CssSelector, Using = "[class='bm-item menu-item'][id='about_sidebar_link']")]
//        //private readonly IWebElement aboutButton;

//        //[FindsBy(How = How.CssSelector, Using = "[id='add-to-cart-sauce-labs-backpack']")]
//        //private readonly IWebElement backpackAddToCart;

//        //[FindsBy(How = How.CssSelector, Using = "[class='shopping_cart_link']")]
//        //private readonly IWebElement cartButton;

//        //[FindsBy(How = How.CssSelector, Using = "div[class='inventory_details_name large_size']")]
//        //private readonly IWebElement productName;




//        public void SendCredentials()
//        {
//            Thread.Sleep(50000);
//            _driver.FindElement(usernameBox).Click();

//            _driver.FindElement(usernameBox).SendKeys("standard_user");
//            _driver.FindElement(passwordBox).SendKeys("secret_sauce");
//            _driver.FindElement(loginButton).Click();
//        }



//        public void ClickSideBar()
//        {
//            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
//            _driver.FindElement(sideBarButton).Click();
//        }

//        public void ClickItemOne()
//        {
//            Thread.Sleep(30000);
//            _driver.FindElement(backPack).Click();

//        }
//    }
//}
////        public void ClickLogoutButton()
////        {
////            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
////            logoutButton.Click();
////        }

////        public void ClickAboutButton()
////        {
////            aboutButton.Click();
////        }


////        public void AddBackpackToCart()
////        {
////            backpackAddToCart.Click();
////        }

////        public void GoToCart()
////        {
////            cartButton.Click();
////        }

////        public void ClickOnProductPage()
////        {
////            _driver.FindElement(By.ClassName("AddContentBTN")).Click();
////        }


////        public void ClickProduct(string searchText)
////        {
////            string xpath = "//div[contains (@class, 'inventory_item_name')][contains (text(), '" + searchText + "')]";
////            IWebElement productButton = _driver.FindElement(By.XPath(xpath));
////            productButton.Click();
////        }

////        public string GetProductName()
////        {
////            return productName.Text;
////        }       

////        public string GetCartItem()
////        {
////            return cartItem1.Text;
////        }

////        public void ClickCheckoutButton()
////        {
////            checkoutButton.Click();
////        }

////        public void InputPersonalInformation(string firstName, string lastName, string postcode)
////        {
////            firstNameBox.SendKeys(firstName);
////            lastNameBox.SendKeys(lastName);
////            postcodeBox.SendKeys(postcode);
////            continueButton.Click();

////        }

////        public void ClickFinishButton()
////        {
////            finishButton.Click();
////        }


////    }
////}


