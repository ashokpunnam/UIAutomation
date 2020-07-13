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
   public class HotelSearchResultsPage : BasePage
    {
        public HotelSearchResultsPage() : base()
        {

        }

        private readonly By srtHotelRecommended = By.Id("HotelRecommended");
        private readonly By srtStarRating = By.Id("StarRating");
        private readonly By srtPricePerNight = By.Id("PricePerNight");
        private readonly By srtDistanceSort = By.Id("DistanceSort");
        private readonly By srtHotelName = By.Id("HotelName");
        private readonly By btnChooseRoom = By.XPath("//*[contains(@id, 'ChooseRoom')]");
        private readonly By chkFilterHotelResults = By.XPath("//*[contains(@id, 'StarRatingFilter')]");

        IReadOnlyCollection<IWebElement> ListOfHotels;

        public void FilterHotelResults(List<int> filterCriteria)
        {
            IReadOnlyCollection<IWebElement> elements = WebElementWrapper.GetWebElements(chkFilterHotelResults);
            for (int i = 0; i < elements.Count(); i++)
            {

                int elementValue = int.Parse(elements.ElementAt(i).GetAttribute("Value"));
                if (WebElementWrapper.FilterSearch(filterCriteria, elementValue))
                {
                    WebElementWrapper.MoveToElementAndClick(elements.ElementAt(i));     
                    

                }

            }


        }

        public void GetListOfHotels()
        {
            ListOfHotels = driver.FindElements(btnChooseRoom);
        }

        public HotelBookRoomPage ChooseRoom()
        {
            //IReadOnlyCollection<IWebElement> chooseRooms = driver.FindElements(btnChooseRoom);
            // IReadOnlyCollection<IWebElement> chooseRooms = getWebElements(btnChooseRoom);
            //Console.WriteLine("Rooms" + chooseRooms.Count());
            GetListOfHotels();
            WebElementWrapper.Click(ListOfHotels.ElementAt(1));
            //chooseRooms.ElementAt(1).Click();
           // moveToElementAndClick(chooseRooms.ElementAt(1));
            return new HotelBookRoomPage();
        }
        public int ListOfSearchResults()
        {
            GetListOfHotels();            
            return ListOfHotels.Count();


        }

        public void SortHotelSearch(String filterCriteria)
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
