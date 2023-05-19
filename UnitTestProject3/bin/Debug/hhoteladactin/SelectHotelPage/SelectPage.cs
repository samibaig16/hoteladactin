using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject3.NewFolder1.NewFolder4
{
    internal class SelectPage : CorePage
    {
        #region locators
        By selectRadBtn = By.Id("radiobutton_0");
        By continueBtn = By.Id("continue");
        By cancelBtn = By.Id("cancel");

        #endregion
        public void SelectHotel()
        {
            driver.FindElement(selectRadBtn).Click();
            driver.FindElement(continueBtn).Click();

        }
    }
}
