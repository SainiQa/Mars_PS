using Onboarding.Pages;
using Onboarding.Utilities;
using System;
using System.Reflection.Emit;
using TechTalk.SpecFlow;

namespace Onboarding.StepDefinitions 
{
    [Binding]
    public class _2SkillsStepDefinitions : CommonDriver
    {
        Skills skillObj = new Skills();

        //[Given(@"I logged into Mars application successfully")]
        //public void GivenILoggedIntoMarsApplicationSuccessfully()
        //{
        //    Login loginObject = new Login();
        //    loginObject.LoginSteps(driver);
        //}

        [When(@"I add '([^']*)' and '([^']*)'")]
        public void WhenIAddAnd(string skill, string level)

        {
           
            skillObj.SkillsSteps(driver, skill, level);
            

        }

        [Then(@"Added record should be displayed in skill list under skill tab on profile page")]
        public void ThenAddedRecordShouldBeDisplayedInSkillListUnderSkillTabOnProfilePage(Table table)
        {
            skillObj.GetSkills(driver);
        }

        [When(@"I update skill and skill experience level")]
        public void WhenIUpdateSkillAndSkillExperienceLevel()
        {
            skillObj.UpdateSkills(driver);
        }

        [Then(@"Updated skill record should be displayed on profile page")]
        public void ThenUpdatedSkillRecordShouldBeDisplayedOnProfilePage()
        {
            skillObj.GetUpdateSkills(driver);
        }

        [When(@"I delete a skill record")]
        public void WhenIDeleteASkillRecord()
        {
            skillObj.DeleteSkills(driver);
        }

        [Then(@"Deleted skill record should NOT be displayed on profile page")]
        public void ThenDeletedSkillRecordShouldNOTBeDisplayedOnProfilePage()
        {
            skillObj.GetDeleteSkills(driver);
        }
    }
}
