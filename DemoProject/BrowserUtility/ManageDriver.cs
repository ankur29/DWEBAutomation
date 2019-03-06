using DemoProject.BrowserUtility;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject.TestCases
{
    class ManageDriver
    {

        public IWebDriver parallelRun(String browserName)
        {

            if (browserName.Equals("Chrome"))
            {
                // return driver of chrome
                ChromeBrowsers chrome = new ChromeBrowsers();
                Console.WriteLine("Chrome");
                return chrome.initiateBrowser();
            }
            else if (browserName.Equals("Firefox"))
            {
                // return driver of mozilla
                MozillaFirefoxBrowser mozilla = new MozillaFirefoxBrowser();
                return mozilla.initiateBrowser();
            }else
            {
                Console.WriteLine(browserName+" browser is not present");
            }
            return null;

        }

        //contains browser name
        public static IEnumerable<String> parallelBrowsers()
        {
            String[] browserList = { "Firefox", "Chrome" };

            foreach (String s in browserList)
            {
                yield return s;
            }
        }


    }
}
