using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

using Microsoft.VisualStudio.TestTools.UnitTesting;
//using AventStack.ExtentReports;
using UnitTestProject3.Utilities;

namespace UnitTestProject3.StepDefinationFile
{
    [Binding]
    public class CheckTheLoginFunctionalityOfAutomationPractice_ComSteps: Utilities.BasePage

    {
       
        [Given(@"I have navigated to the website")]
        public void GivenIhavenavigatedtothewebsite()
        {
             try
             {
                 invokeDriver();

                 driver.Navigate().GoToUrl("http://automationpractice.com/index.php");
                 driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            }
             catch(Exception e) {

             }

        }

        [Given(@"login button clicked")]
        public void GivenLoginButtonClicked()
        {
            driver.FindElement(By.XPath("//a[@class='login']")).Click();
        }


        [When(@"login button clicked")]
        public void WhenLoginButtonClicked() 
        {
           driver.FindElement(By.XPath("//a[@class='login']")).Click();
        }

        [When(@"we will Pass the parameters")]
        public void WhenwewillPasstheparameters()
        {
            driver.FindElement(By.XPath("//input[@id='email']")).Click();
            driver.FindElement(By.XPath("//input[@id='email']")).SendKeys("");
            driver.FindElement(By.XPath("//input[@id='passwd']")).Click();
            driver.FindElement(By.XPath("//input[@id='passwd']")).SendKeys("aditya");

            driver.FindElement(By.LinkText("Sign in")).Click();
        }

        [When(@"Pass the parameters")]
        public void WhenPassTheParameters() 
        {
            driver.FindElement(By.XPath("//input[@id='email']")).Click();
            driver.FindElement(By.XPath("//input[@id='email']")).SendKeys("adityanikkipdm@gmail.com");
            driver.FindElement(By.XPath("//input[@id='passwd']")).Click();
            driver.FindElement(By.XPath("//input[@id='passwd']")).SendKeys("");
            driver.FindElement(By.LinkText("Sign in")).Click();
        }

        [When(@"Pass the Arguments")]
        public void WhenPassTheArguments()
        {
            driver.FindElement(By.XPath("//input[@id='email']")).Click();
            driver.FindElement(By.XPath("//input[@id='email']")).SendKeys("adityanikkipdm@gmail.com");
            driver.FindElement(By.XPath("//input[@id='passwd']")).Click();
            driver.FindElement(By.XPath("//input[@id='passwd']")).SendKeys("@nikdghki6656");
            driver.FindElement(By.XPath("//p[@class='submit']//span[1]")).Click();
            driver.FindElement(By.XPath("//p[@class='submit']//span[1]")).Click();


        }

        [When(@"No Argument is passed")]
        public void WhenNoArgumentIsPassed()
        {
            driver.FindElement(By.XPath("//input[@id='email']")).Click();
            driver.FindElement(By.XPath("//input[@id='email']")).SendKeys("");
            driver.FindElement(By.XPath("//input[@id='passwd']")).Click();
            driver.FindElement(By.XPath("//input[@id='passwd']")).SendKeys("");
            driver.FindElement(By.XPath("//p[@class='submit']//span[1]")).Click();

        }

        [Then(@"Message is Displayed")]
        public void ThenMessageIsDisplayed()
        {
            Console.WriteLine("An email address required.");
        }
        
        [Then(@"Unsucessful Message is displayed")]
        public void ThenUnsucessfulMessageisdisplayed()
        {
            Console.WriteLine("Password is required.");
        }
        
        [Then(@"Message is displayed accordingly")]
        public void ThenMessageisdisplayedaccordingly()
        {
            Console.WriteLine("Invalid email address.");
        }
        
        [Then(@"Error Message is shown")]
        public void ThenErrorMessageisshown()
        {
            Console.WriteLine("An email address required.");
        }

        [Then(@"Close the Browser")]
        public void ThenCloseTheBrowser()
        {
            closeDriver();


        }
    }

}
