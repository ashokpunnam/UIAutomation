using UIAutomationFramework.Base;

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
