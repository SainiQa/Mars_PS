using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Onboarding.Utilities;


//namespace Mars_Profile_1.Utilities
namespace Onboarding.Utilities
{
    public  class CommonDriver
    {
        public static IWebDriver driver;

        public void Initialize()
        {
             driver = new ChromeDriver();
        }

        public static void UseWait()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

        }

        public void Close()
        {
            driver.Quit();
        }
    }
}
