using ProjectMars.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

﻿using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using ProjectMars.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMars.Utilities
{
    public class CommonDriver
    {
        public IWebDriver driver;
        [OneTimeSetUp]
        public void LoginSteps()
        {
            driver = new ChromeDriver();

            //Login page object initialization and definition
            LoginPage loginPageObj = new LoginPage();
            loginPageObj.LoginSteps(driver);
        }
        [OneTimeTearDown]

        public void SkillsLoginSteps()
        {
            driver = new ChromeDriver();

            //Login page object initialization and definition
            SkillsLoginPage loginPageObj = new SkillsLoginPage();
            loginPageObj.LoginSteps(driver);
        }
        [OneTimeTearDown]
        public void ClosingSteps()
        {
            driver.Quit();
        }
    }
}
