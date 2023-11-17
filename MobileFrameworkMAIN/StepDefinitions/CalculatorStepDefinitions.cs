using ConnorGriffithsMobileFrameworkFinal.HomePage;
using NUnit.Framework;
using OpenQA.Selenium.Appium.Android;

namespace MobileFrameworkMAIN.StepDefinitions
{

    [Binding]
    public class CalculatorStepDefinitions
    {
        private readonly AndroidDriver<AndroidElement> _driver;
        private Calculator homepage;

        public CalculatorStepDefinitions(AndroidDriver<AndroidElement> driver)
        {
            _driver = driver;
            homepage = new Calculator(driver);
        }


        [Given("I click on the number Nine")]
        public void ClickNumberNine()
        {
            homepage.ClickNumberNine();
        }
    
        [When("I click the number Two")]
        public void ClickNumberTwo()
        {
            homepage.ClickNumberTwo();
            
        }
        [When("I click the number Four")]
        public void ClickNumberFour()
        {
            homepage.ClickNumberFour();

        }

        [Given("I click the number Eight")]
        [When("I click the number Eight")]
        public void ClickNumberEight()
        {
            homepage.ClickNumberEight();

        }

        [When("I click Divide")]
        public void ClickDivide()
        {
            homepage.ClickDivide();
        }

        [When("I click add")]
        public void ClickAdd()
        {
            homepage.ClickAdd();
        }

        [When("I click Subtract")]
        public void ClickSubtract()
        {
            homepage.ClickSubtract();
        }

        [When("I click Multiply")]
        public void ClickMultiply()
        {
            homepage.ClickMultiply();
        }

        [When("I click to the power of")]
        public void ClickPowerOf()
        {
            homepage.ClickToThePowerOf();
        }

        [Then("I validate the answer is 10")]
        public void ValidateAnswerAddition()
        {
            homepage.Results(10);
        }

        [Then("I validate the answer is 81")]
        public void ValidateAnswerPower()
        {
            homepage.Results(81);
        }

        [Then("I validate the answer is 6")]
        public void ValidateAnswerSubtraction()
        {
            homepage.Results(6);
        }

        [Then("I validate the answer is 4")]
        public void ValidateAnswerDivision()
        {
            homepage.Results(4);
        }

        [Then("I validate the answer is 32")]
        public void ValidateAnswerMultiplication()
        {
            homepage.Results(32);
        }




    }
}
