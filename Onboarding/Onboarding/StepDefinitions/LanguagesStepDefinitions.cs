using Mars_Profile_1.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace Onboarding.StepDefinitionsFile
{
    [Binding]
    public class LanguagesStepDefinitions
    {
        [Given(@"I logged into Mars application successfully")]
        public void GivenILoggedIntoMarsApplicationSuccessfully()
        {
            IWebDriver driver = new ChromeDriver();
            Login loginObject = new Login();
            loginObject.LoginSteps(driver);

        }

        [When(@"I add language and corresponding level")]
        public void WhenIAddLanguageAndCorrespondingLevel()
        {
            throw new PendingStepException();
        }

        [Then(@"Language and its corresponding level should be added successfully on profile page")]
        public void ThenLanguageAndItsCorrespondingLevelShouldBeAddedSuccessfullyOnProfilePage()
        {
            throw new PendingStepException();
        }

        [When(@"I  update Language and corresponding level on an existing language record")]
        public void WhenIUpdateLanguageAndCorrespondingLevelOnAnExistingLanguageRecord()
        {
            throw new PendingStepException();
        }

        [Then(@"Updated language record should be displayed on profile page")]
        public void ThenUpdatedLanguageRecordShouldBeDisplayedOnProfilePage()
        {
            throw new PendingStepException();
        }

        [When(@"I  delete an existing language record")]
        public void WhenIDeleteAnExistingLanguageRecord()
        {
            throw new PendingStepException();
        }

        [Then(@"Language Record should be deleted and Deleted record should NOT be displayed on profile page")]
        public void ThenLanguageRecordShouldBeDeletedAndDeletedRecordShouldNOTBeDisplayedOnProfilePage()
        {
            throw new PendingStepException();
        }
    }
}
