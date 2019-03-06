using OpenQA.Selenium;
using OpenQA.Selenium.IE;

namespace DemoProject.BrowserUtility
{
    //definition to initiate Internet Explorer browser
    class InternetExplorer :  Browsers
    {
        //initiating Internet Explorer browser
        public IWebDriver initiateBrowser()
        {
            InternetExplorerDriverService service = InternetExplorerDriverService.CreateDefaultService(@"E:\Drivers", "geckodriver.exe");
            return new InternetExplorerDriver(service);
        }
    }

}
