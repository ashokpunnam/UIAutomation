using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using SeleniumExtras.PageObjects;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Interactions;
using System.Linq;
using System.Threading;
using OpenQA.Selenium.Support.UI;
using System.IO.Pipes;

namespace UIAutomationFramework.Base
{
    public class BasePage : Base
    {
        //public IWebDriver driver { get; set; }
        public IWebDriver driver;
      //  public WebDriverWait wait;
        

        public BasePage()
        {
            driver = DriverContext.Driver;
            driver.Manage().Window.Maximize();
           driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
           // wait = new WebDriverWait(driver, TimeSpan.FromSeconds(50));
           
        }

        public void TearDown()
        {
            
            driver.Quit();
        }

        public void sendKeys(By by, string value)        
        {
            //Thread.Sleep(2000);
            IWebElement element = waitForElementDisplayed(by);
            //IWebElement element = driver.FindElement(by);
            element.Clear();
            element.SendKeys(value);
            //Thread.Sleep(2000);
            element.SendKeys(Keys.Enter);
            //Thread.Sleep(2000);
            element.SendKeys(Keys.Tab);
        }

        public void Click(IWebElement element)
        {
            //Thread.Sleep(2000);
           waitForElementDisplayed(element).Click();
            //element.Click();
        }
        public void Click(By by)
        {
            //Thread.Sleep(2000);
            waitForElementDisplayed(by).Click();
            
            //driver.FindElement(by).Click();
        }

        public Boolean FilterSearch(int[] filterCriteria, int value)
        {
            //Thread.Sleep(2000);
            for (int i = 0; i < filterCriteria.Length; i++)
            {
                if (value == filterCriteria[i])
                {
                    return true;
                }
            }
            return false;

        }
        public IReadOnlyCollection<IWebElement> getWebElements(By by)
        {
            //Thread.Sleep(2000);
           // IReadOnlyCollection<IWebElement> lstElements = driver.FindElements(by);

            IReadOnlyCollection<IWebElement> lstElements = waitForElementsDisplayed(by);
            //lstElementsToDate.ElementAt(day).Click();            
            return lstElements;

        }

        public void moveToElementAndClick(IWebElement element)
        {
            //Thread.Sleep(2000);
            //waitForElementDisplayed(element);
            //IWebElement element = driver.FindElement(by);
            Actions actions = new Actions(driver);
            actions.MoveToElement(element).Click().Perform();

        }

        public void multiCheckBoxSelect(By by, int[] filterCriteria)
        {
            //Thread.Sleep(2000);
            
            IReadOnlyCollection<IWebElement> filterConditions = waitForElementsDisplayed(by);
            foreach(IWebElement element in filterConditions){
                foreach (int i in filterCriteria)
                {
                    moveToElementAndClick(waitForElementDisplayed(element));
                }

            }

            
        }

        public IWebElement waitForElementDisplayed(By by )
        {
            //wait = new WebDriverWait(driver, TimeSpan.FromSeconds(50));
            var wait = new DefaultWait<IWebDriver>(driver);
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

        public IWebElement waitForElementDisplayed(IWebElement element)
        {
            //wait = new WebDriverWait(driver, TimeSpan.FromSeconds(50));
            var wait = new DefaultWait<IWebDriver>(driver);
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

        public IReadOnlyCollection<IWebElement> waitForElementsDisplayed(By by)
        {
            //wait = new WebDriverWait(driver, TimeSpan.FromSeconds(50));
            var wait = new DefaultWait<IWebDriver>(driver);
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
