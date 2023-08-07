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
        [Given(@"User is logged into localhost URL successful")]
        public void GivenUserIsLoggedIntoLocalhostURLSuccessful()
        {
           driver = new ChromeDriver();
           LoginPage loginPageObj = new LoginPage();
            loginPageObj.LoginSteps(driver);
        }

        [When(@"Add new '([^']*)' and '([^']*)' to the language list")]
        public void WhenAddNewAndToTheLanguageList(string language, string level)
        {
           // driver = new ChromeDriver();
            LanguagePage languagePageObj = new LanguagePage();
            languagePageObj.CreateLanguage(driver, language, level);
        }

        [Then(@"New record with '([^']*)' and '([^']*)' are added successfully")]
        public void ThenNewRecordWithAndAreAddedSuccessfully(string language, string level)
        {
            LanguagePage languagePageObj = new LanguagePage();

            string newLanguage = languagePageObj.GetLanguage(driver);
            string newLevel = languagePageObj.GetLevel(driver);
            Assert.AreEqual(language, newLanguage, "Actual and expected Language do not match. Language not added!");
            Assert.AreEqual(level, newLevel, "Actual and expected Language Level do not match. Language Level not added!");
            
        }
        [When(@"I update language '([^']*)' and level '([^']*)' of an existing record")]
        public void WhenIUpdateLanguageAndLevelOfAnExistingRecord(string language, string level)
        {
            LanguagePage languagePageObj = new LanguagePage();
            languagePageObj.EditLanguage(driver, language, level);
        }

        [Then(@"A language '([^']*)' updated successfully message should be displayed")]
        public void ThenALanguageUpdatedSuccessfullyMessageShouldBeDisplayed(string language)
        {
            LanguagePage languagePageObj = new LanguagePage();
            string updateMessage = language + " has been updated to your languages";
            string getMessage = languagePageObj.GetMessage(driver);
            Assert.AreEqual(updateMessage, getMessage, "Actual and expected Language do not match. Language not added!");
        }

        [When(@"I deleted language '([^']*)' of an existing record")]
        public void WhenIDeletedLanguageOfAnExistingRecord(string language)
        {
            LanguagePage languagePageObj = new LanguagePage();
            languagePageObj.DeleteLanguage(driver, language);

        }

        [Then(@"A language '([^']*)' deleted successfully message should be displayed")]
        public void ThenALanguageDeletedSuccessfullyMessageShouldBeDisplayed(string language)
        {
            LanguagePage languagePageObj = new LanguagePage();
            string deleteMessage = language + " has been deleted from your languages";
            string getMessage1 = languagePageObj.GetMessage1(driver);
            Assert.AreEqual(deleteMessage, getMessage1, "Actual and expected Language do not match. Language not deleted!");
        }



    }
}
