using ConnorGriffithsMobileFrameworkFinal.HomePage;
using MobileFrameworkMAIN.Pages;
using OpenQA.Selenium.Appium.Android;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MobileFrameworkMAIN.Pages.Firefox;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Firefox;
using NUnit.Framework;

namespace MobileFrameworkMAIN.StepDefinitions.FirefoxStepDefinitions
{
    [Binding]
    public class FirefoxStepDefinitions
    {
        private readonly AndroidDriver<AndroidElement> _driver;
        private Firefox firefox;


        public FirefoxStepDefinitions(AndroidDriver<AndroidElement> driver)
        {
            _driver = driver;
            firefox = new Firefox(driver);

        }



        [Given(@"I am on ""(.*)""")]
        public void GivenIAmOn(string url)
        {
            firefox.NavigateByUrl(url);

        }

        [When(@"I validate I am on the homepage")]
        [Then(@"I validate I am on the homepage")]

        public void HomePageValidation()
        {
            firefox.ValidateHomePage();
                    }

        [When(@"I go to Amazon Basics")]
        public void NavigatetoBasics()
        {
            firefox.GoToAmazonbasics();
        }

        [Then(@"I validate I am on the Amazon Basics Page")]

        public void ValidateAmazonBasics()
        {
            firefox.ValidateBasicsPage();
        }

        [When(@"I search for The Legend of Zelda Tears of the Kingdom")]
        public void SearchForZelda()
        {
            firefox.SearchFor();
        }

        [When(@"I click The Legend of Zelda Tears of the Kingdom")]
        public void ClickIntoZelda()
        {
            Thread.Sleep(30000);
            firefox.ClickItem();
        }

        [When(@"I validate I am on the Zelda Tears of the Kingdom Product Page")]
        [Then(@"I validate I am on the Zelda Tears of the Kingdom Product Page")]
        public void ValidateZeldaProductPage()
        {
            firefox.ValidateZeldaPage("The Legend of Zelda: Tears of the Kingdom - For Nintendo Switch ");
        }

        [When(@"I add the product to my cart")]
        public void AddProductTocart()
        {
            Thread.Sleep(30000);
            firefox.ScrollDown();
            firefox.AddToCart();
        }

        [When(@"I go to my cart")]
        public void GoToCart()
        {
            Thread.Sleep(10000);
            firefox.GoToCart();
        }

        [Then(@"I validate the item has been added to my basket")]

        public void ValidateAddedtoBasket()
        {
            Thread.Sleep(10000);
            firefox.AddedToBasket();
        }

        [Then(@"I validate the item has been removed from my basket")]

        public void ValidateRemovedFromBasket()
        {
            Thread.Sleep(10000);
            firefox.ValidateRemovedFromCart();
        }

        [Then(@"I validate Zelda Tears of the Kingdom is in my cart")]

        public void ValidateCart()
        {
            Thread.Sleep(10000);
            firefox.ValidateCart("The Legend of Zelda: Tears of the Kingdom - For Nintendo Switch");
        }

        [When(@"I remove an item from my cart")]
        public void RemoveFromCart()
        {
            firefox.RemoveFromCart();
        }

        [Then(@"I validate my cart is empty")]

        public void ValidateEmptyCart()
        {
            firefox.ValidateEmptyCart("Your Amazon Cart is empty ");
        }



    }
}















//        [When(@"I login as a standard user")]
//        public void GivenILoginAsAStandardUser()
//        {
//            firefox.SendCredentials();

//        }
//        [When(@"I click the first item")]
//        public void ClickFirstItem()
//        {
//            firefox.ClickItemOne();

//        }


//        //    [When(@"Validate I am on the homepage")]
//        //    [Then(@"Validate I am on the homepage")]
//        //    public void ValidateIAmOnTheHomePage()
//        //    {
//        //        firefox.GetHomeIcon();
//        //    }

//        //    [Then(@"Validate I am on the about page")]
//        //    public void ValidateIAmOnTheHAboutPage()
//        //    {
//        //        firefox.GetAboutIcon();
//        //    }

//        [When(@"I click on the sidebar")]
//        public void WhenIClickOnTheSidebar()
//        {
//            firefox.ClickSideBar();
//            Thread.Sleep(20000);
//        }

//        //    [Then(@"I logout")]
//        //    public void ThenILogout()
//        //    {
//        //        firefox.ClickSideBar();
//        //        firefox.ClickLogoutButton();
//        //    }


//        //    [When(@"I add Sauce Labs Backpack to my cart")]   //ask about this- is it possible to (.*)???
//        //    public void WhenIAddSauceLabsBackpackToMyCart()
//        //    {
//        //        firefox.AddBackpackToCart();
//        //    }

//        //    [When(@"I navigate to my cart")]
//        //    public void INavigateToCart()
//        //    {
//        //        firefox.GoToCart();
//        //    }

//        //    [Then(@"Validate the cart item name (.*) is visible")]
//        //    public void ThenValidateTheCartItem(string expectedCartItem)
//        //    {
//        //        string cartItem = firefox.GetCartItem();

//        //        Assert.AreEqual(expectedCartItem, cartItem, $"Cart Item {cartItem} does not match the expected Cart Item {expectedCartItem}.");
//        //    }

//        //    [Then(@"Validate the product name (.*) is visible")]
//        //    public void ThenValidateTheProductName(string expectedProductName)
//        //    {
//        //        string productName = firefox.GetProductName();

//        //        Assert.AreEqual(expectedProductName, productName, $"Cart Item {productName} does not match the expected Cart Item {expectedProductName}.");
//        //    }

//        //    [When(@"I click checkout")]
//        //    public void IClickCheckout()
//        //    {
//        //        firefox.ClickCheckoutButton();
//        //    }

//        //    [When(@"enter my personal information")]
//        //    public void WhenEnterMyPersonalInformation()
//        //    {
//        //        firefox.InputPersonalInformation(Default.firstName, Default.lastName, Default.postCode);
//        //    }

//        //    [Then(@"finish the order")]
//        //    public void ThenFinishTheOrder()
//        //    {
//        //        firefox.ClickFinishButton();
//        //    }
//        //}
//    }
//}


