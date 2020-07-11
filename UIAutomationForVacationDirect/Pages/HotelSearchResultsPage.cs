using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UIAutomationFramework.Base;

namespace UIAutomationForVacationDirect.Pages
{
    class HotelSearchResultsPage : BasePage
    {
        public HotelSearchResultsPage() : base()
        {

        }

        private By srtHotelRecommended = By.Id("HotelRecommended");
        private By srtStarRating = By.Id("StarRating");
        private By srtPricePerNight = By.Id("PricePerNight");
        private By srtDistanceSort = By.Id("DistanceSort");
        private By srtHotelName = By.Id("HotelName");
        private By btnChooseRoom = By.XPath("//div[starts-with(@id,'ChooseRoom')]");
        private By chkFilterHotelResults = By.XPath("//*[contains(@id, 'StarRatingFilter')]");

        public void filterHotelResults(String noOfStars)
        {
            IReadOnlyCollection<IWebElement> filterConditions = driver.FindElements(chkFilterHotelResults);
            filterConditions.ElementAt(1).Click();



        }

        public void sortHotelSearch(String filterCriteria)
        {
            FilterCriteria fltrCriteria;
            Enum.TryParse(filterCriteria, out fltrCriteria);

            switch (fltrCriteria)
            {
                case FilterCriteria.Recommended:
                    driver.FindElement(srtHotelRecommended).Click();
                    break;
                case FilterCriteria.StarRating:
                    driver.FindElement(srtStarRating).Click();
                    break;
                case FilterCriteria.PricePerNight:
                    driver.FindElement(srtPricePerNight).Click();
                    break;
                case FilterCriteria.Distance:
                    driver.FindElement(srtDistanceSort).Click();
                    break;
                case FilterCriteria.HotelName:
                    driver.FindElement(srtHotelName).Click();
                    break;
            }

        }

        public HotelBookRoomPage chooseRoom()
        {
            IReadOnlyCollection<IWebElement> chooseRooms = driver.FindElements(btnChooseRoom);
            chooseRooms.ElementAt(1).Click();
            return new HotelBookRoomPage();
        }


        enum FilterCriteria
        {
            Recommended,     // 0
            StarRating,    // 1
            PricePerNight,  // 2
            Distance,   // 3
            HotelName,     // 4           
        }



    }
}
