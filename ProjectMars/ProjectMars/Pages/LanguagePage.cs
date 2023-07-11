using OpenQA.Selenium;
using ProjectMars.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMars.Pages
{
    public class LanguagePage
    {
        public void CreateLanguage(IWebDriver driver)
        {
            //click on AddNew button
            Wait.WaitToBeClickable(driver, "XPath", "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div", 20);
             
            IWebElement AddNew = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div"));
            AddNew.Click();

            //add  english language
            IWebElement Addlanguage = driver.FindElement(By.XPath("//input[@placeholder='Add Language']"));
            Addlanguage.SendKeys("English");

            //choose language level 
            IWebElement ChooseLevel = driver.FindElement(By.Name("level"));
            ChooseLevel.Click();

            IWebElement ChooseLevel1 = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select/option[3]"));
            ChooseLevel1.Click();

            //click on add button 
            IWebElement AddButton = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[1]"));
            AddButton.Click();

            //click on AddNew button and add hindi language
            //IWebElement AddNew1 = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div"));
           //AddNew1.Click();

             //add  hindi language

        }
        //code for edit language    
        public void EditLanguage(IWebDriver driver)
        {
            //click on edit button 
            Wait.WaitToBeClickable(driver, "XPath", "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[3]/span[1]/i", 20);
            IWebElement ClickEdit = driver.FindElement(By.XPath("//*[@id=\'account-profile-section\']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[3]/span[1]/i"));
            ClickEdit.Click();
            //Thread.Sleep(3000);

            //edit the language 
            IWebElement EditLanguage = driver.FindElement(By.XPath("//*[@id=\'account-profile-section\']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td/div/div[1]/input"));
            EditLanguage.Clear();
            //Thread.Sleep(3000);
            EditLanguage.SendKeys("Hindi");
            //Thread.Sleep(3000);

            //choose language level
            IWebElement ChooseLevel2 = driver.FindElement(By.XPath("//*[@id=\'account-profile-section\']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td/div/div[2]/select/option[4]"));
            ChooseLevel2.Click();

            //click to update button 
            IWebElement UpdateButton = driver.FindElement(By.XPath("//*[@id=\'account-profile-section\']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td/div/span/input[1]"));
            UpdateButton.Click();
        }
        public void DeleteLanguage(IWebDriver driver) 
        {
            //code to deletelanguage
            Wait.WaitToBeClickable(driver, "XPath", "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[3]/span[2]/i", 20);
            IWebElement DeleteLanguage = driver.FindElement(By.XPath("//*[@id=\'account-profile-section\']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[3]/span[2]/i"));
            DeleteLanguage.Click();
           // Thread.Sleep(3000);
        }
    }
}
