using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMars.Pages
{
    public class HomePage
    {
        public void GoToLanguagePage(IWebDriver driver) 
        {
            ////Navigate to language                                 
           Thread.Sleep(2000);
           IWebElement languageTab = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[1]"));
           languageTab.Click();
         
        }
        public void GoToSkillsPage(IWebDriver driver)
        {
            //Navigate to Skills
            IWebElement skillsTab = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]"));
            skillsTab.Click();
           
        }
      
    }
}
