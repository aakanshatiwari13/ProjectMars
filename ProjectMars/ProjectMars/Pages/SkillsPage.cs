using OpenQA.Selenium;
using ProjectMars.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMars.Pages
{
    public class SkillsPage
    {
        public void CreateSkills(IWebDriver driver)
        {
            //click on AddNew button 
            IWebElement AddNew1 = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/thead/tr/th[3]/div"));
            AddNew1.Click();

            //add Skills
            IWebElement AddSkills = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[1]/input"));
            AddSkills.SendKeys("Painting");

            //choose language level 
            IWebElement ChooseLevel2 = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[2]/select"));
            ChooseLevel2.Click();

            IWebElement ChooseLevel3 = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[2]/select/option[4]"));
            ChooseLevel3.Click();

            //click on add button 
            IWebElement AddButton1 = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/span/input[1]"));
            AddButton1.Click();


            //click on AddNew button to add singing skills
            IWebElement AddNew2 = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/thead/tr/th[3]/div"));
            AddNew2.Click();

            //add Skills
            IWebElement AddSkills1 = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[1]/input"));
            AddSkills1.SendKeys("Singing");

            //choose language level 
            IWebElement ChooseLevel8 = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[2]/select"));
            ChooseLevel2.Click();

            IWebElement ChooseLevel9 = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[2]/select/option[4]"));
            ChooseLevel3.Click();

            //click on add button 
            IWebElement AddButton4 = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/span/input[1]"));
            AddButton4.Click();
        }


        // code to edit skills
        public void EditSkills(IWebDriver driver)
        {
            //click on edit button
            Wait.WaitToBeClickable(driver, "XPath", "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[3]/span[1]/i", 20);
            IWebElement ClickEdit1 = driver.FindElement(By.XPath("//*[@id=\'account-profile-section\']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[3]/span[1]/i"));
            ClickEdit1.Click();
            //Thread.Sleep(3000);

            //edit the skills
            IWebElement EditSkills = driver.FindElement(By.XPath("//*[@id=\'account-profile-section\']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td/div/div[1]/input"));
            EditSkills.Clear();
            Thread.Sleep(3000);
            EditSkills.SendKeys("Dancing");
            Thread.Sleep(3000);


            //choose skills level
            IWebElement ChooseLevel3 = driver.FindElement(By.XPath("//*[@id=\'account-profile-section\']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td/div/div[2]/select/option[3]"));
            ChooseLevel3.Click();

            //click to update button 
            IWebElement UpdateButton1 = driver.FindElement(By.XPath("//*[@id=\'account-profile-section\']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td/div/span/input[1]"));
            UpdateButton1.Click();
        }
        public void DeleteSkills(IWebDriver driver)
        {
            //code to delete skills       
            Wait.WaitToBeClickable(driver, "XPath", "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[3]/span[2]/i", 20);
            IWebElement DeleteSkills = driver.FindElement(By.XPath("//*[@id=\'account-profile-section\']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[3]/span[2]/i"));
            DeleteSkills.Click();
          //  Thread.Sleep(3000);
        }

    }
}
