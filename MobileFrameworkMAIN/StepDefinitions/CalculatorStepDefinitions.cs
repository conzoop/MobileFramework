using ConnorGriffithsMobileFrameworkFinal.Calculator;
using ConnorGriffithsMobileFrameworkFinal.Calculator;
using NUnit.Framework;
using OpenQA.Selenium.Appium.Android;

namespace MobileFrameworkMAIN.StepDefinitions
{

    [Binding]
    public class CalculatorStepDefinitions
    {
        private readonly AndroidDriver<AndroidElement> _driver;
        private CalculatorPage calculator;

        public CalculatorStepDefinitions(AndroidDriver<AndroidElement> driver)
        {
            _driver = driver;
            calculator = new CalculatorPage(driver);
        }

        [Given("I click on the number Nine")]
        public void ClickNumberNine()
        {
            calculator.ClickNumberNine();
        }

        [When("I click the number Two")]
        public void ClickNumberTwo()
        {
            calculator.ClickNumberTwo();

        }
        [When("I click the number Four")]
        public void ClickNumberFour()
        {
            calculator.ClickNumberFour();

        }

        [Given("I click the number Eight")]
        [When("I click the number Eight")]
        public void ClickNumberEight()
        {
            calculator.ClickNumberEight();

        }

        [When("I click Divide")]
        public void ClickDivide()
        {
            calculator.ClickDivide();
        }

        [When("I click add")]
        public void ClickAdd()
        {
            calculator.ClickAdd();
        }

        [When("I click Subtract")]
        public void ClickSubtract()
        {
            calculator.ClickSubtract();
        }

        [When("I click Multiply")]
        public void ClickMultiply()
        {
            calculator.ClickMultiply();
        }

        [When("I click to the power of")]
        public void ClickPowerOf()
        {
            calculator.ClickToThePowerOf();
        }

        [Then("I validate the answer is 10")]
        public void ValidateAnswerAddition()
        {
            calculator.Results(10);
        }

        [Then("I validate the answer is 81")]
        public void ValidateAnswerPower()
        {
            calculator.Results(81);
        }

        [Then("I validate the answer is 6")]
        public void ValidateAnswerSubtraction()
        {
            calculator.Results(6);
        }

        [Then("I validate the answer is 4")]
        public void ValidateAnswerDivision()
        {
            calculator.Results(4);
        }

        [Then("I validate the answer is 32")]
        public void ValidateAnswerMultiplication()
        {
            calculator.Results(32);
        }
    }
}
