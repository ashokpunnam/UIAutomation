﻿using OpenQA.Selenium;
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

        public HotelSearchPage clickHotel()
        {
            driver.FindElement(btnHotel).Click();
            return new HotelSearchPage();

        }
    }
}
