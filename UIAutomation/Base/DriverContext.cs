using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace UIAutomationFramework.Base
{
   public static class DriverContext
    {
        private static IWebDriver driver;

        public static IWebDriver Driver
        {
            get
            {
                return driver;
            }
            set
            {
                driver = value;
            }
        }
    }
}
