using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace DemoProject.BrowserUtility
{
    //definition to initiate mozilla browser
    class MozillaFirefoxBrowser : Browsers
    {
        //initiating mozilla browser
        public IWebDriver initiateBrowser()
        {
            Console.WriteLine("Initiate Mozilla Browser");
            FirefoxDriverService service = FirefoxDriverService.CreateDefaultService(@"E:\Drivers", "geckodriver.exe");
            return new FirefoxDriver(service);
        }
    }
}
