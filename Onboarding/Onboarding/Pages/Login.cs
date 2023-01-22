using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Onboarding.Utilities;

//namespace Mars_Profile_1.Pages
namespace Onboarding.Pages
{
    //public class Login : CommonDriver
        public class Login 
    {
        
        //Method to Login
        public void LoginSteps(IWebDriver driver)
        {
                    
            driver.Navigate().GoToUrl("http://localhost:5000/");
            driver.Manage().Window.Maximize();

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60);

            //Login
            IWebElement SignInButton = driver.FindElement(By.XPath("//*[@id=\"home\"]/div/div/div[1]/div/a"));
            SignInButton.Click();
            IWebElement UserNameTextbox = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[1]/input"));
            UserNameTextbox.SendKeys("poojasaini31@gmail.com");
            IWebElement PasswordTextbox = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[2]/input"));
            PasswordTextbox.SendKeys("Testing");
            Thread.Sleep(2000);
            IWebElement LoginButton = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[4]/button"));
            LoginButton.Click();
            Thread.Sleep(5000);
        }

    }
}
