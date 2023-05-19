using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace UnitTestProject3.hhoteladactin.SearchHotelPage
{
    internal class SearchPage : CorePage
    {
        #region Locators 
        By locationDropDown = By.Id("location");
        By hotelDropDown = By.Id("hotels");
        By roomTypeDropDown = By.Id("room_type");
        By noOfRoomDropDown = By.Id("room_nos");
        By checkInDateTxt = By.Id("datepick_in");
        By checkoutDateTxt = By.Id("datepick_out");
        By adultPerRoomDropDown = By.Id("adult_room");
        By childrenPerRoomDropDown = By.Id("child_room");
        By searchBtn = By.Id("Submit");
        By resetBtn = By.Id("Reset");
        #endregion

        public void SearchHotel()
        {
            Thread.Sleep(2000); // add a wait before interacting with the element
            driver.FindElement(locationDropDown).SendKeys("Sydney");
            driver.FindElement(hotelDropDown).SendKeys("Hotel Hervey");
            driver.FindElement(roomTypeDropDown).SendKeys("Standard");
            driver.FindElement(noOfRoomDropDown).SendKeys("2 - Two");
            driver.FindElement(checkInDateTxt).SendKeys("08/07/2021");
            driver.FindElement(checkoutDateTxt).SendKeys("09/07/2021");
            driver.FindElement(adultPerRoomDropDown).SendKeys("2 - Two");
            driver.FindElement(childrenPerRoomDropDown).SendKeys("2 - Two");
            driver.FindElement(searchBtn).Click();
        }
    }
}
