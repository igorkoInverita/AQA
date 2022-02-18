using System;
using TechTalk.SpecFlow;

namespace Inverita.AQA.SpecFlowProject.Hooks
{
    [Binding]
    public class DatabaseHooks
    {
        private readonly ScenarioContext _scenarioContext;

        public DatabaseHooks(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [BeforeScenario()]
        public void BeforeScenario1()
        {
           // database setup
        }
        
        [BeforeScenario()]
        public void BeforeScenario2()
        {
            // database setup
        }
    }
}