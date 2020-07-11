using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using SeleniumExtras.PageObjects;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Interactions;
using System.Linq;

namespace UIAutomationFramework.Base
{
    public abstract class BasePage : Base
    {
        //public IWebDriver driver { get; set; }
        public IWebDriver driver;
       public IJavaScriptExecutor js;

        public BasePage()
        {
            driver = DriverContext.Driver;
            js = (IJavaScriptExecutor)driver;
           
        }

        public void sendKeys(By by, string value)        
        {
            IWebElement element = driver.FindElement(by);
            element.Clear();
            element.SendKeys(value);
            element.SendKeys(Keys.Enter);
            element.SendKeys(Keys.Tab);
        }

        public void Click(By by)
        {
            driver.FindElement(by).Click();
        }

        public void getWebElementsAndSendKeys(By by, int day)
        {
            IReadOnlyCollection<IWebElement> lstElementsToDate = driver.FindElements(by);
            lstElementsToDate.ElementAt(day).Click();            
            // return lstElementsToDate;

        }

        public void moveToElementAndClick(By by)
        {
            IWebElement element = driver.FindElement(by);
            Actions actions = new Actions(driver);
            actions.MoveToElement(element).Click().Perform();

        }

        public void multiCheckBoxSelect(By by, int[] FilterConditions)
        {
            IReadOnlyCollection<IWebElement> filterConditions = driver.FindElements(by);

            
        }



    }
}
