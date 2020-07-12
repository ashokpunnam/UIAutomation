using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using OpenQA.Selenium.Interactions;
using System.Linq;
using System.Threading;
using OpenQA.Selenium.Support.UI;
using UIAutomationFramework.Base;

namespace UIAutomationFramework.Wrappers
{
   public static class WebElementWrapper 
    {        
        public static void sendKeys(By by, string value)
        {

            IWebElement element = waitForElementDisplayed(by);
            element.Clear();
            element.SendKeys(value);
            Thread.Sleep(500);
            element.SendKeys(Keys.Enter);
            Thread.Sleep(500);
            element.SendKeys(Keys.Tab);
        }

        public static string getAttributeValue(By by, string attributeType)
        {
            IWebElement element = waitForElementDisplayed(by);
            return element.GetAttribute(attributeType);

        }
        public static string GetText(By by)
        {
            IWebElement element = waitForElementDisplayed(by);
            return element.Text;

        }



        public static void Click(IWebElement element)
        {

            waitForElementDisplayed(element).Click();
        }
        public static void Click(By by)
        {
            waitForElementDisplayed(by).Click();

        }

        public static Boolean FilterSearch(List<int> filterCriteria, int value)
        {
            for (int i = 0; i < filterCriteria.Count(); i++)
            {
                if (value == filterCriteria[i])
                {
                    return true;
                }
            }
            return false;

        }
        public static IReadOnlyCollection<IWebElement> getWebElements(By by)
        {
            IReadOnlyCollection<IWebElement> lstElements = waitForElementsDisplayed(by);
            return lstElements;

        }

        public static void moveToElementAndClick(IWebElement element)
        {
            Actions actions = new Actions(DriverContext.Driver);
            actions.MoveToElement(element).Click().Perform();

        }

        public static void multiCheckBoxSelect(By by, int[] filterCriteria)
        {
            IReadOnlyCollection<IWebElement> filterConditions = waitForElementsDisplayed(by);
            foreach (IWebElement element in filterConditions)
            {
                foreach (int i in filterCriteria)
                {
                    moveToElementAndClick(waitForElementDisplayed(element));
                }

            }
        }

        public static IWebElement waitForElementDisplayed(By by)
        {
            var wait = new DefaultWait<IWebDriver>(DriverContext.Driver);
            wait.Timeout = TimeSpan.FromSeconds(50);
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException));
            wait.IgnoreExceptionTypes(typeof(ElementClickInterceptedException));
            return wait.Until<IWebElement>(d =>
            {
                // if (!d.FindElement(by).Displayed)
                // return null;
                return d.FindElement(by);
            });

        }

        public static IWebElement waitForElementDisplayed(IWebElement element)
        {
            var wait = new DefaultWait<IWebDriver>(DriverContext.Driver);
            wait.Timeout = TimeSpan.FromSeconds(50);
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException));
            wait.IgnoreExceptionTypes(typeof(ElementClickInterceptedException));
            return wait.Until<IWebElement>(d =>
            {
                //if(!element.Displayed) 
                // return null;
                return element;
            });

        }

        public static IReadOnlyCollection<IWebElement> waitForElementsDisplayed(By by)
        {
            var wait = new DefaultWait<IWebDriver>(DriverContext.Driver);
            wait.Timeout = TimeSpan.FromSeconds(50);
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException));
            wait.IgnoreExceptionTypes(typeof(ElementClickInterceptedException));
            return wait.Until(d =>
            {
                IReadOnlyCollection<IWebElement> lstElements = d.FindElements(by);
                return lstElements;
            });

        }

    }
}
