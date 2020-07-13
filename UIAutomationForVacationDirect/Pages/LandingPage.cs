using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UIAutomationFramework.Base;
using UIAutomationFramework.Wrappers;

namespace UIAutomationForVacationDirect.Pages
{
    public class LandingPage:BasePage
    {
       // private IWebDriver driver;
        public LandingPage():base()
        {
            //this.driver = driver;
        }

        private readonly By btnHotel = By.XPath("//*[@id='SearchWidgetWrapper']/section/div/ul/li[2]/button");
        private readonly By homeIcon = By.XPath("//*[@id='4722']/div[2]/div[1]/header/div[2]/a/img");

        public string GetHomePageIcon()
        {
            return WebElementWrapper.GetAttributeValue(homeIcon, "alt");
        }

        public HotelSearchPage ClickHotel()
        {
            //driver.FindElement(btnHotel).Click();
            WebElementWrapper.Click(btnHotel);
            return new HotelSearchPage();

        }
    }
}
