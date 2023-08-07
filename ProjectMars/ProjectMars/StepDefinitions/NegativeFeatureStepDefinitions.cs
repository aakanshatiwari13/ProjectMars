using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using ProjectMars.Pages;
using ProjectMars.Utilities;
using System;
using TechTalk.SpecFlow;

namespace ProjectMars.StepDefinitions
{
    [Binding]
    public class NegativeFeatureStepDefinitions : CommonDriver
    {

        [Given(@"User is logged into localhost URL successfully")]
        public void GivenUserIsLoggedIntoLocalhostURLSuccessfully()
        {
            driver = new ChromeDriver();
            LoginPage loginPageObj = new LoginPage();
            loginPageObj.LoginSteps(driver);
        }
        [Then(@"A user should be taken to home page successfully")]
        public void ThenAUserShouldBeTakenToHomePageSuccessfully()
        {
            LanguagePage languagePageObj = new LanguagePage();
            string profileName = Username;
            string getMessage2 = languagePageObj.GetMessage2(driver);
            Assert.AreEqual(profileName, getMessage2, "Actual and expected Name do not match.");
        }



    }
}
LanguagePage languagePageObj = new LanguagePage();
string profileName = Username;
string getMessage2 = languagePageObj.GetMessage2(driver);
Assert.AreEqual(profileName, getMessage2, "Actual and expected Name do not match.");

