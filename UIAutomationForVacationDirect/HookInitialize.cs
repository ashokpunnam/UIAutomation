using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UIAutomationFramework.Base;
using static UIAutomationFramework.Base.Browser;

namespace UIAutomationForVacationDirect
{
   public class HookInitialize:TestInitializeHook
    {
       // public HookInitialize():base(BrowserType.Chrome)
       public HookInitialize(BrowserType browserType) : base(browserType)
        {
            InitializeSettings();           

        }

        public void NavigateSite(string url)
        {
            // DriverContext.Browser.GoToUrl(Settings.AUT);   
            // DriverContext.Browser.GoToUrl("http://www.vacationsdirect.com");
            DriverContext.Browser.GoToUrl(url);

            // .Manage().Timeouts(10);
            //            LogUtility.Write("Opened the browser !!!");
        }


    }
}
