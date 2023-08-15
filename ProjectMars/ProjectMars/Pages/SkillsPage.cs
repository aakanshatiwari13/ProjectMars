using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using ProjectMars.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMars.Pages
{
    public class SkillsPage : CommonDriver
    {
        public void CreateSkills(IWebDriver driver, string skills, string level)
        {
            HomePage skillHomePageObj = new HomePage();
            skillHomePageObj.GoToSkillsPage(driver);
            //IWebElement skillTab = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]"));
            //skillTab.Click();
            

            //click on AddNew button
            Wait.WaitToBeClickable(driver, "XPath", "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/thead/tr/th[3]/div", 30);

            IWebElement AddNew = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/thead/tr/th[3]/div"));
            AddNew.Click();

            //add  first skill 
            IWebElement AddSkills = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[1]/input"));
            AddSkills.SendKeys(skills);

            //choose skill level 
            //IWebElement ChooseLevel = driver.FindElement(By.Name("level"));
            //ChooseLevel.Click();
            IWebElement SkillsLevelDropDown = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[2]/select"));
            SelectElement select = new SelectElement(SkillsLevelDropDown);
            select.SelectByText(level);

            //click on add button 
            IWebElement AddButton = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/span/input[1]"));
            AddButton.Click();
            Thread.Sleep(2000);           
        }
        public string GetSkills(IWebDriver driver)
        {
            Thread.Sleep(2000);
            IWebElement LastSkill = driver.FindElement(By.XPath("//*[@id=\'account-profile-section\']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[1]"));
            return LastSkill.Text;
        }
        public string GetLevel(IWebDriver driver)
        {
            IWebElement ChooseLevel = driver.FindElement(By.XPath("//*[@id=\'account-profile-section\']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[2]"));
            return ChooseLevel.Text;
        }
        public void EditSkills(IWebDriver driver, string skills, string level)
        {
            HomePage skillHomePageObj = new HomePage();
            skillHomePageObj.GoToSkillsPage(driver);
            Thread.Sleep(2000);
            //click on edit button //*[@id="account-profile-section"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[4]/tr/td[3]/span[1]/i
            Wait.WaitToBeClickable(driver, "XPath", "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[3]/tr/td[3]/span[1]/i", 20);

            //edit the skills                                   
            IWebElement LastSkill = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[3]/tr/td[1]"));
            if (LastSkill.Text == "C#")
            {
                Thread.Sleep(3000);
                IWebElement ClickEdit = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[3]/tr[last()]/td[3]/span[1]/i"));
                ClickEdit.Click();
                Thread.Sleep(2000);
                IWebElement LastSkill1 = driver.FindElement(By.XPath("//input[@placeholder='Add Skill']"));
                LastSkill1.Clear();
                LastSkill1.SendKeys(skills);
                // IWebElement ChooseLevel2 = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[4]/tr/td/div/div[2]/select/option[3]"));
                //ChooseLevel2.Click();
                IWebElement SkillsLevelDropDown1 = driver.FindElement(By.Name("level"));
                SelectElement select = new SelectElement(SkillsLevelDropDown1);
                select.SelectByText(level);
                IWebElement UpdateButton = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[3]/tr/td/div/span/input[1]"));
                UpdateButton.Click();
                Thread.Sleep(3000);
            }
            else
            {
                Assert.Fail("New skill created hasn't been found");
            }        

        }
        public string GetMessage(IWebDriver driver)
        {
            Thread.Sleep(2000);
            IWebElement getMessage = driver.FindElement(By.XPath("/html/body/div[1]/div"));
            return getMessage.Text;
        }

        public string GetSkill1(IWebDriver driver)
        {
            Thread.Sleep(2000);
            IWebElement LastSkill = driver.FindElement(By.XPath("//*[@id=\'account-profile-section\']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[3]/tr/td[1]"));
            return LastSkill.Text;
        }
        public string GetLevel1(IWebDriver driver)
        {
            IWebElement ChooseLevel = driver.FindElement(By.XPath("//*[@id=\'account-profile-section\']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[3]/tr/td[2]"));
            return ChooseLevel.Text;
        }

        public void DeleteSkills(IWebDriver driver, string skills)
        {
            HomePage skillHomePageObj = new HomePage();
            skillHomePageObj.GoToSkillsPage(driver);
            Thread.Sleep(2000);
            IWebElement DeleteSkill = driver.FindElement(By.XPath("//tbody[3]/tr/td[1][text()='" + skills + "']"));
            //*[@id="account-profile-section"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[3]/tr/td[3]/span[2]/i
            IWebElement DeleteSkill1 = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[3]/tr/td[3]/span[2]/i"));
            DeleteSkill1.Click();
            Thread.Sleep(2000);
        }
        public string GetMessage2(IWebDriver driver)
        {
            Thread.Sleep(2000);
            IWebElement getMessage1 = driver.FindElement(By.XPath("/html/body/div[1]/div"));
            return getMessage1.Text;
        }

        public void CancelSkills(IWebDriver driver)
        {
            HomePage skillHomePageObj = new HomePage();
            skillHomePageObj.GoToSkillsPage(driver);
            Thread.Sleep(2000);
            Wait.WaitToBeClickable(driver, "XPath", "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/thead/tr/th[3]/div", 20);
            //click addnew button 
            IWebElement AddNew1 = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/thead/tr/th[3]/div"));
            AddNew1.Click();
            Thread.Sleep(2000);

            //click add new cancel 
            IWebElement AddNewCancel = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/span/input[2]"));
            AddNewCancel.Click();
            Thread.Sleep(1000);

            //click first edit button 
            IWebElement Edit1 = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[1]/tr/td[3]/span[1]/i"));
            Edit1.Click();
            Thread.Sleep(1000);

            //click first cancel button 
            IWebElement Cancel1 = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[1]/tr/td/div/span/input[2]"));
            Cancel1.Click();
            Thread.Sleep(1000);

            //click secong edit button 
            IWebElement Edit2 = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[2]/tr/td[3]/span[1]/i"));
            Edit2.Click();
            Thread.Sleep(1000);

            //click second cancel button 
            IWebElement Cancel2 = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[2]/tr/td/div/span/input[2]"));
            Cancel2.Click();
            Thread.Sleep(1000);

            //click third edit button 
            IWebElement Edit3 = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[3]/tr/td[3]/span[1]/i"));
            Edit3.Click();
            Thread.Sleep(1000);

            //click third cancel button 
            IWebElement Cancel3 = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[3]/tr/td/div/span/input[2]"));
            Cancel3.Click();
            Thread.Sleep(1000);
        }

        public void CheckCancel(IWebDriver driver)
        {
            HomePage skillHomePageObj = new HomePage();
            skillHomePageObj.GoToSkillsPage(driver);
            Thread.Sleep(2000);
            IWebElement LastCancel = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[3]/tr/td[2]"));
            Assert.That(LastCancel.Text == "Expert", "Actual text and expected text do not match.");
        }


    }
}
