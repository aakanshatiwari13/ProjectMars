using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using ProjectMars.Utilities;
using TechTalk.SpecFlow;

namespace ProjectMars.Pages
{
    public class LanguagePage : CommonDriver

    {
        //private IWebElement FindElementByXPath(string xpath) => driver.FindElement(By.XPath(xpath));
        //private IWebElement AddNew => FindElementByXPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div");
        //private IWebElement Addlanguage => FindElementByXPath("//input[@placeholder='Add Language']");
        //private IWebElement LanguageLevelDropDown => driver.FindElement(By.Name("level"));
        //// private IWebElement ChooseLevel1 => driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select/option[3]"));
        //// this one is conversational
        //private IWebElement AddButton => FindElementByXPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[1]");


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
            //IWebElement ChooseLevel = driver.FindElement(By.Name("level"));
            //ChooseLevel.Click();
            IWebElement LanguageLevelDropDown = driver.FindElement(By.Name("level"));
            SelectElement select = new SelectElement(LanguageLevelDropDown);
            select.SelectByText(level);

            //IWebElement ChooseLevel1 = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select/option[3]"));
            // ChooseLevel1.Click();

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
            //click on edit button //*[@id="account-profile-section"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[4]/tr/td[3]/span[1]/i
            Wait.WaitToBeClickable(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[3]/tr/td[3]/span[1]/i", 20);

            // IWebElement ClickEdit = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[4]/tr[last()]/td[3]/span[1]/i"));
            //ClickEdit.Click();
            //Thread.Sleep(2000);

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
                // IWebElement ChooseLevel2 = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[4]/tr/td/div/div[2]/select/option[3]"));
                //ChooseLevel2.Click();
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
            //    IWebElement LastLanguage1 = driver.FindElement(By.XPath("//input[@placeholder='Add Language']"));
            //    LastLanguage1.Clear();
            //    LastLanguage1.SendKeys("Hindi");
            //    IWebElement ChooseLevel2 = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[4]/tr/td/div/div[2]/select/option[3]"));
            //    ChooseLevel2.Click();
            //    IWebElement UpdateButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[4]/tr/td/div/span/input[1]"));
            //    Thread.Sleep(3000);
            //}
            //public void DeleteLanguage(IWebDriver driver)
            //{
            //    //code to deletelanguage
            //    Wait.WaitToBeClickable(driver, "XPath", "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[3]/span[2]/i", 20);
            //    IWebElement DeleteLanguage = driver.FindElement(By.XPath("//*[@id=\'account-profile-section\']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[3]/span[2]/i"));
            //    DeleteLanguage.Click();

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
            //*[@id="account-profile-section"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[3]/tr/td[3]/span[2]/i
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
        public string GetMessage2(IWebDriver driver)
        {
            Thread.Sleep(2000);
            string input = "Aakansha Tiwari";
            string replaced = input.Replace(" ", " ");
            return Replaced.Text;
        }
    }
    
}

string input = "Aakansha Tiwari";
string replaced = input.Replace(" ", "_");
Console.WriteLine(replaced); // Output: "Aakansha_Tiwari"
Splitting the String: