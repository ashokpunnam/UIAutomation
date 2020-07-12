using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using OpenQA.Selenium.Interactions;
using System.Linq;
using System.Threading;
using OpenQA.Selenium.Support.UI;


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
           
        }        

    }
}
