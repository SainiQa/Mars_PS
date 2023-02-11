using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Onboarding_UpdatedVersion1.Utilities
{
    public class CommonDriver
    {
        public static IWebDriver driver;
        public void Initialize()
        {
            driver = new ChromeDriver();
        }

        public static void ImpliWait()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(50);

        }

        public void Close()
        {
            driver.Quit();
           
        }
    }
}
