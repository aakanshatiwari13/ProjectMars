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
        public void GoToSkillsPage(IWebDriver driver) 
        {
            //Navigate to skill page                          
            Thread.Sleep(2000);//*[@id="accoun]/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]
            IWebElement skillTab = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]"));
            skillTab.Click();
            Thread.Sleep(2000);
        }
    }
}
