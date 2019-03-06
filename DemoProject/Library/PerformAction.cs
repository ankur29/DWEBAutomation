using DemoProject.Constants;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;

namespace DemoProject.Library
{
    public sealed class PerformAction
    {
        IWebDriver driver;
        public PerformAction(IWebDriver _driver)
        {
            driver = _driver;
        }

        public void doclick()
        {
            driver.FindElement(By.XPath("//span[text()='Create account']")).Click();
        }
        /**
	 * 
	 * @param domKey
	 * @param domValue
	 * @return
	 */
        //create a webelement
        public  IWebElement getLocator(String domValue,String domKey)
        {
            //    Console.WriteLine(domKey.Split('_')[2]);
            //get locator type
            String locatorType = domKey.Split('_')[2];
            IWebElement locator = null;
            //create Webelement
            if (locatorType.Equals("ID"))
            {
                locator = driver.FindElement(By.Id(domValue));
            }else if (locatorType.Equals("NAME"))
            {
                locator = driver.FindElement(By.Name(domValue));
            }
            else if (locatorType.Equals("CLASS"))
            {
                locator = driver.FindElement(By.ClassName(domValue));
            }
            else if (locatorType.Equals("XPATH"))
            {
                Console.WriteLine("XPATH SELECTED");
                locator = driver.FindElement(By.XPath(domValue));
            }
            else if (locatorType.Equals("CSS"))
            {
                locator = driver.FindElement(By.CssSelector(domValue));
            }
            else if (locatorType.Equals("LINK"))
            {
                locator = driver.FindElement(By.LinkText(domValue));
            }else
            {
                Console.WriteLine(locatorType + " locator value is not specified");
            }
            return locator;
        }

        /**
	 * 
	 * @param domKey
	 * @param domValue
	 */
        //
        public  void clickButton(String domValue,String domKey )
        {           
            IWebElement locator = getLocator(domValue, domKey);
            try
            {
                if (locator.Enabled && locator.Displayed)
                {
                    highlightText(locator);
                    locator.Click();
                    // LOG.info("Clicked on " + "'" + name + "'" + " button");
                    // LOG.debug("Clicked on " + "'" + name + "'" + " button");
                }

                else
                {
                    // LOG.error("'" + name + "'" + " : Button is not enabled");

                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                // LOG.error(name + " : Button not found");
            }
        }

        /**
	 * 
	 * @param element
	 */
        //highlightText on screen
        public  void highlightText(IWebElement element)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            //use executeScript() method and pass the arguments 
            //Here i pass values based on css style. Yellow background color with solid red color border. 
            js.ExecuteScript("arguments[0].setAttribute('style', 'background: yellow; border: 2px solid red;');", element);
        }

        /**
	 * 
	 * @param domKey
	 * @param domValue
	 * @param text
	 */
        public void enterText(String domValue, String domKey, String text)
        {
            IWebElement locator = getLocator(domValue,domKey);

            try
            {
                if (locator.Displayed)
                {
                    highlightText(locator);
                    locator.Clear();
                    locator.SendKeys(text);
                }
                else
                {
                    // LOG.error("'" + name + "'" + " : TextField is not
                    // displayed");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(text+" field is not diplayed"+e);
                // LOG.error("'" + name + "'" + " : fillTextField method is
                // throwing:- " + e);
            }
        }

        /**
	 * 
	 * @param domKey
	 * @param domValue
	 * @param Index
	 * @param selectionType
	 */
        public  void  dropdownSelection<T>(String domKey, String domValue, T Index, String selectionType)
        {
            IWebElement locator = getLocator(domKey, domValue);
            try
            {
                if (locator.Displayed)
                {
                    SelectElement select = new SelectElement(locator);
                    switch (selectionType)
                    {                       
                        case DropDownConstants.KEY_SELECT_BY_INDEX:
                            select.SelectByIndex(Int32.Parse(Index.ToString()));
                            break;
                        case DropDownConstants.KEY_DESELECT_BY_INDEX:
                             select.DeselectByIndex(Int32.Parse(Index.ToString()));
                            break;
                        case DropDownConstants.KEY_SELECT_BY_VALUE:
                            select.SelectByValue(Convert.ToString(Index));
                            break;
                        case DropDownConstants.KEY_DESELECT_BY_VALUE:
                             select.DeselectByValue(Convert.ToString(Index));
                            break;
                        case DropDownConstants.KEY_SELECT_BY_VISIBLE_TEXT:
                             select.SelectByText(Convert.ToString(Index));
                            break;
                        case DropDownConstants.KEY_DESELECT_BY_VISIBLE_TEXT:
                            select.DeselectByText(Convert.ToString(Index));
                            break;
                        default:
                            throw new Exception("Selection Type mismatch..!!");

                    }
                    // LOG.info(name + " dropdown item is selected.");
                    Console.WriteLine( "dropdown item is selected.");
                }
                else
                {
                    // LOG.error(name + " is not displayed");
                    Console.WriteLine(" dropdown item is not displayed");
                }
            }
            catch (Exception e)
            {
                // LOG.error(selectionType + " method is throwing:- " + e);
                Console.WriteLine(" method is throwing:- " + e);
            }
        }

        public void scrollTo(String scrollValue)
        {
            IJavaScriptExecutor jse = (IJavaScriptExecutor)driver;
            jse.ExecuteScript("window.scrollBy(0,"+ scrollValue+")", "");
        }

    }
}
