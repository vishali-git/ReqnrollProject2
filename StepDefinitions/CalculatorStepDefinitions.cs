using NUnit.Framework;
using System;
using ReqnrollProject2;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReqnrollProject2.StepDefinitions
{
    [Binding]
    public sealed class CalculatorStepDefinitions
    {
        private readonly Calculator calculator = new Calculator();
        private int _result;
        private readonly ScenarioContext _scenarioContext;
        public CalculatorStepDefinitions(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }
        
        public void WhenTheFirstNumberIsDividedByTheSecondNumber()
        {
            _scenarioContext.Pending();
        }

        [Given("the first number is {int}")]
        public void GivenTheFirstNumberIs(int number)
        {
            calculator.FirstNumber = number;
        }

        [Given("the second number is {int}")]
        public void GivenTheSecondNumberIs(int number)
        {
            calculator.SecondNumber = number;
        }

        [When("the two numbers are added")]
        public void WhenTheTwoNumbersAreAdded()
        {
            _result = calculator.Add();
        }

        [Then("the result should be {int}")]
        public void ThenTheResultShouldBe(int result)
        {
            Assert.That(_result, Is.EqualTo(result));

        }
        [When("the two numbers are subtracted")]
        public void WhenTheTwoNumbersAreSubtracted()
        {
            _result = calculator.Subtract();
        }
        [Then("the subtraction result should be {int}")]
        public void ThenTheSubtractionResultShouldBe(int result)
        {
            Assert.That(_result, Is.EqualTo(result));
        }
        [When("the two numbers are multiplied")]
        public void WhenTheTwoNumbersAreMultiplied()
        {
            _result = calculator.Multiply();
        }
        [Then("the multiplication result should be {int}")]
        public void ThenTheMultiplicationResultShouldBe(int result)
        {
            Assert.That(_result, Is.EqualTo(result));
        }
        //[When("the two numbers are divided")]
        //public void WhenTheTwoNumbersAreDivided()
        //{
        //    throw new PendingStepException();
        //}
        [When("the two numbers are divided")]
        public void WhenTheTwoNumbersAreDivided()
        {
            _result = calculator.Divide();
        }



        [Then("the division result should be {int}")]
        public void ThenTheDivisionResultShouldBe(int result)
        {
            Assert.That(_result, Is.EqualTo(result));
        }
    }
}
