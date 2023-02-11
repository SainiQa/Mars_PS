using TechTalk.SpecFlow;
using Onboarding_UpdatedVersion1.Utilities;
namespace Onboarding_UpdatedVersion1
{
    [Binding]
    public sealed class Hooks:CommonDriver
    {
        [BeforeScenario]
        public void FirstBeforeScenario()
        {
                     
                //launch the browser

                Initialize();           

        }

        [AfterScenario]
        public void AfterScenario()
        {
                 Close();
        }
    }
}