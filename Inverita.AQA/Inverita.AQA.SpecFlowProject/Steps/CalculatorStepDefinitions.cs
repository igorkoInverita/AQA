using Inverita.AQA.FirstTest;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace Inverita.AQA.SpecFlowProject.Steps
{
    [Binding]
    public sealed class CalculatorStepDefinitions
    {
        private readonly ScenarioContext _scenarioContext;

        private readonly MyCalculator _myCalculator = new MyCalculator();

        public CalculatorStepDefinitions(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [Given("Step 1")]
        [Given("I close Nurses popup")]
        [Given("I close Patients popup")]
        // [When("Step 2")]
        // [Then("Step 3")]
        public void IWillNeverBeOld()
        {
            //_scenarioContext.
            // Submit
            // Popup.Close();
        }

        [Given("the first number is (.*)")]
        public void GivenTheFirstNumberIs(int number)
        {
            
            var tt = _scenarioContext.Get<string>("test");
            
            //DatabaseHelpers.GetUsers();
            
            _myCalculator.FirstNumber = number;
            
            
            _scenarioContext.Add("first_number", number);
        }

        [Given("the second number is (.*)")]
        public void GivenTheSecondNumberIs(int number)
        {
            _myCalculator.SecondNumber = number;
            
            _scenarioContext.Add("second_number", number);
        }

        [When("the two numbers are added")]
        public void WhenTheTwoNumbersAreAdded()
        {
            // implement act (action) logic

            // var res = _myCalculator.Add();
            // _scenarioContext.Add("res", res);
            
            //--------------------------------

            var firstNum = _scenarioContext.Get<int>("first_number");
            var secondNum = _scenarioContext.Get<int>("second_number");

            _scenarioContext.Add(Constants.ResultKey, MyCalculator.Add(firstNum, secondNum));
        }

        [Then("the result should be (.*)")]
        public void ThenTheResultShouldBe(int result)
        {
            //TODO: implement assert (verification) logic
            var res = _scenarioContext.Get<int>(Constants.ResultKey);
            Assert.That(res, Is.EqualTo(result));
            
            //-------------------
            
            
            
            //
            // var resultValue = _scenarioContext.Get<int>("result");
            //
            // Assert.That(resultValue, Is.EqualTo(result), "Wrong calculation");
        }

        [Given(@"open browser")]
        public void GivenOpenBrowser()
        {
           var driver = new ChromeDriver();
           
           driver.Navigate().GoToUrl("https://stage.portal.inveritasoft.com/portal/people/page/1");
           driver.Navigate().Refresh();
           
           driver.Quit();
        }

        [Given(@"open browser window")]
        public void GivenOpenBrowserWindow()
        {
            var driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://stage.portal.inveritasoft.com/portal/people/page/1");
            
            driver.Navigate().Refresh();
            driver.Quit();
        }

        [Then(@"the result should (.*) with status (.*)")]
        public void ThenTheResultShouldWithStatusTrue(int p0, bool status)
        {
            //ScenarioContext.StepIsPending();
        }
    }
}