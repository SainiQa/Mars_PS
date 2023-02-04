using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading.Tasks;
using OpenQA.Selenium.Interactions;
using System.Xml.Linq;
using NUnit.Framework;
using Onboarding_UpdatedVersion1.Utilities;

namespace Onboarding_UpdatedVersion1.Pages
{
    public class Certifications : CommonDriver
    {
        IWebElement CertificationTab => driver.FindElement(By.XPath("//a[contains(text(),'Certifications')]"));
        IWebElement CertAddnewButton => driver.FindElement(By.XPath("//div[@data-tab='fourth']/div[1]/div[2]/div/table/thead/tr/th[4]/div"));
        IWebElement certificateTextbox => driver.FindElement(By.Name("certificationName"));
        IWebElement certificatefromTextbox => driver.FindElement(By.Name("certificationFrom"));
        IWebElement certificateAddButton => driver.FindElement(By.XPath("//input [@type ='button' and @value='Add']"));       
        IWebElement CertificateText => driver.FindElement(By.XPath("//div[@data-tab=\"fourth\"]/div/div/div/table/tbody[last()]/tr/td[1]"));
        IWebElement CertificateFromText => driver.FindElement(By.XPath("//div[@class ='form-wrapper']/table/ tbody[last()]/tr/td[2]"));
        IWebElement CertificateYearText => driver.FindElement(By.XPath("//div[@class ='form-wrapper']/table/ tbody[last()]/tr/td[3]"));
        IWebElement EditCertificateIcon => driver.FindElement(By.XPath("//div[@data-tab='fourth']/div/div[2]/div/table/tbody[last()]/tr/td[4]/span[1]"));
        IWebElement EditCertificate => driver.FindElement(By.Name("certificationName"));
        IWebElement EditCertificateFrom => driver.FindElement(By.Name("certificationFrom"));
        IWebElement CertificateUpdateButton => driver.FindElement(By.XPath("//input[@type='button' and @value='Update']"));
        IWebElement NewUpdatedCertificate => driver.FindElement(By.XPath("//div[@data-tab='fourth']/div/div/div/table/tbody[last()]/tr/td[1]"));
        IWebElement DeleteCertificateIcon => driver.FindElement(By.XPath("//div[@data-tab='fourth']/div/div[2]/div/table/tbody[last()]/tr/td[4]/span[2]/i"));
        IWebElement DeletedCertificateText => driver.FindElement(By.XPath("//div[@class='form-wrapper']/table/tbody[last()]/tr[1]/td[1]"));

            //Add Certification            
        public void ClickCertification()
        {
                CertificationTab.Click();
                CertAddnewButton.Click();

        }

        public void CertificationSteps()
        {
            certificateTextbox.SendKeys("Salesforce Administrator");           
            certificatefromTextbox.SendKeys("Salesforce");
            SelectElement Certificateyear = new SelectElement(driver.FindElement(By.Name("certificationYear")));
            Certificateyear.SelectByValue("2020");
                   
            certificateAddButton.Click();
            //Wait.WaitToBeVisible(driver, "XPath", "//div[@class ='form-wrapper']/table/tbody[last()]/tr/td[1]",10);
            Thread.Sleep(3000);
        }

        public string GetCertificate()
        {            
            return CertificateText.Text;
            
        }

        //Update Certificate Record
        public void UpdateCertificateClick()

        {
            CertificationTab.Click();
            
            Wait.WaitToBeVisible(driver, "XPath", "//div[@data-tab='fourth']/div/div/div/table/tbody[last()]/tr/td[1]", 10);

            EditCertificateIcon.Click();
        }
        public void UpdateCertificateDetails()
        {
            EditCertificate.Clear();

            EditCertificate.SendKeys("AWS");

            EditCertificateFrom.Clear();

            EditCertificateFrom.SendKeys("Amazon");

            SelectElement EditCertificateyear = new SelectElement(driver.FindElement(By.Name("certificationYear")));

            EditCertificateyear.SelectByValue("2022");
        }
        public void UpdateCertificate()
        { 
            CertificateUpdateButton.Click();
            
            Wait.WaitToBeVisible(driver, "XPath", "//div[@data-tab='fourth']/div/div/div/table/tbody[last()]/tr/td[1]", 10);
        }

        public string GetUpdatedCertificate()
        {
            Thread.Sleep(5000);                      
            return NewUpdatedCertificate.Text;
        }

        public void DeleteCertificate()
        {
            CertificationTab.Click();
            Wait.WaitToExist(driver, "XPath", "//div[@class='form-wrapper']/table/ tbody/tr/td[1]", 10);           
            DeleteCertificateIcon.Click();
            Thread.Sleep(5000);
        }

        public string GetDeleteCertificate()
        {
            
            return DeletedCertificateText.Text;         

        }


    }
}
