using System;
using TechTalk.SpecFlow;

namespace Inverita.AQA.SpecFlowProject.Hooks
{
    [Binding]
    public class Hooks
    {
        private readonly ScenarioContext _scenarioContext;

        public Hooks(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [BeforeScenario()]
        public void BeforeScenario()
        {
            // as reg use
            _scenarioContext.Add("test", "test");
            
            Console.WriteLine("Starting " + ScenarioContext.Current.ScenarioInfo.Title);
        }
        
        [AfterScenario()]
        public void AfterScenario()
        {
            Console.WriteLine("Finished " + ScenarioContext.Current.ScenarioInfo.Title);
        }
        
        
        [AfterScenario("mySpecialScenario")]
        [AfterScenario("asGuestUser")]
        public void ForSmokeAfterScenarioHook()
        {
            Console.WriteLine("-------------Finished cool scenario-------- " + ScenarioContext.Current.ScenarioInfo.Title);
        }

        [BeforeScenario("asGuestUser")]
        public void LoginAsGuestUser()
        {
            /////
        }
    }
}