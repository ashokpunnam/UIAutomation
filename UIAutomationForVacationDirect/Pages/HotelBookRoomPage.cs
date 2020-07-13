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
   public class HotelBookRoomPage:BasePage
    {
        public HotelBookRoomPage() : base()
        {

        }

        private readonly By  btnBookThisRoom = By.XPath("//*[contains(@id, 'description-hotelroom')]");
        private readonly By  bookRoomException = By.XPath("//*[@id='HotelResultContent']/div[1]/div/div/div/div/ul/li");
        //private By hotelRoomsCount = By.Id("hotel-rooms-count");
        //private By hotelRoomsCount = By.XPath("//*[@id='hotel-rooms-count']/strong");

        public int ListOfAvailableRooms()
        {
            IReadOnlyCollection<IWebElement> listOfAvailableRooms = WebElementWrapper.GetWebElements(btnBookThisRoom);
            //Console.WriteLine("Rooms are available for selected hotel :"+(listOfAvailableRooms.Count()));
            return listOfAvailableRooms.Count();
        }

       /* public String HotelRoomsCount()
        {
            //String[] hotelRooms = GetText(hotelRoomsCount).Split(' ');
            //Console.WriteLine("Rooms" + GetText(hotelRoomsCount));

            return GetText(hotelRoomsCount);
        }*/

        public bool RoomsNotAvailable()
        {
            try
            {
                if (driver.FindElement(bookRoomException).Displayed)
                {
                    return true;
                }

            }
            catch
            {
                return false;
            }
            return false;
            
            
        }

    }
}
