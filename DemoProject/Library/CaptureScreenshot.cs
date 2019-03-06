using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject.Library
{
  public class CaptureScreenshot
    {
        IWebDriver driver;
        public CaptureScreenshot(IWebDriver _driver)
        {
            driver = _driver;
        }
        public String takeScreenchot(String fileName)
        {
            ITakesScreenshot screen = driver as ITakesScreenshot;  // ITakesScreenshot is  an interface inside OpenQA.Selenium namespace
            Screenshot scrnst = screen.GetScreenshot();  // Screenshot is a class inside OpenQA.Selenium namespace
            string screenshot = "C:/Users/ankur.choudhary/Documents/Visual Studio 2015/Projects/DemoProject/DemoProject/Screenshot/" + fileName+".png";
            scrnst.SaveAsFile(screenshot);
            return screenshot;
        }
    }
}
