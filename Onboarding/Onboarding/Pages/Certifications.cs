using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Interactions;
using System.Xml.Linq;
using NUnit.Framework;

namespace Onboarding.Pages
{
    public class Certifications
    {
        public void CertificationSteps(IWebDriver driver)
        {
            //Add Certification

            IWebElement CertificationTab = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[4]"));
            CertificationTab.Click();

            IWebElement CertAddnewButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/thead/tr/th[4]/div"));
            CertAddnewButton.Click();

            IWebElement certificateTextbox = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[1]/div/input"));
            certificateTextbox.SendKeys("Salesforce Administrator");

            //certificateTextbox.SendKeys(Certificate);
            
            IWebElement certificatefromTextbox = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[2]/div[1]/input"));
            certificatefromTextbox.SendKeys("Salesforce");

            //certificatefromTextbox.SendKeys(Certificatefrom);
            //IWebElement CertificateDropdown = driver.FindElement(By.Name("certificationYear"));
            //CertificateDropdown.Click();
            //Thread.Sleep(2000);

            
            SelectElement Certificateyear = new SelectElement(driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[2]/div[2]/select")));
            Certificateyear.SelectByValue("2020");

            //Certificateyear.SelectByValue(Year);
           Thread.Sleep(2000);


            IWebElement certificateAddButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[3]/input[1]"));
            certificateAddButton.Click();
        }




        //Validate Certificate record

        //public string GetCertificate(IWebDriver driver)
        //{
        //    IWebElement CertificateText = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td[1]");
        //    return CertificateText.Text;
        //}
        //public string GetCertificateFrom(IWebDriver driver)
        //{
        //    IWebElement CertificateFromText = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td[2]");
        //    return CertificateFromText.Text;
        //}

        //public string GetCertificateYear(IWebDriver driver)
        //{
        //    IWebElement CertificateYearText = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td[3]");
        //    return CertificateYearText.Text;
        //}

        //{Assert.That(GetCertificate.Text == "Salesforce Administrator", "Certificate Name not Updated");}

        public void ValidateCertification(IWebDriver driver)
        {
            IWebElement CertificateText = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td[1]"));

            IWebElement CertificateFromText = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td[2]"));

            IWebElement CertificateYearText = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td[3]"));


            Assert.That(CertificateText.Text == "Salesforce Administrator", "Certificate Name not added");
            Assert.That(CertificateFromText.Text == "Salesforce Administrator", "Certificate Name not added");
            Assert.That(CertificateYearText.Text == "2020", "Certificate Name not added");
        }

        //Update Certificate Record
        public void UpdateCertificate(IWebDriver driver)

            {
                Thread.Sleep(2000);
            IWebElement CertificationTab = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[4]"));
            CertificationTab.Click();

            IWebElement EditCertificateIcon = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[1]/tr/td[4]/span[1]/i"));
                EditCertificateIcon.Click();

                IWebElement EditCertificate = driver.FindElement(By.Name("certificationName"));
                EditCertificate.Clear();
                EditCertificate.SendKeys("AWS");

                IWebElement EditCertificateFrom = driver.FindElement(By.Name("certificationFrom"));
                EditCertificateFrom.Clear();
                EditCertificateFrom.SendKeys("Amazon");

                SelectElement EditCertificateyear = new SelectElement(driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[1]/tr/td/div/div/div[3]/select")));
                EditCertificateyear.SelectByValue("2022");

                IWebElement CertificateUpdateButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[1]/tr/td/div/span/input[1]"));
                CertificateUpdateButton.Click();
            }
        public void ValidateUpdatedCertification(IWebDriver driver)
        {
            IWebElement CertificateText = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td[1]"));

            IWebElement CertificateFromText = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td[2]"));

            IWebElement CertificateYearText = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td[3]"));


            Assert.That(CertificateText.Text == "AWS", "Certificate Name not Updated");
            Assert.That(CertificateFromText.Text == "Amazon", "Certificate Name not Updated");
            Assert.That(CertificateYearText.Text == "2022", "Certificate Name not Updated");
        }
        public void DeleteCertificate(IWebDriver driver)
        {
            //Delete Certification
            Thread.Sleep(2000);
            IWebElement CertificationTab = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[4]"));
            CertificationTab.Click();
             IWebElement DeleteCertificateIcon = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td[4]/span[2]/i"));

            DeleteCertificateIcon.Click();
        }

        public void GetDeleteCertificate(IWebDriver driver)
        {
            IWebElement SkillTab = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]"));
            SkillTab.Click();
            IWebElement DeletedCertificateText = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td[1]"));
                       
            Assert.That(DeletedCertificateText.Text != "AWS", "Opps! The certificate record is not deleted");
            
        }


    }

}


