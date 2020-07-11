using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UIAutomationFramework.Base;

namespace UIAutomationForVacationDirect.Pages
{
    class HotelSearchPage:BasePage
    {
        public HotelSearchPage() : base()
        {

        }

        private By byDestination = By.Id("inputDestination");
        private By byCheckInDate = By.Id("inputCheckInDate");
        private By byCheckoutDate = By.Id("inputCheckOutDate");
        private By byDatePicker = By.XPath("//*[contains(@class, 'datepicker-state-default')]");
       // private By dtCheckOutDate = By.XPath("//*[contains(@class,'datepicker-state-default')]");       
        private By slctHotelNumberAdults = By.Id("selectHotelNumberAdults");
        private By slctHotelNumberChildren = By.Id("selectHotelNumberChildren");
        private By btnMoreOptions = By.Id("hotelOptionsLink");
        private By txtPreferredHotel = By.Id("inputPreferredHotel");
        private By slctStarRating = By.Id("selectStarRating");
        private By btnhotelSearchButton = By.Id("hotelSearchButton");

        public HotelSearchResultsPage SearchForHotels(string city, int checkInDate, int checkOutDate) 
        {
            sendKeys(byDestination, city);
            Click(byCheckInDate);
            getWebElementsAndSendKeys(byDatePicker, checkInDate);
            Click(byCheckoutDate);
            getWebElementsAndSendKeys(byDatePicker, checkOutDate);
            driver.FindElement(btnhotelSearchButton).Click();
            return new HotelSearchResultsPage();


            /*IWebElement elmDestination = driver.FindElement(txtDestination);
            elmDestination.SendKeys(city);
            elmDestination.SendKeys(Keys.ArrowDown);
            elmDestination.SendKeys(Keys.Enter);
            js.ExecuteScript("document.getElementById('inputCheckInDate').setAttribute('value','07/08/20')");
            js.ExecuteScript("document.getElementById('inputCheckOutDate').setAttribute('value','08/07/20')");
            driver.FindElement(btnhotelSearchButton).Click();
            return new HotelSearchResultsPage();*/
        }


    }
}
