using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using UIAutomationFramework.Base;
using UIAutomationFramework.Wrappers;

namespace UIAutomationForVacationDirect.Pages
{
    public class HotelSearchPage:BasePage
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
            WebElementWrapper.sendKeys(byDestination, city);
            WebElementWrapper.Click(byCheckInDate);
            IReadOnlyCollection<IWebElement> lstElementsFromDate = WebElementWrapper.getWebElements(byDatePicker);
            WebElementWrapper.Click(lstElementsFromDate.ElementAt(checkInDate));

            //Thread.Sleep(1000);
            WebElementWrapper.Click(byCheckoutDate);
            IReadOnlyCollection<IWebElement> lstElementsToDate = WebElementWrapper.getWebElements(byDatePicker);
            //getWebElements(byDatePicker);
            WebElementWrapper.Click(lstElementsToDate.ElementAt(checkOutDate));

            WebElementWrapper.Click(btnhotelSearchButton);
            return new HotelSearchResultsPage();


        }


    }
}
