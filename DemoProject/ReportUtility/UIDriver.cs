using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;

//namespace DemoProject.BrowserUtility
//{
//    public class UIDriver
//    {
//       public static IWebDriver driver;

//        public void launchApplication()
//        {
//            driver.Navigate().GoToUrl("https://accounts.google.com/signin");
//        }
//        public void NewMethod(string browserName)
//        {
//            if (browserName.Equals("Firefox"))
//            {
//                MozillaFirefoxBrowser browser = new MozillaFirefoxBrowser();
//                driver = browser.initiateBrowser();      
//            }
//            else if (browserName.Equals("Chrome"))
//            {
//                ChromeDriverService service = ChromeDriverService.CreateDefaultService(@"E:\Drivers", "chromedriver.exe");
//                driver = new ChromeDriver(service);
//                driver.Navigate().GoToUrl("https://accounts.google.com/signin");
//            }
//        }

//        /**
//	 * 
//	 * @param appUrl
//	 * @param implicitWait
//	 */
//        //launch Application
//        public  void openApplication(String appUrl, int implicitWait)
//        {
//            //  IWebDriver driver=null;
//         driver.Manage().Window.Maximize();
//         driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(implicitWait);
//         driver.Navigate().GoToUrl(appUrl);
//        }
//    }
//}
