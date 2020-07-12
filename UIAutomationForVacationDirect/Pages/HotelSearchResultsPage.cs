using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UIAutomationFramework.Base;

namespace UIAutomationForVacationDirect.Pages
{
   public class HotelSearchResultsPage : BasePage
    {
        public HotelSearchResultsPage() : base()
        {

        }

        private By srtHotelRecommended = By.Id("HotelRecommended");
        private By srtStarRating = By.Id("StarRating");
        private By srtPricePerNight = By.Id("PricePerNight");
        private By srtDistanceSort = By.Id("DistanceSort");
        private By srtHotelName = By.Id("HotelName");
        private By btnChooseRoom = By.XPath("//*[contains(@id, 'ChooseRoom')]");
        private By chkFilterHotelResults = By.XPath("//*[contains(@id, 'StarRatingFilter')]");

        public void filterHotelResults(List<int> filterCriteria)
        {
            IReadOnlyCollection<IWebElement> elements = getWebElements(chkFilterHotelResults);
            for (int i = 0; i < elements.Count(); i++)
            {

                int elementValue = int.Parse(elements.ElementAt(i).GetAttribute("Value"));
                if (FilterSearch(filterCriteria, elementValue))
                {
                    moveToElementAndClick(elements.ElementAt(i));     
                    

                }

            }


        }

        public HotelBookRoomPage chooseRoom()
        {
            //IReadOnlyCollection<IWebElement> chooseRooms = driver.FindElements(btnChooseRoom);
            IReadOnlyCollection<IWebElement> chooseRooms = getWebElements(btnChooseRoom);
            Console.WriteLine("Rooms" + chooseRooms.Count());
            Click(chooseRooms.ElementAt(1));
            //chooseRooms.ElementAt(1).Click();
           // moveToElementAndClick(chooseRooms.ElementAt(1));
            return new HotelBookRoomPage();
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
