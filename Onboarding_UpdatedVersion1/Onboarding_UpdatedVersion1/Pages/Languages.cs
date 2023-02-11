using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Onboarding_UpdatedVersion1.Utilities;
using NUnit.Framework;
using System.Reflection.Emit;
using System.Security.Cryptography.X509Certificates;

namespace Onboarding_UpdatedVersion1.Pages
{
    public class Languages : CommonDriver

    {
        IWebElement LanguageTab => driver.FindElement(By.XPath("//a[contains(text(),'Languages')]"));
        IWebElement LanguageAddNewButton => driver.FindElement(By.XPath("//div[@class='form-wrapper']/table/thead/tr[1]/th[3]/div[1]"));   
        IWebElement LanguageTextbox => driver.FindElement(By.Name("name"));
        IWebElement LanguageLevelOption => driver.FindElement(By.Name("level"));
        IWebElement languageAddButton => driver.FindElement(By.XPath("//input[@type='button' and @value='Add']"));
        IWebElement newLanguage => driver.FindElement(By.XPath("//div[@data-tab='first']//tbody[last()]/tr/td[1]"));
        IWebElement newLevel => driver.FindElement(By.XPath("//div[@data-tab='first']//tbody[last()]/tr/td[2]"));
        IWebElement EditLanguageIcon => driver.FindElement(By.XPath("//div[@data-tab='first']//tbody[last()]/tr/td[3]/span[1]/i"));
        IWebElement EditLanguage => driver.FindElement(By.Name("name"));
        IWebElement LanguageUpdateButton => driver.FindElement(By.XPath("//input[@type='button' and @value='Update']"));        
        IWebElement newUpdatedLanguage => driver.FindElement(By.XPath("//div[@class='form-wrapper']/table/tbody[last()]/tr[1]/td[1]"));
        IWebElement newUpdatedLevel => driver.FindElement(By.XPath("//div[@class='form-wrapper']/table/tbody[last()]/tr[1]/td[2]"));
        IWebElement DeleteLanguageIcon => driver.FindElement(By.XPath("//div[@data-tab='first']//tbody[last()]/tr/td[3]/span[2]/i"));
        IWebElement DeletedText => driver.FindElement(By.XPath("//div[@class='form-wrapper']/table/tbody[last()]/tr[1]/td[1]"));


        //Wait for the Add New button to be clickable
        public string Wait1 = "//div[@class='form-wrapper']/table/thead/tr[1]/th[3]/div[1]";
        //Wait the text to be visible
        public string TextWait = "//div[@data-tab='first']//tbody[last()]/tr/td[1]";
      


        //ADD LANGUAGE  

        public void clickLanguageAddNewButton(string Language, string Level)
        {
            
            LanguageTab.Click();
            LanguageAddNewButton.Click();
        }
        public void AddLanguageSteps( string Language, string Level)
        {
                      
            LanguageTextbox.SendKeys(Language);
            
            SelectElement languageLevel = new SelectElement(LanguageLevelOption);

            languageLevel.SelectByValue(Level);

            Wait.WaitToBeClickable(driver, "XPath", "Wait1", 3);
        }
        public void clickLanguageAddButton( string Language, string Level)
        { 
            languageAddButton.Click();
           //Wait.WaitToBeVisible(driver, "XPath",TextWait,5);           
            Thread.Sleep(5000);

        }
        public string GetLanguage(string Language, string Level)
        { 
             return newLanguage.Text;
        }
        public string GetLevel( string Language, string Level)
        {                      
            return newLevel.Text;
        }

        //UPDATE LANGUAGE
        public void clickLanguageUpdateIcon()
        { 
            EditLanguageIcon.Click();
        }
        
        public void UpdateLanguageSteps()
        {              
            EditLanguage.Clear();

            EditLanguage.SendKeys("French");

            SelectElement EditLanguageLevel = new SelectElement(driver.FindElement(By.Name("level")));

            EditLanguageLevel.SelectByValue("Conversational");          
           
        }
        public void clickLanguageUpdateButton()
        {
            LanguageUpdateButton.Click();
            Thread.Sleep(5000);
            //Wait.WaitToBeVisible(driver, "XPath", "//div[@data-tab='first']//tbody[last()]/tr/td[1]", 5);
        }

        //Validate Updated Language

        public string GetUpdatedLanguage()
        {            
            return newUpdatedLanguage.Text;
        }
        public string GetUpdatedLevel()
        {            
            return newUpdatedLevel.Text;
        }

        //DELETE LANGUAGE
        public void DeleteLanguageSteps()
        {                          
            DeleteLanguageIcon.Click();
            //Wait.WaitToBeVisible(driver, "XPath", "//div[@data-tab='first']//tbody[last()]/tr/td[1]", 5);
            Thread.Sleep(5000);
        }
        public string ValidateDeleteSteps()
        {          
            return DeletedText.Text;
        }

    }
}

