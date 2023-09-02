using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using ProjectMars.Pages;
using ProjectMars.Utilities;
using System;
using System.Reflection.Emit;
using TechTalk.SpecFlow;
using static System.Net.Mime.MediaTypeNames;

namespace ProjectMars.StepDefinitions
{
    [Binding]
    public class LanguageFeatureStepDefinitions : CommonDriver
    {
        public LanguagePage languagePageObj;

        [Given(@"User is logged into localhost URL for Language successful")]
        public void GivenUserIsLoggedIntoLocalhostURLForLanguageSuccessful()
        {
            driver = new ChromeDriver();
            LoginPage loginPageObj = new LoginPage();
            loginPageObj.LoginSteps(driver);
            // Initialize languagePageObj
            languagePageObj = new LanguagePage(driver, loginPageObj);
        }

        [When(@"Add new '([^']*)' and '([^']*)' to the language list")]
        public void WhenAddNewAndToTheLanguageList(string language, string level)
        {
            languagePageObj.CreateLanguage(driver, language, level);
        }

        [Then(@"New record for Language with '([^']*)' and '([^']*)' are added successfully")]
        public void ThenNewRecordForLanguageWithAndAreAddedSuccessfully(string language, string level)
        {          
            string newLanguage = languagePageObj.GetLanguage(driver);
            string newLevel = languagePageObj.GetLevel(driver);
            Assert.AreEqual(language, newLanguage, "Actual and expected Language do not match. Language not added!");
            Assert.AreEqual(level, newLevel, "Actual and expected Language Level do not match. Language Level not added!");
        }

        [When(@"I update language '([^']*)' and level '([^']*)' of an existing record")]
        public void WhenIUpdateLanguageAndLevelOfAnExistingRecord(string language, string level)
        {           
            languagePageObj.EditLanguage(driver, language, level);
        }

        [Then(@"A language '([^']*)' updated successfully message should be displayed")]
        public void ThenALanguageUpdatedSuccessfullyMessageShouldBeDisplayed(string language)
        {            
            string updateMessage = language + " has been updated to your languages";
            string getMessage = languagePageObj.GetMessage(driver);
            Assert.AreEqual(updateMessage, getMessage, "Actual and expected Language do not match. Language not added!");
        }

        [When(@"I deleted language '([^']*)' of an existing record")]
        public void WhenIDeletedLanguageOfAnExistingRecord(string language)
        {            
            languagePageObj.DeleteLanguage(driver, language);

        }

        [Then(@"A language '([^']*)' deleted successfully message should be displayed")]
        public void ThenALanguageDeletedSuccessfullyMessageShouldBeDisplayed(string language)
        {
            string deleteMessage = language + " has been deleted from your languages";
            string getMessage1 = languagePageObj.GetMessage1(driver);
            Assert.AreEqual(deleteMessage, getMessage1, "Actual and expected Language do not match. Language not deleted!");
        }

        [When(@"Check cancel button for Language of the records")]
        public void WhenCheckCancelButtonForLanguageOfTheRecords()
        {           
            languagePageObj.CancelLanguage(driver);
        }
        [Then(@"Cancel function for Language is working successfully")]
        public void ThenCancelFunctionForLanguageIsWorkingSuccessfully()
        {         
            languagePageObj.CheckCancel(driver);
        }

        [When(@"Add new record '([^']*)' and '([^']*)' to the language list")]
        public void WhenAddNewRecordAndToTheLanguageList(string language, string level)
        {         
            languagePageObj.CreateLanguage(driver, language, level);
        }
        [Then(@"Record '([^']*)' and '([^']*)' are added successfully")]
        public void ThenRecordAndAreAddedSuccessfully(string language, string level)
        {       
            string newLanguage = languagePageObj.GetLanguage(driver);
            string newLevel = languagePageObj.GetLevel(driver);
            Assert.AreEqual(language, newLanguage, "Actual and expected Language do not match. Language not added!");
            Assert.AreEqual(level, newLevel, "Actual and expected Language Level do not match. Language Level not added!");
        }

    }
}