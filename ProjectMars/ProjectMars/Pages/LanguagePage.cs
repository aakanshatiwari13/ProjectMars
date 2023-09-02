using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using ProjectMars.Utilities;
using TechTalk.SpecFlow;

namespace ProjectMars.Pages
{
    public class LanguagePage : CommonDriver

    {
        public LanguagePage(IWebDriver driver, LoginPage loginPageInstance)
        {
            this.driver = driver; // Initialize the driver in the base class          
        }

         IWebElement addNew => driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div"));
         IWebElement addlanguage => driver.FindElement(By.XPath("//input[@placeholder='Add Language']"));
         IWebElement addButton => driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[1]"));
         IWebElement fourthLanguage => driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[1]"));
         IWebElement chooseLevel => driver.FindElement(By.XPath("//*[@id=\'account-profile-section\']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[2]"));
         IWebElement deleteLanguage => driver.FindElement(By.XPath(" //*[@id=\'account-profile-section\']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[3]/tr/td[3]/span[2]/i"));
         IWebElement addNewCancel => driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[2]"));
         IWebElement firstEdit => driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[1]/tr/td[3]/span[1]/i"));
         IWebElement firstCancel => driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[1]/tr/td/div/span/input[2]"));
         IWebElement secondEdit => driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[2]/tr/td[3]/span[1]/i"));
         IWebElement secondCancel => driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[2]/tr/td/div/span/input[2]"));
         IWebElement thirdEdit => driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[3]/tr/td[3]/span[1]/i"));
         IWebElement thirdCancel => driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[3]/tr/td/div/span/input[2]"));
         IWebElement clickEdit => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[4]/tr[last()]/td[3]/span[1]/i"));
         IWebElement lastLanguage => driver.FindElement(By.XPath("//input[@placeholder='Add Language']"));
         IWebElement languageLevelDropDown1 => driver.FindElement(By.Name("level"));
         IWebElement updateButton => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[4]/tr/td/div/span/input[1]"));
         IWebElement getMessage => driver.FindElement(By.XPath("/html/body/div[1]/div"));
         IWebElement lastCancel => driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[3]/tr/td[2]"));


        public void CreateLanguage(IWebDriver driver, string language, string level)
        {

            Wait.WaitToBeClickable(driver, "XPath", "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div", 20);
            addNew.Click();

            //Add  language
            addlanguage.SendKeys(language);

            //choose language level 
            IWebElement languageLevelDropDown = driver.FindElement(By.Name("level"));
            SelectElement select = new SelectElement(languageLevelDropDown);
            select.SelectByText(level);

            //click on add button             
            addButton.Click();
            Thread.Sleep(2000);
        }

        public string GetLanguage(IWebDriver driver)
        {
            Thread.Sleep(3000);
            return fourthLanguage.Text;
        }
        public string GetLevel(IWebDriver driver)
        {
            return chooseLevel.Text;
        }

        //code for edit language    
        public void EditLanguage(IWebDriver driver, string language, string level)
        {
            Thread.Sleep(2000);
            //click on edit button 
            Wait.WaitToBeClickable(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[3]/tr/td[3]/span[1]/i", 20);

            //Edit the language                                   
        
            if (fourthLanguage.Text == "Hindi")
            {
                Thread.Sleep(3000);               
                clickEdit.Click();
                Thread.Sleep(2000);
              
                lastLanguage.Clear();
                lastLanguage.SendKeys(language);
              
                SelectElement select = new SelectElement(languageLevelDropDown1);
                select.SelectByText(level);
                //IWebElement UpdateButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[4]/tr/td/div/span/input[1]"));
                updateButton.Click();
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
            return getMessage.Text;
        }

        public string GetLanguage1(IWebDriver driver)
        {
            Thread.Sleep(2000);
            return fourthLanguage.Text;
        }
        public string GetLevel1(IWebDriver driver)
        {
            return chooseLevel.Text;
        }

        public void DeleteLanguage(IWebDriver driver, string language)
        {
            Thread.Sleep(2000);
            //IWebElement DeleteLanguage = driver.FindElement(By.XPath("//tbody[3]/tr/td[1][text()='" + language + "']"));
            deleteLanguage.Click();
            Thread.Sleep(2000);
        }
        public string GetMessage1(IWebDriver driver)
        {
            Thread.Sleep(2000);
            return getMessage.Text;
        }

        public void CancelLanguage(IWebDriver driver)
        {
            HomePage languageHomePageObj = new HomePage();
            languageHomePageObj.GoToLanguagePage(driver);
            Thread.Sleep(2000);
            Wait.WaitToBeClickable(driver, "XPath", "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div", 20);
            addNew.Click();
            Thread.Sleep(2000);

            //click add new cancel
            addNewCancel.Click();
            Thread.Sleep(1000);

            //click edit button 
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
            HomePage languageHomePageObj = new HomePage();
            languageHomePageObj.GoToLanguagePage(driver);
            Thread.Sleep(2000);
            Assert.That(lastCancel.Text == "Fluent", "Actual text and expected text do not match.");
        }
    }
}