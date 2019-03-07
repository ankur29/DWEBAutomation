//using OpenQA.Selenium;
//using OpenQA.Selenium.Chrome;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace DemoProject.BrowserUtility
//{
//     class SelectBrowser
//    {
//        /**
//         * @param browserName
//         */
//         //initiate the requested browser
//        //public void getBrowser(string browserName)
//        //{
//        //    if (browserName.Equals("Firefox"))
//        //    {
//        //        MozillaFirefoxBrowser mozilla = new MozillaFirefoxBrowser();
//        //        driver = mozilla.initiateBrowser();
//        //    }
//        //    else if (browserName.Equals("Chrome"))
//        //    {
//        //        ChromeBrowsers chrome = new ChromeBrowsers();
//        //        driver = chrome.initiateBrowser();
//        //    }
//        //    else if (browserName.Equals("IE"))
//        //    {
//        //        InternetExplorer IE = new InternetExplorer();
//        //        driver = IE.initiateBrowser();
//        //    }
//        //}
        
//        //contains browser name
//        public static IEnumerable<String> parallelBrowsers()
//        {
//            String[] browserList = { "Firefox", "Chrome" };

//            foreach (String s in browserList)
//            {
//                yield return s;
//            }
//        }


//    }
//}
