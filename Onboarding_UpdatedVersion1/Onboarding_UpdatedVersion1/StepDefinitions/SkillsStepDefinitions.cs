using NUnit.Framework;
using Onboarding_UpdatedVersion1.Pages;
using Onboarding_UpdatedVersion1.Utilities;
using System;
using System.Reflection.Emit;
using TechTalk.SpecFlow;
using static NUnit.Framework.Constraints.Tolerance;

namespace Onboarding_UpdatedVersion1.StepDefinitions
{
    [Binding]
    public class SkillsStepDefinitions :CommonDriver
    {
        Skills skillObj;
        public SkillsStepDefinitions()
        {
            skillObj = new Skills();
        }

        [When(@"I add '([^']*)' and '([^']*)'")]
        public void WhenIAddAnd(string skill, string level)
        {
            skillObj.SkillsClick(skill, level);
            skillObj.SkillsSteps(skill, level);
            skillObj.SkillsAdd(skill, level);
        }

        [Then(@"The skills record '([^']*)' and '([^']*)'  should be added successfully on profile page\.")]
        public void ThenTheSkillsRecordAndShouldBeAddedSuccessfullyOnProfilePage_(string Skill, string Level)
        {
            string newskill = skillObj.GetSkill(Skill,Level);
            string newskillLevel = skillObj.GetSkillLevel(Skill, Level);

            
            if ((newskill == Skill)&&(newskillLevel== Level))
            {
                Assert.Pass("Skill added");
            }
            else
            {
                Assert.Fail("Fail");
            }
        }
               

        [When(@"I update skill and skill experience level")]
        public void WhenIUpdateSkillAndSkillExperienceLevel()
        {
            skillObj.UpdateSkillsClick();
            skillObj.UpdateSkills();
            skillObj.UpdateSkillsButton();

        }

        [Then(@"Updated skill record should be displayed on profile page")]
        public void ThenUpdatedSkillRecordShouldBeDisplayedOnProfilePage()
        {            
             string newUpdatedSkill = skillObj.GetUpdatedSkill();
             string newUpdatedSkillLevel = skillObj.GetUpdatedSkillLevel();

            if ((newUpdatedSkill == "Dance")&&(newUpdatedSkillLevel == "Expert"))
            {
                Assert.Pass("Skill Updated");
            }
            else
            {
                Assert.Fail("Opps Skill NOT updated");
            }           
        }

        [When(@"I delete a skill record")]
        public void WhenIDeleteASkillRecord()
        {
            skillObj.DeleteSkills();
            Thread.Sleep(3000);
        }

        [Then(@"Deleted skill record should NOT be displayed on profile page")]
        public void ThenDeletedSkillRecordShouldNOTBeDisplayedOnProfilePage()
        {
            string deletedSkill=skillObj.GetDeleteSkills();
            
            if (deletedSkill == "Dance")             
            {
                Assert.Fail("Opps Skill NOT Deleted"); 
                
            }
            else
            {
                Assert.Pass("Skill Deleted");
            }


        }
    }
}
