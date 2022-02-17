using TechTalk.SpecFlow;

namespace Inverita.AQA.SpecFlowProject
{
    [Binding]
    public class BackgroundSteps
    {
        private readonly ScenarioContext _scenarioContext;
        
        public BackgroundSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }
        [Given(@"first number already entered")]
        public void GivenFirstNumberAlreadyEntered()
        {
            _scenarioContext.Add("first_number", 700);
        }
    }
}