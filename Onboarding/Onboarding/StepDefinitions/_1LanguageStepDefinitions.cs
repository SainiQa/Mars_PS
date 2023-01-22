using Onboarding.Pages;
using Onboarding.Utilities;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace Onboarding.StepDefinitions
{
    [Binding]
    public class _1LanguageStepDefinitions : CommonDriver
    {
        Languages languagesPageObject = new Languages();
        Login loginObject = new Login();
        

        [Given(@"I logged into Mars application successfully")]
        public void GivenILoggedIntoMarsApplicationSuccessfully()
        {
           driver = new ChromeDriver();
                       
            loginObject.LoginSteps(driver);
        }

        [When(@"I add '([^']*)', '([^']*)'")]
        public void WhenIAdd(string Language, string Level)
        {
            languagesPageObject.AddLanguageSteps(driver,Language,Level);
        }


        [Then(@"Added language record should be successfully added on profile page")]
        public void ThenAddedLanguageRecordShouldBeSuccessfullyAddedOnProfilePage(Table table)
        {
            languagesPageObject.ValidateLanguageSteps(driver);
        }


        //[Then(@"'([^']*)', '([^']*)' should be added successfully on profile page")]
        //public void ThenShouldBeAddedSuccessfullyOnProfilePage(string Language, string Level)
        //{
        //    languagesPageObject.ValidateLanguageSteps(driver, Language, Level);
        //}

        [When(@"I  update Language and corresponding level on an existing language record")]
        public void WhenIUpdateLanguageAndCorrespondingLevelOnAnExistingLanguageRecord()
        {
            languagesPageObject.UpdateLanguageSteps(driver);
        }

        [Then(@"Updated language record should be displayed on profile page")]
        public void ThenUpdatedLanguageRecordShouldBeDisplayedOnProfilePage()
        {
            languagesPageObject.ValidateUpdateSteps(driver);
        }

        [When(@"I  delete an existing language record")]
        public void WhenIDeleteAnExistingLanguageRecord()
        {
            languagesPageObject.DeleteLanguageSteps(driver);
        }

        [Then(@"Language Record should be deleted and Deleted record should NOT be displayed on profile page")]
        public void ThenLanguageRecordShouldBeDeletedAndDeletedRecordShouldNOTBeDisplayedOnProfilePage()
        {
            languagesPageObject.ValidateDeleteSteps(driver);
        }

    }
}
