using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UIAutomationFramework.Base;

namespace UIAutomationForVacationDirect.Pages
{
   public class HotelBookRoomPage:BasePage
    {
        public HotelBookRoomPage() : base()
        {

        }

        private By btnBookThisRoom = By.XPath("//*[contains(@id, 'description-hotelroom')]");

        public int listOfAvailableRooms()
        {
            IReadOnlyCollection<IWebElement> listOfAvailableRooms = driver.FindElements(btnBookThisRoom);
            return listOfAvailableRooms.Count();
        }

    }
}
