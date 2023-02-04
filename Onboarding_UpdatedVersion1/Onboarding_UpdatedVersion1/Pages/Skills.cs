using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Onboarding_UpdatedVersion1.Utilities;
using NUnit.Framework;



namespace Onboarding_UpdatedVersion1.Pages
{
    public class Skills :CommonDriver
    {
        IWebElement SkillTab => driver.FindElement(By.XPath("//a[contains(text(),'Skills')]"));        
        IWebElement SkillAddButton => driver.FindElement(By.XPath("//div[@data-tab='second']/div/div[2]/div/table/thead/tr/th[3]/div"));
        IWebElement SkillTextbox => driver.FindElement(By.Name("name"));
        IWebElement SkillAdd => driver.FindElement(By.XPath("//input [@type ='button' and @value='Add']"));        
        IWebElement newskill => driver.FindElement(By.XPath("//div[@data-tab='second']//table/tbody[last()]/tr/td[1]"));        
        IWebElement newSkillLevel => driver.FindElement(By.XPath("//div[@data-tab='second']//table/tbody[last()]/tr/td[2]"));        
        IWebElement EditSkillIcon => driver.FindElement(By.XPath("//div[@data-tab='second']//table/tbody[last()]/tr/td[3]/span[1]/i"));
        IWebElement EditSkill => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td/div/div[1]/input"));
        IWebElement SkillUpdateButton => driver.FindElement(By.XPath("//input[@type='button' and @value='Update']"));
        IWebElement newUpdatedskill => driver.FindElement(By.XPath("//div[@data-tab='second']//table/tbody[last()]/tr/td[1]"));
        IWebElement newUpdatedSkillLevel => driver.FindElement(By.XPath("//div[@data-tab='second']//table/tbody[last()]/tr/td[2]"));
        IWebElement DeleteSkillIcon => driver.FindElement(By.XPath("//div[@data-tab='second']/div/div[2]/div/table/tbody[last()]/tr/td[3]/span[2]/i"));
        IWebElement deletedSkill => driver.FindElement(By.XPath("//div[@class='form-wrapper']/table/tbody[last()]/tr[1]/td[1]"));

        //Wait for the AddNew button to be clickable
        public string Wait0 = "//div[@data-tab='second']/div/div[2]/div/table/thead/tr/th[3]/div";
        //Wait for the textbox to be clickable
        public string Wait1 = "//div[@data-tab='second']/div/div[2]/div/div/div[1]/input";
        //Wait for the text to exist
        public string Wait2 = "//div[@data-tab='second']//table/tbody/tr/td[1]";
        //Wait for Delete icon to be clickable
        public string Wait3 = "//div[@data-tab='second']//table/tbody/tr/td[3]/span[2]/i";       


        public void SkillsClick(string skill, string level)
        {
            SkillTab.Click();
            Wait.WaitToBeVisible(driver, "XPath", "Wait0", 5);
            SkillAddButton.Click();
            Wait.WaitToBeClickable(driver, "XPath", Wait1, 5);
        }
        public void SkillsSteps(string skill, string level)

        {
            //ADD Skills              
            
            SkillTextbox.SendKeys(skill);
            SelectElement SkillLevel = new SelectElement(driver.FindElement(By.Name("level")));
            SkillLevel.SelectByValue(level);            
        }
        public void SkillsAdd(string skill, string level)
        {
            SkillAdd.Click();
            Wait.WaitToExist(driver, "XPath", Wait2, 10);
            Thread.Sleep(3000);
        }
        public string GetSkill(string skill, string level)
        {            
            return newskill.Text;
        }
        public string GetSkillLevel(string skill, string level)
        {           
            return newSkillLevel.Text;
        }

        //UPDATE Skill
        public void UpdateSkillsClick()
        {
            SkillTab.Click();
            EditSkillIcon.Click();
        }
        public void UpdateSkills()
        {

            EditSkill.Clear();
            EditSkill.SendKeys("Dance");

            SelectElement EditSkillLevel = new SelectElement(driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td/div/div[2]/select")));
            EditSkillLevel.SelectByValue("Expert");
        }
        public void UpdateSkillsButton()
        {
            SkillUpdateButton.Click();
            Thread.Sleep(3000);
        }

        public string GetUpdatedSkill()
        {        
             return newUpdatedskill.Text;
        }
        public string GetUpdatedSkillLevel()
        {
            
            return newUpdatedSkillLevel.Text;
        }

        //DELETE SKILL
        public void DeleteSkills()

        {           
            SkillTab.Click();
            Wait.WaitToBeClickable(driver, "XPath", Wait3, 5);
            DeleteSkillIcon.Click();
            Thread.Sleep(3000);
        }

        //Validate Deleted Skill

        public string GetDeleteSkills()
        {                       
            return deletedSkill.Text;          
            
        }
    }
}
