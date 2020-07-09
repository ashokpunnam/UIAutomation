using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using SeleniumExtras.PageObjects;
using OpenQA.Selenium.Support.PageObjects;

namespace UIAutomationFramework.Base
{
    public abstract class BasePage
    {
        public IWebDriver driver;
        public IJavaScriptExecutor js;

        public BasePage()
        {
            // PageFactory.InitElements(DriverContext.Driver, this);
            driver = DriverContext.Driver;
            js = (IJavaScriptExecutor)driver;

        }
    }
}
