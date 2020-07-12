using Dynamitey;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using UIAutomationForVacationDirect.Pages;
using UIAutomationFramework.Base;

namespace UIAutomationForVacationDirect.StepDefinitions
{
    [Binding]
    public class HotelSearchSteps
    {
        public HookInitialize hookInitialize;
        public LandingPage landingPage;
        public HotelSearchPage hotelSearchPage;
        public HotelSearchResultsPage hotelSearchResultsPage;
        public HotelBookRoomPage hotelBookRoomPage;
        
       // [BeforeScenario]
        [Given(@"I launch a '(.*)' Browser")]
        public void GivenILaunchABrowser(string browserType)
        {
            //BrowserType browserType1;
            BrowserType BrowserType;
            Enum.TryParse(browserType, out BrowserType);

            hookInitialize = new HookInitialize(BrowserType);
            //ScenarioContext.Current.Pending();


        }

        //[BeforeScenario]
        [Given(@"open a website using url '(.*)'")]
        public void GivenOpenAWebsiteUsingUrl(string url)
        {
            DriverContext.Driver.Url = url;

        }

        [Given(@"I have navigated to the application")]
        public void GivenIHaveNavigatedToTheApplication()
        {
            //ScenarioContext.Current.Pending();
            landingPage = new LandingPage();
            Assert.AreEqual(landingPage.getHomePageIcon(), "VacationsDirect");
        }

        [Given(@"I click on Hotel button")]
        public void GivenIClickOnHotelButton()
        {
            //ScenarioContext.Current.Pending();            
            hotelSearchPage = landingPage.clickHotel();

        }

        [Given(@"I enter city: '(.*)', future check in date: '(.*)', check out date: '(.*)' and click on search for hotels button")]
        public void GivenIEnterCityFutureCheckInDateCheckOutDateAndClickOnSearchForHotelsButton(string city, string checkInDay, string checkOutDay)
        {            
            hotelSearchResultsPage = hotelSearchPage.SearchForHotels(city, int.Parse(checkInDay), int.Parse(checkOutDay));
        }  
            

        [Then(@"Hotel Search Results are displayed")]
        public void ThenHotelSearchResultsAreDisplayed()
        {
            //int noOfHotels = hotelSearchResultsPage.ListOfSearchResults();
            //Assert.IsNotNull(hotelSearchResultsPage.ListOfSearchResults());
            Console.WriteLine("Hotel Search Results"+hotelSearchResultsPage.ListOfSearchResults());
            //ScenarioContext.Current.Pending();
        }

        [Then(@"I Filter Hotel Search Results based on Star Rating: '(.*)'")]
        public void ThenIFilterHotelSearchResultsBasedOnStarRating(string starRating)
        {            

            List<int> listStarRating = new List<int>();
            listStarRating.Add(int.Parse(starRating));
            hotelSearchResultsPage.filterHotelResults(listStarRating);

        }

        [Then(@"I selected a hotel from the Search Results")]
        public void ThenISelectedAHotelFromTheSearchResults()
        {
            //ScenarioContext.Current.Pending();
            hotelBookRoomPage = hotelSearchResultsPage.chooseRoom();
        }

        [Then(@"I see available rooms")]
        public void ThenISeeAvailableRooms()
        {
            //ScenarioContext.Current.Pending();
            if (hotelBookRoomPage.RoomsNotAvailable())
            {
                Console.WriteLine("No Rooms available for selected hotel. Please select different hotel");
            }
            else
            {
                Console.WriteLine(hotelBookRoomPage.listOfAvailableRooms()+" Rooms are available for the selected hotel");
            }
        }

        [AfterScenario]
        public void QuitBrowser()
        {
            hookInitialize.CloseBrowser();
        }
    }
}
