using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Onboarding.Utilities;
//using Mars_Profile_1.Utilities;
using NUnit.Framework;
using System.Reflection.Emit;

//namespace Mars_Profile_1.Pages
namespace Onboarding.Pages
{
    public class Languages : CommonDriver

    {
        public void AddLanguageSteps( IWebDriver driver, string Language, string Level)
        {
            //ADD LANGUAGE
            

            IWebElement LanguageTab = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[1]"));
            LanguageTab.Click();
            IWebElement LanguageAddButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div"));
            LanguageAddButton.Click();

            IWebElement LanguageTextbox = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[1]/input"));
            LanguageTextbox.SendKeys(Language);

            //IWebElement dropDownButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select"));
            //dropDownButton.Click();

            SelectElement languageLevel = new SelectElement(driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select")));
            languageLevel.SelectByValue(Level);

            Thread.Sleep(2000);
            IWebElement languageAddButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[1]"));
            languageAddButton.Click();                                                 

            Wait.WaitToExist(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[1]", 5);
        }

        public void ValidateLanguageSteps(IWebDriver driver)
        {
            //Validate Language
            //Thread.Sleep(1000);
            
            IWebElement LanguageText = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[1]"));
            Assert.That(LanguageText.Text == "English", "Oops Language was not added !");   
            IWebElement LanguageLevelText = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[2]"));
            Assert.That(LanguageText.Text == "Fluent", "Oops level was not added !");
            

        }

        //UPDATE LANGUAGE
        public void UpdateLanguageSteps(IWebDriver driver)

        {
            IWebElement EditLanguageIcon = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[3]/span[1]/i"));
            EditLanguageIcon.Click();

            IWebElement EditLanguage = driver.FindElement(By.Name("name"));
            EditLanguage.Clear();
            EditLanguage.SendKeys("French");

            SelectElement EditLanguageLevel = new SelectElement(driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td/div/div[2]/select")));
            EditLanguageLevel.SelectByValue("Conversational");

            IWebElement LanguageUpdateButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td/div/span/input[1]"));
            LanguageUpdateButton.Click();

            
            Wait.WaitToExist(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[1]", 5);
        
    }

        public void ValidateUpdateSteps(IWebDriver driver)
        {

            //Validate Updated Language
            Thread.Sleep(1000);
            IWebElement UpdatedText = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[1]"));
            Assert.That(UpdatedText.Text == "French", "Oops Language was not Updated !");
            IWebElement UpdatedLevelText = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[2]"));
            Assert.That(UpdatedLevelText.Text == "Conversational", "Oops level was not Updated !");

        }



        public void DeleteLanguageSteps(IWebDriver driver)
        {
            //DELETE LANGUAGE

            //Thread.Sleep(2000);

            IWebElement DeleteLanguageIcon = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[3]/span[2]/i"));
            DeleteLanguageIcon.Click();
        }
            public void ValidateDeleteSteps(IWebDriver driver)
            {
                //Validate Deleted Language record
                Thread.Sleep(1000);
                IWebElement DeletedText = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[1]"));
                Assert.That(DeletedText.Text != "French", "Oops Language was not Updated !");
                IWebElement DeletedLevelText = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[2]"));
                Assert.That(DeletedLevelText.Text != "Conversational", "Oops level was not Updated !");

            }

        }
    }

