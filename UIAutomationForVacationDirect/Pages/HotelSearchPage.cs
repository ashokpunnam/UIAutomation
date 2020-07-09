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

        private By txtDestination = By.Id("inputDestination");
        private By dtCheckInDate = By.Id("inputCheckInDate");
        private By dtCheckOutDate = By.Id("inputCheckOutDate");
        private By slctHotelNumberAdults = By.Id("selectHotelNumberAdults");
        private By slctHotelNumberChildren = By.Id("selectHotelNumberChildren");
        private By btnMoreOptions = By.Id("hotelOptionsLink");
        private By txtPreferredHotel = By.Id("inputPreferredHotel");
        private By slctStarRating = By.Id("selectStarRating");
        private By btnhotelSearchButton = By.Id("hotelSearchButton");

        public void SearchForHotels(string city, String checkInDate, String checkOutDate) //int noOfAdults, int noOfChildren)
        {
            IWebElement elmDestination = driver.FindElement(txtDestination);
            elmDestination.SendKeys(city);
            elmDestination.SendKeys(Keys.ArrowDown);
            elmDestination.SendKeys(Keys.Enter);
            js.ExecuteScript("document.getElementById('inputCheckInDate').setAttribute('value','07/08/20')");
            js.ExecuteScript("document.getElementById('inputCheckOutDate').setAttribute('value','08/07/20')");
            driver.FindElement(btnhotelSearchButton).Click();
        }


    }
}
