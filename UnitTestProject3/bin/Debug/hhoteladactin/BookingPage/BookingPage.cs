using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject3.hhoteladactin.BookingPage
{
    internal class BookingPage : CorePage
    {
        #region locators
        By fnameTxt = By.Id("first_name");
        By lnameTxt = By.Id("last_name");
        By addressTxt = By.Id("address");
        By cCNoTxt = By.Id("cc_num");
        By cCTypeDropDown = By.Id("cc_type");
        By expiryDateDropDown = By.Id("cc_exp_month");
        By expiryYearDropDown = By.Id("cc_exp_year");
        By cVVNoTxt = By.Id("cc_cvv");
        By bookNowBtn = By.Id("book_now");
        By cancelBtn = By.Id("cancel");
        By orderNoTxt = By.Id("order_no");

        #endregion
        public void BookHotel()
        {
            driver.FindElement(fnameTxt).SendKeys("Sami");
            driver.FindElement(lnameTxt).SendKeys("Baig");
            driver.FindElement(addressTxt).SendKeys("A111,Jauhar,Karachi ");
            driver.FindElement(cCNoTxt).SendKeys("03332211010");
            driver.FindElement(cCTypeDropDown).SendKeys("VISA");
            driver.FindElement(expiryDateDropDown).SendKeys("April");
            driver.FindElement(expiryYearDropDown).SendKeys("2023");
            driver.FindElement(cVVNoTxt).SendKeys("1234");

            driver.FindElement(bookNowBtn).Click();
        }
    }
}