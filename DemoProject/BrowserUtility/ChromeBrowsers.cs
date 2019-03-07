using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;

namespace DemoProject.BrowserUtility
{
    //definition to initiate Chrome browser
    class ChromeBrowsers :  Browsers
    {
        //initiating Chrome browser
        public IWebDriver initiateBrowser()
        {            
            ChromeDriverService service = ChromeDriverService.CreateDefaultService(@"E:\Drivers", "chromedriver.exe");
            Console.WriteLine("Chrome Browser Instance is created");
            return new ChromeDriver(service);
        }
    }
}
