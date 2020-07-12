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
            NavigateSite();

        }


    }
}
