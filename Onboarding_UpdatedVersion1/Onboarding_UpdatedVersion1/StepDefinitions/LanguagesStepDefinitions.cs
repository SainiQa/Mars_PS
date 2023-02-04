using Onboarding_UpdatedVersion1.Utilities;
using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Onboarding_UpdatedVersion1.Pages;
using OpenQA.Selenium.DevTools;
using NUnit.Framework;
using System.Reflection.Emit;


namespace Onboarding_UpdatedVersion1.StepDefinitions
{
    [Binding]
    public class LanguagesStepDefinitions : CommonDriver
    {

        Languages languagesPageObject; 
        Login loginObject;

        public LanguagesStepDefinitions()
        {
             languagesPageObject = new Languages();
            loginObject = new Login();
        }        

        [Given(@"I logged into Mars application successfully")]
        public void GivenILoggedIntoMarsApplicationSuccessfully()
        {
            

            loginObject.LoginSteps();
        }
       

        [When(@"I add '([^']*)', '([^']*)'")]
        public void WhenIAdd(string Language, string Level)
        {
            languagesPageObject.clickLanguageAddNewButton( Language, Level);

            languagesPageObject.AddLanguageSteps( Language, Level);

            languagesPageObject.clickLanguageAddButton( Language, Level);
        }
      

        [Then(@"The record should display the added '([^']*)' and '([^']*)'")]
        public void ThenTheRecordShouldDisplayTheAddedAnd(string Language, string Level)
        {
           string newLanguage = languagesPageObject.GetLanguage(Language, Level);
           string newLevel = languagesPageObject.GetLevel(Language, Level);

            Assert.That(newLanguage, Is.EqualTo(Language));
            Assert.That(newLevel, Is.EqualTo(Level));

        }
       

        [When(@"I  update Language and corresponding level on an existing language record")]
        public void WhenIUpdateLanguageAndCorrespondingLevelOnAnExistingLanguageRecord()
        {
            languagesPageObject.clickLanguageUpdateIcon();

            languagesPageObject.UpdateLanguageSteps();

            languagesPageObject.clickLanguageUpdateButton();
        }

       
        [Then(@"Updated language record should be displayed on profile page")]
        public void ThenUpdatedLanguageRecordShouldBeDisplayedOnProfilePage()
        {
            string newUpdatedLanguage = languagesPageObject.GetUpdatedLanguage();
            string newUpdatedLevel = languagesPageObject.GetUpdatedLevel();

            if ((newUpdatedLanguage == "French") && (newUpdatedLevel == "Conversational"))
            {
            Assert.Pass("Pass!Language record Updated"); 
            }
            else
            { 
                Assert.Fail("Fail!Language record NOT updated");
            }


        }
        

        [When(@"I  delete an existing language record")]
        public void WhenIDeleteAnExistingLanguageRecord()
        {
            languagesPageObject.DeleteLanguageSteps();
        }
       

        [Then(@"Language Record should be deleted and Deleted record should NOT be displayed on profile page")]
        public void ThenLanguageRecordShouldBeDeletedAndDeletedRecordShouldNOTBeDisplayedOnProfilePage()
        {
            string DeletedText = languagesPageObject.ValidateDeleteSteps();
           

            if (DeletedText == "French")
            {
                Assert.Fail("Fail!Language record NOT Deleted");
                
            }
            else
            {
                Assert.Pass("Pass!Language record Deleted");
            }
            
        }
        
    }
    
}
