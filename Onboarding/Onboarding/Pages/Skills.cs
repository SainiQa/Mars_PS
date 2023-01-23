using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Onboarding.Utilities;
using NUnit.Framework;

//namespace Mars_Profile_1.Pages

namespace Onboarding.Pages
{
    public class Skills
    {
        public void SkillsSteps(IWebDriver driver,string skill, string level)
            
            {
            //ADD Skills
            Thread.Sleep(3000);
            IWebElement SkillTab = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]"));
            SkillTab.Click();

            IWebElement SkillAddButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/thead/tr/th[3]/div"));
            SkillAddButton.Click();

            Wait.WaitToBeClickable(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[1]/input", 5);

            IWebElement SkillTextbox = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[1]/input"));
            SkillTextbox.SendKeys(skill);

            SelectElement SkillLevel = new SelectElement(driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[2]/select")));
            SkillLevel.SelectByValue(level);
            Thread.Sleep(2000);
            IWebElement SkillAdd = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/span/input[1]"));
            SkillAdd.Click();
            Wait.WaitToExist(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[1]", 5);

        }
        //Validate Skill

        public void GetSkills(IWebDriver driver)

        {
            IWebElement SkillTab = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]"));
            SkillTab.Click();
            IWebElement addedSkill = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[1]"));
            IWebElement addedSkillLevel = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[2]"));

            Assert.That(addedSkill.Text == "Crochet", "Opps! The skill is not added");
            Assert.That(addedSkillLevel.Text == "Expert", "Opps! The skill level is not added");
        }

    

    //UPDATE Skill
    public void UpdateSkills(IWebDriver driver)
    {

            //Thread.Sleep(3000);
            IWebElement SkillTab = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]"));
            SkillTab.Click();

            IWebElement EditSkillIcon = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[3]/span[1]/i"));
        EditSkillIcon.Click();
            

            IWebElement EditSkill = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td/div/div[1]/input"));
        EditSkill.Clear();   
            EditSkill.SendKeys("Dance");

        SelectElement EditSkillLevel = new SelectElement(driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td/div/div[2]/select")));
        EditSkillLevel.SelectByValue("Expert");
            Thread.Sleep(2000); 

        IWebElement SkillUpdateButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td/div/span/input[1]")); ;
        SkillUpdateButton.Click();
        //Wait for Delete Icon to be clikable
        Wait.WaitToBeClickable(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[3]/span[2]/i", 5);
    }

        //Validate UPdated Skill

        public void GetUpdateSkills(IWebDriver driver)
        {
            //Thread.Sleep(3000);
            IWebElement SkillTab = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]"));
            SkillTab.Click();
            IWebElement updatedSkill = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[1]"));
            IWebElement updatedLevel = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[2]"));

            Assert.That(updatedSkill.Text == "Dance", "Opps! The skill is not Updated");
            Assert.That(updatedLevel.Text == "Expert", "Opps! The skill level is not Updated");
        }

        //DELETE SKILL
        public void DeleteSkills(IWebDriver driver)

        {

            Thread.Sleep(2000);
            IWebElement SkillTab = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]"));
            SkillTab.Click();
            IWebElement DeleteSkillIcon = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[3]/span[2]/i"));
            DeleteSkillIcon.Click();
        }

        //Validate Deleted Skill

        public void GetDeleteSkills(IWebDriver driver)
        {
            IWebElement SkillTab = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]"));
            SkillTab.Click();
            IWebElement deletedSkill = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[1]"));
            IWebElement deletedLevel = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[2]"));

            Assert.That(deletedSkill.Text != "Dance", "Opps! The skill is not deleted");
            Assert.That(deletedLevel.Text != "Expert", "Opps! The skill level is not deleted");
        }


    }
}
