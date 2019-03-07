using OpenQA.Selenium;
using OpenQA.Selenium.IE;
using System;

namespace DemoProject.BrowserUtility
{
    //definition to initiate Internet Explorer browser
    class InternetExplorer :  Browsers
    {
        //initiating Internet Explorer browser
        public IWebDriver initiateBrowser()
        {
            InternetExplorerDriverService service = InternetExplorerDriverService.CreateDefaultService(@"E:\Drivers", "geckodriver.exe");
            Console.WriteLine("Internet Explorer Browser Instance is created");
            return new InternetExplorerDriver(service);
        }
    }

}
