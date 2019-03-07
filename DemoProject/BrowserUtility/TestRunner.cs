using System;
using OpenQA.Selenium;
using NUnit.Framework;

namespace DemoProject.BrowserUtility
{
    
    //Initiate Webdriver instance
   public class TestRunner
    {

          IWebDriver driver;

        public TestRunner(IWebDriver _driver)
        {
            driver = _driver;
        }
   /**
    * 
    * @param appUrl
    * @param implicitWait
    */
        //launch Application
        public void openApplication(String appUrl, int implicitWait)
        {
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(implicitWait);
            driver.Navigate().GoToUrl(appUrl);            
        }



    }
}
