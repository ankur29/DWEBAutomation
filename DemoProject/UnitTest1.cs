//using System;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using DemoProject.Library;
//using DemoProject.BrowserUtility;
//using NUnit.Framework;
//using System.Collections.Generic;

//namespace DemoProject
//{
//    [TestFixture]
//    [Parallelizable]
//    public class UnitTest1 : UIDriver
//    {
//        public static IEnumerable<String> parallelBrowsers()
//        {
//            String[] browserList = { "firefox", "chrome"};

//            foreach (String s in browserList)
//            {
//               yield return s;
//            }
//         }

//        [Test]
//        [TestCaseSource("parallelBrowsers")]
//        public void TestMethod1(String browserName)
//        {
//            SelectBrowser selectBrowser = new SelectBrowser();
//            selectBrowser.getBrowser(browserName);
//            UIDriver Driver = new UIDriver();
//            Driver.openApplication("http://blog.testproject.io/", 8);
//        }
//    }
//}
