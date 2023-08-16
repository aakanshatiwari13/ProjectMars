using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using ProjectMars.Utilities;
using TechTalk.SpecFlow;

namespace ProjectMars.Pages
{
    public class LanguagePage : CommonDriver

    {

        public void CreateLanguage(IWebDriver driver, string language, string level)
        {

            Wait.WaitToBeClickable(driver, "XPath", "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div", 20);


            //click on AddNew button for english
            IWebElement AddNew = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div"));
            AddNew.Click();

            //add first language english language
            IWebElement Addlanguage = driver.FindElement(By.XPath("//input[@placeholder='Add Language']"));
            Addlanguage.SendKeys(language);

            //choose language level 
            IWebElement LanguageLevelDropDown = driver.FindElement(By.Name("level"));
            SelectElement select = new SelectElement(LanguageLevelDropDown);
            select.SelectByText(level);            

            //click on add button 
            IWebElement AddButton = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[1]"));
            AddButton.Click();
            Thread.Sleep(2000);
        }

        public string GetLanguage(IWebDriver driver)
        {
            Thread.Sleep(2000);
            IWebElement LastLanguage = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[1]"));
            return LastLanguage.Text;
        }
        public string GetLevel(IWebDriver driver)
        {
            IWebElement ChooseLevel = driver.FindElement(By.XPath("//*[@id=\'account-profile-section\']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[2]"));
            return ChooseLevel.Text;
        }

        //code for edit language    
        public void EditLanguage(IWebDriver driver, string language, string level)
        {
            Thread.Sleep(2000);
            //click on edit button 
            Wait.WaitToBeClickable(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[3]/tr/td[3]/span[1]/i", 20);

            //edit the language                                   
            IWebElement LastLanguage = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[1]"));
            if (LastLanguage.Text == "Hindi")
            {
                Thread.Sleep(3000);
                IWebElement ClickEdit = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[4]/tr[last()]/td[3]/span[1]/i"));
                ClickEdit.Click();
                Thread.Sleep(2000);
                IWebElement LastLanguage1 = driver.FindElement(By.XPath("//input[@placeholder='Add Language']"));
                LastLanguage1.Clear();
                LastLanguage1.SendKeys(language);
                IWebElement LanguageLevelDropDown1 = driver.FindElement(By.Name("level"));
                SelectElement select = new SelectElement(LanguageLevelDropDown1);
                select.SelectByText(level);
                IWebElement UpdateButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[4]/tr/td/div/span/input[1]"));
                UpdateButton.Click();
                Thread.Sleep(3000);
            }
            else
            {
                Assert.Fail("New language created hasn't been found");
            }

        }
        public string GetMessage(IWebDriver driver)
        {
            Thread.Sleep(2000);
            IWebElement getMessage = driver.FindElement(By.XPath("/html/body/div[1]/div"));
            return getMessage.Text;
        }

        public string GetLanguage1(IWebDriver driver)
        {
            Thread.Sleep(2000);
            IWebElement LastLanguage = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[1]"));
            return LastLanguage.Text;
        }
        public string GetLevel1(IWebDriver driver)
        {
            IWebElement ChooseLevel = driver.FindElement(By.XPath("//*[@id=\'account-profile-section\']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[2]"));
            return ChooseLevel.Text;
        }

        public void DeleteLanguage(IWebDriver driver, string language)
        {
           Thread.Sleep(2000);
           IWebElement DeleteLanguage = driver.FindElement(By.XPath("//tbody[3]/tr/td[1][text()='" + language + "']"));
            IWebElement DeleteLanguage1 = driver.FindElement(By.XPath(" //*[@id=\'account-profile-section\']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[3]/tr/td[3]/span[2]/i"));
            DeleteLanguage1.Click();
            Thread.Sleep(2000);
        }
        public string GetMessage1(IWebDriver driver)
        {
            Thread.Sleep(2000);
            IWebElement getMessage1 = driver.FindElement(By.XPath("/html/body/div[1]/div"));
            return getMessage1.Text;
        }

        public void CancelLanguage(IWebDriver driver)
        {
            HomePage languageHomePageObj = new HomePage();
            languageHomePageObj.GoToLanguagePage(driver);
            Thread.Sleep(2000);
            Wait.WaitToBeClickable(driver, "XPath", "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div", 20);
            //click addnew button 
            IWebElement AddNew1 = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div"));
            AddNew1.Click();
            Thread.Sleep(2000);

            //click add new cancel 
            IWebElement AddNewCancel = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[2]"));
            AddNewCancel.Click();
            Thread.Sleep(1000);

            //click first edit button 
            IWebElement Edit1 = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[1]/tr/td[3]/span[1]/i"));
            Edit1.Click();
            Thread.Sleep(1000);

            //click first cancel button 
            IWebElement Cancel1 = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[1]/tr/td/div/span/input[2]"));
            Cancel1.Click();
            Thread.Sleep(1000);

            //click secong edit button 
            IWebElement Edit2 = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[2]/tr/td[3]/span[1]/i"));
            Edit2.Click();
            Thread.Sleep(1000);

            //click second cancel button 
            IWebElement Cancel2 = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[2]/tr/td/div/span/input[2]"));
            Cancel2.Click();
            Thread.Sleep(1000);

            //click third edit button 
            IWebElement Edit3 = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[3]/tr/td[3]/span[1]/i"));
            Edit3.Click();
            Thread.Sleep(1000);

            //click third cancel button 
            IWebElement Cancel3 = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[3]/tr/td/div/span/input[2]"));
            Cancel3.Click();
            Thread.Sleep(1000);
        }

        public void CheckCancel(IWebDriver driver)
        {
            HomePage languageHomePageObj = new HomePage();
            languageHomePageObj.GoToLanguagePage(driver);
            Thread.Sleep(2000);
            IWebElement LastCancel = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[3]/tr/td[2]"));
            Assert.That(LastCancel.Text == "Fluent", "Actual text and expected text do not match.");
        }
    }
}

