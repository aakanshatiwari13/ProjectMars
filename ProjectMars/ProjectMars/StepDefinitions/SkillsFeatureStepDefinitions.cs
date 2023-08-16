using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using ProjectMars.Pages;
using ProjectMars.Utilities;
using System;
using System.Reflection.Emit;
using TechTalk.SpecFlow;


namespace ProjectMars.StepDefinitions
{
    [Binding]
    public class SkillsFeatureStepDefinitions : CommonDriver
    {
        [Given(@"User is logged into localhost URL successful")]
        public void GivenUserIsLoggedIntoLocalhostURLSuccessful()
        {
           driver = new ChromeDriver();
           SkillsLoginPage skillsloginPageObj = new SkillsLoginPage();
           skillsloginPageObj.LoginSteps(driver);

        }

        [When(@"Add new '([^']*)' and '([^']*)' to the skills list")]
        public void WhenAddNewAndToTheSkillsList(string skills, string level)
        {
            // driver = new ChromeDriver();
            SkillsPage skillsPageObj = new SkillsPage();
            skillsPageObj.CreateSkills(driver, skills, level);
        }


        [Then(@"New record with '([^']*)' and '([^']*)' are added successfully")]
        public void ThenNewRecordWithAndAreAddedSuccessfully(string skills, string level)
        {
            SkillsPage skillsPageObj = new SkillsPage();

            string newSkills = skillsPageObj.GetSkills(driver);
            string newLevel = skillsPageObj.GetLevel(driver);
            Assert.AreEqual(skills, newSkills, "Actual and expected Language do not match. Language not added!");
            Assert.AreEqual(level, newLevel, "Actual and expected Language Level do not match. Language Level not added!");
        }

        [When(@"I update skills '([^']*)' and level '([^']*)' of an existing record")]
        public void WhenIUpdateSkillsAndLevelOfAnExistingRecord(string skills, string level)
        {
            SkillsPage skillsPageObj = new SkillsPage();
            skillsPageObj.EditSkills(driver, skills, level);
        }

        [Then(@"A skills '([^']*)' updated successfully message should be displayed")]
        public void ThenASkillsUpdatedSuccessfullyMessageShouldBeDisplayed(string skills)
        {
            SkillsPage skillsPageObj = new SkillsPage();
            string updateMessage = skills + " has been updated to your skills";
            string getMessage = skillsPageObj.GetMessage(driver);
            Assert.AreEqual(updateMessage, getMessage, "Actual and expected skill do not match. Skill not added!");
        }

        [When(@"I deleted skill '([^']*)' of an existing record")]
        public void WhenIDeletedSkillOfAnExistingRecord(string skills)
        {
            SkillsPage skillsPageObj = new SkillsPage();
            skillsPageObj.DeleteSkills(driver, skills);
        }

        [Then(@"A skill '([^']*)' deleted successfully message should be displayed")]
        public void ThenASkillDeletedSuccessfullyMessageShouldBeDisplayed(string skills)
        {
            SkillsPage skillsPageObj = new SkillsPage();
            string deleteMessage = skills + " has been deleted";
            string getMessage1 = skillsPageObj.GetMessage2(driver);
            Assert.AreEqual(deleteMessage, getMessage1, "Actual and expected skill do not match. skill not deleted!");
        }

        [When(@"Add new record '([^']*)' and '([^']*)' to the skills list")]
        public void WhenAddNewRecordAndToTheSkillsList(string skills, string level)
        {
            SkillsPage skillsPageObj = new SkillsPage();
            skillsPageObj.CreateSkills(driver, skills, level);
        }

        [Then(@"Record with '([^']*)' and '([^']*)' are added successfully")]
        public void ThenRecordWithAndAreAddedSuccessfully(string skills, string level)
        {
            SkillsPage skillsPageObj = new SkillsPage();

            string newSkills = skillsPageObj.GetSkills(driver);
            string newLevel = skillsPageObj.GetLevel(driver);
            Assert.AreEqual(skills, newSkills, "Actual and expected Language do not match. Language not added!");
            Assert.AreEqual(level, newLevel, "Actual and expected Language Level do not match. Language Level not added!");
        }

        [When(@"Check cancel button of the records")]
        public void WhenCheckCancelButtonOfTheRecords()
        {
            SkillsPage skillsPageObj = new SkillsPage();
            skillsPageObj.CancelSkills(driver);
        }

        [Then(@"Cancel function is working successfully")]
        public void ThenCancelFunctionIsWorkingSuccessfully()
        {
            SkillsPage skillsPageObj = new SkillsPage();
            skillsPageObj.CheckCancel(driver);
        }

    }
}
