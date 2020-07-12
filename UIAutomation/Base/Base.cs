using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace UIAutomationFramework.Base
{
    public class Base
    {
        public BasePage CurrentPage { get; set; }

        private IWebDriver driver { get; set; }

        protected TPage GetInstance<TPage>() where TPage : BasePage, new()
        {
            TPage pageInstance = new TPage()
            {
                driver = DriverContext.Driver
            };

            //PageFactory.InitElements(DriverContext.Driver, pageInstance);

            return pageInstance;
        }

        public TPage As<TPage>() where TPage : BasePage
        {
            return (TPage)this;
        }
    }
}
