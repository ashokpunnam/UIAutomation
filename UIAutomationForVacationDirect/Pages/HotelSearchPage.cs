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

        private readonly By byDestination = By.Id("inputDestination");
        private readonly By byCheckInDate = By.Id("inputCheckInDate");
        private readonly By byCheckoutDate = By.Id("inputCheckOutDate");
        private readonly By byDatePicker = By.XPath("//*[contains(@class, 'datepicker-state-default')]");
        // private readonly By dtCheckOutDate = By.XPath("//*[contains(@class,'datepicker-state-default')]");       
        //private readonly By slctHotelNumberAdults = By.Id("selectHotelNumberAdults");
        // private readonly By slctHotelNumberChildren = By.Id("selectHotelNumberChildren");
        //private readonly By btnMoreOptions = By.Id("hotelOptionsLink");
        //private readonly By txtPreferredHotel = By.Id("inputPreferredHotel");
        //private readonly By slctStarRating = By.Id("selectStarRating");
        private readonly By btnhotelSearchButton = By.Id("hotelSearchButton");

        public HotelSearchResultsPage SearchForHotels(string city, int checkInDate, int checkOutDate) 
        {
            WebElementWrapper.SendKeys(byDestination, city);
            WebElementWrapper.Click(byCheckInDate);
            IReadOnlyCollection<IWebElement> lstElementsFromDate = WebElementWrapper.GetWebElements(byDatePicker);
            WebElementWrapper.Click(lstElementsFromDate.ElementAt(checkInDate));

            //Thread.Sleep(1000);
            WebElementWrapper.Click(byCheckoutDate);
            IReadOnlyCollection<IWebElement> lstElementsToDate = WebElementWrapper.GetWebElements(byDatePicker);
            //getWebElements(byDatePicker);
            WebElementWrapper.Click(lstElementsToDate.ElementAt(checkOutDate));

            WebElementWrapper.Click(btnhotelSearchButton);
            return new HotelSearchResultsPage();


        }


    }
}
