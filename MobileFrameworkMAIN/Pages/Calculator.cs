using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using System.Threading;
using MobileFrameworkMAIN.Drivers;
using ConnorGriffithsMobileFrameworkFinal.Calculator;
using NUnit.Framework;
using OpenQA.Selenium.Appium.Android;


namespace ConnorGriffithsMobileFrameworkFinal.Calculator
{
    public class CalculatorPage
    {
        private readonly AndroidDriver<AndroidElement> _driver;

        #region Elements
        private By nineButton => By.XPath("//android.widget.ImageButton[@content-desc=\"9\"]");
        private By fourButton => By.XPath("//android.widget.ImageButton[@content-desc=\"4\"]");
        private By eightButton => By.XPath("//android.widget.ImageButton[@content-desc=\"8\"]");
        private By twoButton => By.XPath("//android.widget.ImageButton[@content-desc=\"2\"]");
        private By multiplyButton => By.XPath("//android.widget.ImageButton[@content-desc='multiply']");
        private By divideButton => By.XPath("//android.widget.ImageButton[@content-desc='divide']");
        private By additionButton => By.XPath("//android.widget.ImageButton[@content-desc='plus']");
        private By subtractButton => By.XPath("//android.widget.ImageButton[@content-desc='minus']");
        private By equalsButton => By.XPath("//android.widget.ImageButton[@content-desc='equals']");
        private By powerButton => By.XPath("//android.widget.ImageButton[@content-desc='power']");
        private By resultBox => By.XPath("//*[@resource-id='com.google.android.calculator:id/result_preview']");
        #endregion 

        public CalculatorPage(AndroidDriver<AndroidElement> driver)
        {
            _driver = driver;
        }

        public void ClickNumberNine()
        {
            _driver.FindElement(nineButton).Click();

        }
        public void ClickNumberFour()
        {
            _driver.FindElement(fourButton).Click();

        }
        public void ClickNumberEight()
        {
            _driver.FindElement(eightButton).Click();

        }
        public void ClickNumberTwo()
        {
            _driver.FindElement(twoButton).Click();

        }

        public void ClickMultiply()
        {
            _driver.FindElement(multiplyButton).Click();

        }
        public void ClickDivide()
        {
            _driver.FindElement(divideButton).Click();

        }
        public void ClickAdd()
        {
            _driver.FindElement(additionButton).Click();

        }
        public void ClickSubtract()
        {
            _driver.FindElement(subtractButton).Click();

        }
        public void ClickToThePowerOf()
        {
            _driver.FindElement(powerButton).Click();
        }
        public void ClickEquals()
        {
            _driver.FindElement(equalsButton).Click();
        }
        public void Results(int expectedResult)
        {
            _driver.FindElement(resultBox);
            var Test = _driver.FindElement(resultBox).Text;
            int ActualResult = int.Parse(_driver.FindElement(resultBox).Text);
            Assert.That(ActualResult, Is.EqualTo(expectedResult), $"The result {ActualResult} is not equal to the expected result: {expectedResult}");
        }
    }
}


