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
        public SkillsPage(IWebDriver driver, LoginPage loginPageInstance)
        {
            this.driver = driver; // Initialize the driver in the base class          
        }
        IWebElement addNew => driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/thead/tr/th[3]/div"));
        IWebElement addSkills => driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[1]/input"));
        IWebElement addButton => driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/span/input[1]"));
        IWebElement thirdSkill => driver.FindElement(By.XPath("//*[@id=\'account-profile-section\']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[1]"));
        IWebElement lastEdit => driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[3]/tr[last()]/td[3]/span[1]/i"));
        IWebElement lastSkill => driver.FindElement(By.XPath("//input[@placeholder='Add Skill']"));
        IWebElement skillsLevelDropDown => driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[2]/select"));        
        IWebElement updateButton => driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[3]/tr/td/div/span/input[1]"));
        IWebElement getMessage => driver.FindElement(By.XPath("/html/body/div[1]/div"));        
        IWebElement chooseLevel => driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[3]/tr/td[2]"));
        IWebElement addNewCancel => driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/span/input[2]"));
        IWebElement firstEdit => driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[1]/tr/td[3]/span[1]/i"));
        IWebElement firstCancel => driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[1]/tr/td/div/span/input[2]"));
        IWebElement secondEdit => driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[2]/tr/td[3]/span[1]/i"));
        IWebElement secondCancel => driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[2]/tr/td/div/span/input[2]"));
        IWebElement thirdCancel => driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[3]/tr/td/div/span/input[2]"));
        IWebElement thirdEdit => driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[3]/tr/td[3]/span[1]/i"));
        IWebElement skillLevelDropDown => driver.FindElement(By.Name("level"));

        public void CreateSkills(IWebDriver driver, string skills, string level)
        {
            SkillsHomePage skillHomePageObj = new SkillsHomePage();
            skillHomePageObj.GoToSkillsPage(driver);
         
           //click on AddNew button
            Wait.WaitToBeClickable(driver, "XPath", "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/thead/tr/th[3]/div", 30);

            addNew.Click();

            //Add  first skill 
            addSkills.SendKeys(skills);
          
            //Choose level
            SelectElement select = new SelectElement(skillsLevelDropDown);
            select.SelectByText(level);

            //click on add button
            addButton.Click();
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
            SkillsHomePage skillHomePageObj = new SkillsHomePage();
            skillHomePageObj.GoToSkillsPage(driver);
            Thread.Sleep(2000);
            //click on edit button 
            Wait.WaitToBeClickable(driver, "XPath", "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[3]/tr/td[3]/span[1]/i", 20);

            //edit the skills                                   
            if (thirdSkill.Text == "C#")
            {
                Thread.Sleep(3000);
                lastEdit.Click();
                Thread.Sleep(2000);
                lastSkill.Clear();
                lastSkill.SendKeys(skills);
               
                SelectElement select = new SelectElement(skillLevelDropDown);
                select.SelectByText(level);
              
                updateButton.Click();
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
            return getMessage.Text;
        }

        public string GetSkill1(IWebDriver driver)
        {
            Thread.Sleep(2000);         
            return lastSkill.Text;
        }
        public string GetLevel1(IWebDriver driver)
        {
          
            return chooseLevel.Text;
        }

        public void DeleteSkills(IWebDriver driver, string skills)
        {
            SkillsHomePage skillHomePageObj = new SkillsHomePage();
            skillHomePageObj.GoToSkillsPage(driver);
            Thread.Sleep(2000);
            IWebElement DeleteSkill = driver.FindElement(By.XPath("//tbody[3]/tr/td[1][text()='" + skills + "']"));
           
            IWebElement DeleteSkill1 = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[3]/tr/td[3]/span[2]/i"));
            DeleteSkill1.Click();
            Thread.Sleep(2000);
        }
        public string GetMessage2(IWebDriver driver)
        {
            Thread.Sleep(2000);      
            return getMessage.Text;
        }

        public void CancelSkills(IWebDriver driver)
        {
            SkillsHomePage skillHomePageObj = new SkillsHomePage();
            skillHomePageObj.GoToSkillsPage(driver);
            Thread.Sleep(2000);
            Wait.WaitToBeClickable(driver, "XPath", "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/thead/tr/th[3]/div", 20);
            //click addnew button             
            addNew.Click();
            Thread.Sleep(2000);

            //click add new cancel      
            addNewCancel.Click();
            Thread.Sleep(1000);

            //click first edit button            
            firstEdit.Click();
            Thread.Sleep(1000);

            //click first cancel button         
            firstCancel.Click();
            Thread.Sleep(1000);

            //click secong edit button 
            secondEdit.Click();
            Thread.Sleep(1000);

            //click second cancel button 
            secondCancel.Click();
            Thread.Sleep(1000);

            //click third edit button 
            thirdEdit.Click();
            Thread.Sleep(1000);

            //click third cancel button 
            thirdCancel.Click();
            Thread.Sleep(1000);
        }
        public void CheckCancel(IWebDriver driver)
        {
            SkillsHomePage skillHomePageObj = new SkillsHomePage();
            skillHomePageObj.GoToSkillsPage(driver);
            Thread.Sleep(2000);
            Assert.That(chooseLevel.Text == "Expert", "Actual text and expected text do not match.");
        }


    }
}
