using NUnit.Framework;
using Onboarding_UpdatedVersion1.Pages;
using Onboarding_UpdatedVersion1.Utilities;
using System;
using System.Reflection.Emit;
using TechTalk.SpecFlow;

namespace Onboarding_UpdatedVersion1.StepDefinitions
{
    [Binding]
    public class CertificationsStepDefinitions : CommonDriver
    {
        Certifications CertObj;
        public CertificationsStepDefinitions()
        {
            CertObj = new Certifications();
        }

        [When(@"I add Certficate, Certificatefrom and Year")]
        public void WhenIAddCertficateCertificatefromAndYear()
        {
            CertObj.ClickCertification();
            CertObj.CertificationSteps();
            
        }

        [Then(@"Certificate record should be successfully added on profile page")]
        public void ThenCertificateRecordShouldBeSuccessfullyAddedOnProfilePage()
        {
            string newCertText = CertObj.GetCertificate();

            if (newCertText == "Salesforce Administrator")
            { 
                Assert.Pass("Add Operation  Pass"); 
            }
            else
            { 
                Assert.Fail("Add Operation Fail");
            }

        }

        [When(@"I  update Certificate,Certificate from and the Year")]
        public void WhenIUpdateCertificateCertificateFromAndTheYear()
        {
            CertObj.UpdateCertificateClick();

            CertObj.UpdateCertificateDetails();

            CertObj.UpdateCertificate();

        }

        [Then(@"Certification record should be updated and displayed on profile page")]
        public void ThenCertificationRecordShouldBeUpdatedAndDisplayedOnProfilePage()
        {            
            string NewUpdatedCertificate= CertObj.GetUpdatedCertificate();

            if (NewUpdatedCertificate == "AWS")
            {
                Assert.Pass("Update Pass");
            }
            else
            {
                Assert.Fail("Update Fail");
            }
        }
    

        [When(@"I  delete an existing certification record")]
        public void WhenIDeleteAnExistingCertificationRecord()
        {
            CertObj.DeleteCertificate();
        }

        [Then(@"The record should be  deleted and should NOT be displayed in the list")]
        public void ThenTheRecordShouldBeDeletedAndShouldNOTBeDisplayedInTheList()
        {
            string DeletedCertificateText = CertObj.GetDeleteCertificate();

            if (DeletedCertificateText == "AWS")
            {
                Assert.Fail("Record Not Deleted,Test Failed");
                
            }
            else
            {
                Assert.Pass("Record Deleted,Test Passed");
            }
        }
    }
}
