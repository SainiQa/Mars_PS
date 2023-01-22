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

            IWebElement certificatefromTextbox = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[2]/div[1]/input"));
            certificatefromTextbox.SendKeys("Salesforce");

            //IWebElement CertificateDropdown = driver.FindElement(By.Name("certificationYear"));
            //CertificateDropdown.Click();
            //Thread.Sleep(2000);

            //Select an option for certificate year
            SelectElement Certificateyear = new SelectElement(driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[2]/div[2]/select")));
            Certificateyear.SelectByValue("2020");
            Thread.Sleep(2000);

            IWebElement certificateAddButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[3]/input[1]"));
            certificateAddButton.Click();

            ////Validate Certificate record

            //public string GetCertificate(IWebDriver driver)
            //    { 
            //    IWebElement CertificateText = driver.FindElement(By.XPath
            //     return CertificateText.Text;
            //    }
            //public string GetCertificateFrom(IWebDriver driver)
            //{
            //    IWebElement CertificateFromText = driver.FindElement(By.XPath
            //     return CertificateFromText.Text;
            //}

            //public string GetCertificateYear(IWebDriver driver)
            //{
            //    IWebElement CertificateYearText = driver.FindElement(By.XPath
            //     return CertificateYearText.Text;
            //}
            //Assert.That(GetCertificate.Text == "Salesforce Administrator", "Certificate Name not added");

            //Update Certificate Record

            Thread.Sleep(2000);

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

            //Delete Certification

            Thread.Sleep(2000);

            IWebElement DeleteCertificateIcon = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td[4]/span[2]/i"));

            DeleteCertificateIcon.Click();
        }

    }
}

