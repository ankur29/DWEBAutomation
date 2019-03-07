﻿using DemoProject.BrowserUtility;
using DemoProject.BusinessUitilities;
using DemoProject.Entities;
using DemoProject.Library;
using DemoProject.ReportUtility;
using NUnit.Framework;
using OpenQA.Selenium;
using RelevantCodes.ExtentReports;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;

namespace DemoProject.TestCases
{
    [TestFixture]
    [Parallelizable]
    class TestCase3 : ReportGenerator
    {
        //Define Objects
        IWebDriver driver;
        ManageDriver manageDriver = new ManageDriver();
        UserRegistration userRegistration;
        ExtentTest test, registration, systemHealthCheck;
        ReportGenerator reportGenerator = new ReportGenerator();
        ReadTestData readTestData = new ReadTestData();
        Dictionary<string, string> testDataMap;
        public ArrayList keys;
        int columnCount;
        TestData testData;

        [SetUp]
        public void setupConfigurations()
        {
            Console.WriteLine("Setup Test Configurations");
            testDataMap=readTestData.readExcelData();
            keys = readTestData.keyCount;
            columnCount = readTestData.totalColumnCount() - 1;
            Console.WriteLine("readTestData.keyCount="+readTestData.keyCount[0]);
        }
        [Test]
        //providing browser details
        [TestCaseSource(typeof(ManageDriver), "parallelBrowsers")]
        //Test cases steps
        public void runTest2(String browserName)
        {
            testData = new TestData();
            for (int i = 0; i < testDataMap.Count / columnCount; i++)
            {
                testData = new TestData();
                String appUrl = ConfigurationManager.AppSettings["DEV_URL"];      
            driver = manageDriver.parallelRun(browserName);
            systemHealthCheck = EnvironmentHealthCheck.checkUrlStatus(appUrl, report);
            userRegistration = new UserRegistration(driver);
            new TestRunner(driver).openApplication(appUrl, 6);
            Console.WriteLine("testDataMap.Count=" + testDataMap.Count);
            
                Console.WriteLine("1");
                test = report.StartTest(testDataMap["TestCaseName_"+ keys[i]], "Account Creation Steps");
                test.AssignCategory("https://cdn0.iconfinder.com/data/icons/jfk/512/chrome-512.png");
                test.AssignCategory(browserName);
                Console.WriteLine("Assigned");
                testData.firstname= testDataMap["FirstName_" + keys[i]];
                testData.lastname = testDataMap["LastName_" + keys[i]];


                registration = userRegistration.createUser(report,testData);
                test.AppendChild(systemHealthCheck).AppendChild(registration);
                report.EndTest(test);
                report.Flush();
                driver.Close();
            }
        }        

        [TearDown]
        public void endTest() // This method will be fired at the end of the test
        {
            try
            {
                driver.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception=" + e);
              
            }
        }



    }
}
