using Dynamitey;
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
        public LandingPage landingPage;
        public HotelSearchPage hotelSearchPage;
        public HotelSearchResultsPage hotelSearchResultsPage;
        public HotelBookRoomPage hotelBookRoomPage;

        [Given(@"I launch a '(.*)' Browser")]
        public void GivenILaunchABrowser(string browserType)
        {
            //BrowserType browserType1;

            HookInitialize hookInitialize = new HookInitialize(BrowserType.Chrome);
            //ScenarioContext.Current.Pending();


        }

        [Given(@"open a website using url '(.*)'")]
        public void GivenOpenAWebsiteUsingUrl(string url)
        {
            DriverContext.Driver.Url = url;

        }

        [Given(@"I have navigated to the application")]
        public void GivenIHaveNavigatedToTheApplication()
        {
            //ScenarioContext.Current.Pending();
        }

        [Given(@"I click on Hotel button")]
        public void GivenIClickOnHotelButton()
        {
            //ScenarioContext.Current.Pending();
            landingPage = new LandingPage();
            hotelSearchPage = landingPage.clickHotel();

        }

        [Given(@"I enter city, future check in date, check out date and click on search for hotels button")]
        public void GivenIEnterCityFutureCheckInDateCheckOutDateAndClickOnSearchForHotelsButton(Table table)
        {
            dynamic data = table.CreateDynamicInstance();
            hotelSearchResultsPage = hotelSearchPage.SearchForHotels(data.city, data.checkInDay, data.checkOutDay);
        }  
            

        [Then(@"Hotel Search Results are displayed")]
        public void ThenHotelSearchResultsAreDisplayed()
        {
            //ScenarioContext.Current.Pending();
        }

        [Then(@"I Filter Hotel Search Results based on Star Rating")]
        public void ThenIFilterHotelSearchResultsBasedOnStarRating(Table table)
        {
            List<int> data =new List<int>(Convert.ToInt32(table.CreateDynamicSet()));
            
            hotelSearchResultsPage.filterHotelResults(data);

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
        }
    }
}
