using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TechTalk.SpecFlow;

namespace CalcSpecflowExcel
{
    [Binding]
    public class CalcSpecExcelSteps
    {
        [Given(@"I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredIntoTheCalculator(int x)
        {
            int a = x;
            Console.WriteLine("First number is" + a);
        }

        [Given(@"Also have entered (.*) into the calculator")]
        public void GivenAlsoHaveEnteredIntoTheCalculator(int y)
        {

            int b = y;
            Console.WriteLine("Second number is" + b);
        }


        [When(@"I press add")]
        public void WhenIPressAdd()
        {
            Console.WriteLine("The two numbers to be added are Calculation");
        }

        [Then(@"the result of adding (.*) and (.*) should be (.*) on the screen")]
        public void ThenTheResultOfAddingAndShouldBeOnTheScreen(int x, int y, int result)
        {
            int a = x;
            int b = y;
            int E = x + y;
            Assert.AreEqual(E, result);
        }
    }
}
