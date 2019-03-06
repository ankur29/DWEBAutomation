//using DemoProject.BrowserUtility;
//using DemoProject.BusinessUitilities;
//using DemoProject.ReportUtility;
//using NUnit.Framework;
//using OpenQA.Selenium;
//using RelevantCodes.ExtentReports;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace DemoProject.TestCases
//{
//    [TestFixture]
    
//    class TestCase2
//    {
//        //define objects
//        ExtentReports report;
//        ExtentTest test, registration;
//        SelectBrowser selectBrowser = new SelectBrowser();
//        TestRunner testRunner = new TestRunner();
//        UserRegistration userRegistration = new UserRegistration();
//        ReportGenerator reportGenerator = new ReportGenerator();

//        [SetUp]
//            public void startTest()
//        {
//            report = reportGenerator.createReport();
//        }

//        [Test]
//        [TestCaseSource(typeof(SelectBrowser), "parallelBrowsers")]
//        public void login(String browserName)
//        {
            
//            test = report.StartTest("Login Account", "Account Login Steps");
//            test.AssignCategory(browserName);
//            selectBrowser.getBrowser(browserName);
//            testRunner.openApplication("https://accounts.google.com/signin", 8);
//            registration = userRegistration.createUser(report);
//            test.AppendChild(registration);

//        }
//        [TearDown]
//        public void endTest() // This method will be fired at the end of the test
//        {
//            report.EndTest(test);
//            report.Flush();
//            report.Close();
//        }


//    }
//}
