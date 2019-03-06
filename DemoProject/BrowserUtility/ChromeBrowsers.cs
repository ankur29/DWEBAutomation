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
            Console.WriteLine("Initiate Browser");
            ChromeDriverService service = ChromeDriverService.CreateDefaultService(@"E:\Drivers", "chromedriver.exe");
            return new ChromeDriver(service);
        }
    }
}
