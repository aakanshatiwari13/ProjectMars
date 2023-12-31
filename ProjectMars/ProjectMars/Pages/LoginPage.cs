﻿using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMars.Pages
{
    public class LoginPage
    {
        public void LoginSteps(IWebDriver driver)
        {
            //Launch home portal 
            driver.Navigate().GoToUrl("http://localhost:5000/Home");
            driver.Manage().Window.Maximize();
            Thread.Sleep(3000);

            IWebElement signInButton = driver.FindElement(By.XPath("//*[@id='home']/div/div/div[1]/div/a"));
            signInButton.Click();

            //identify username textbox and enter valid username
            IWebElement usernameTextbox = driver.FindElement(By.Name("email"));
            usernameTextbox.SendKeys("aakanshatiwaripn@gmail.com");

            //identify password textbox and enter valid password
            IWebElement passwordTextbox = driver.FindElement(By.Name("password"));
            passwordTextbox.SendKeys("*aakansha13");

            // click login button
            IWebElement loginButton = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[4]/button"));
            loginButton.Click();
            Thread.Sleep(3000);
        }
    }
}
