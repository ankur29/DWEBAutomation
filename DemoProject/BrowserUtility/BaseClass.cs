using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject.BrowserUtility
{
    class BaseClass
    {
        public IWebDriver driver;
        public IWebDriver getDriver()
        {
            return driver;
        }

        public IWebDriver setDriver(String browserName)
        {
            if (browserName.Equals("Firefox"))
            {
                MozillaFirefoxBrowser mozilla = new MozillaFirefoxBrowser();
                return driver = mozilla.initiateBrowser();
            }
            else if (browserName.Equals("Chrome"))
            {
                ChromeBrowsers chrome = new ChromeBrowsers();
                return driver = chrome.initiateBrowser();
            }
            else if (browserName.Equals("IE"))
            {
                InternetExplorer IE = new InternetExplorer();
                return driver = IE.initiateBrowser();
            }
            return null;
        }

        public void openApplication(String appUrl, int implicitWait)
        {
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(implicitWait);
            driver.Navigate().GoToUrl(appUrl);

        }
    }
    }
