using DemoProject.BrowserUtility;
using DemoProject.Entities;
using DemoProject.Library;
using DemoProject.ObjectRepository;
using OpenQA.Selenium;
using RelevantCodes.ExtentReports;
using System;

namespace DemoProject.BusinessUitilities
{
 public class UserRegistration
    {
        IWebDriver driver;
        PerformAction performAction;


        public UserRegistration(IWebDriver _driver)
        {
            driver = _driver;
            performAction = new PerformAction(driver);

        }

        public void signUpUser()
        {
            
            driver.FindElement(By.XPath(RegistrationPage.firstName)).SendKeys("TestFirstName");
            driver.FindElement(By.XPath(RegistrationPage.lastName)).SendKeys("TestLastName");
        }

        public ExtentTest createUser(ExtentReports report, TestData testdata )
        {
            ExtentTest registration = report.StartTest("SignUp");
            try
            {                              
                performAction.clickButton(RegistrationPage.CREATEACCOUNT_SIGNUP_XPATH, "CREATEACCOUNT_SIGNUP_XPATH");
               // driver.FindElement(By.XPath(RegistrationPage.createAccount)).Click();
                driver.FindElement(By.XPath(RegistrationPage.firstName)).SendKeys(testdata.firstname);
                driver.FindElement(By.XPath(RegistrationPage.lastName)).SendKeys(testdata.lastname);
                registration.Log(LogStatus.Pass, "Sign UP Test Case");     
            }
            catch (Exception e)
            {
                registration.Log(LogStatus.Fail, "Sign UP Test Case",e);
                var imagePath = new CaptureScreenshot(driver).takeScreenchot("SignUp");
                registration.Log(LogStatus.Info, "Snapshot below: " + registration.AddScreenCapture(imagePath));

            }
            return registration;


        }
    }
}
