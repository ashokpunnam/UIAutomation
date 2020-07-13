using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using System;
using System.Text;
using UIAutomationFramework.Config;
using UIAutomationFramework.Utilities;
using static UIAutomationFramework.Base.Browser;

namespace UIAutomationFramework.Base
{
    public class TestInitializeHook : Base
    {
        public readonly BrowserType Browser;

        public TestInitializeHook(BrowserType browser)
        {
            Browser = browser;            
        }


        public void InitializeSettings()
        {
            //Set all the settings for framework
            //ConfigReader.SetFrameworkSettings();

            //Set Log
            //LogHelpers.CreateLogFile();

            //Open Browser
            OpenBrowser(Browser);           
            //LogHelpers.Write("Initialized framework");

        }

        private void OpenBrowser(BrowserType browserType = BrowserType.FireFox)
        {
            switch (browserType)
            {
                case BrowserType.InternetExplorer:
                    DriverContext.Driver = new InternetExplorerDriver();
                    DriverContext.Browser = new Browser(DriverContext.Driver);
                    break;
                case BrowserType.FireFox:
                    DriverContext.Driver = new FirefoxDriver();
                    DriverContext.Browser = new Browser(DriverContext.Driver);
                    break;
                case BrowserType.Chrome:
                    DriverContext.Driver = new ChromeDriver();
                    DriverContext.Browser = new Browser(DriverContext.Driver);
                    break;
            }

        }

        public void CloseBrowser()
        {
            DriverContext.Driver.Close();
            DriverContext.Driver.Quit();

        }

        


    }



}
