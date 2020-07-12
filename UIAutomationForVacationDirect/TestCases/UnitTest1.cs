using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using System;
using System.Threading;
using UIAutomationForVacationDirect.Pages;
using UIAutomationFramework.Base;

namespace UIAutomationForVacationDirect
{
    [TestClass]
    public class UnitTest1
    {
       // public IWebDriver driver;   
       
        [SetUp]
        public void SetupTest()
        {
            new HookInitialize();

        }
        
        [Test]
        public void TestMethod()
        {
            LandingPage lp = new LandingPage();
            HotelSearchPage hsp = lp.clickHotel();
            HotelSearchResultsPage hsrp = hsp.SearchForHotels("New York City", 0, 29);
            int[] filter = { 5 };
            hsrp.filterHotelResults(filter);
            //Thread.Sleep(10000);
            HotelBookRoomPage hbrp = hsrp.chooseRoom();
            int noOfRooms = hbrp.listOfAvailableRooms();
            Console.WriteLine("RoomsAvailable" + noOfRooms.ToString());
        }

        [TearDown]
        public void TearDownTest()
        {
            Thread.Sleep(10000);
            BasePage basePage = new BasePage();
            basePage.TearDown();

        }
    }
}
