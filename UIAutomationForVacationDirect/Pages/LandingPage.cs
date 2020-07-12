using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UIAutomationFramework.Base;

namespace UIAutomationForVacationDirect.Pages
{
    public class LandingPage:BasePage
    {
       // private IWebDriver driver;
        public LandingPage():base()
        {
            //this.driver = driver;
        }

        private By btnHotel = By.XPath("//*[@id='SearchWidgetWrapper']/section/div/ul/li[2]/button");
        private By homeIcon = By.XPath("//*[@id='4722']/div[2]/div[1]/header/div[2]/a/img");

        public string getHomePageIcon()
        {
            return getAttributeValue(homeIcon, "alt");
        }

        public HotelSearchPage clickHotel()
        {
            driver.FindElement(btnHotel).Click();
            return new HotelSearchPage();

        }
    }
}
