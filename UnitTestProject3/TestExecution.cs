using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Configuration;
using UnitTestProject3.hhoteladactin.BookingPage;
using UnitTestProject3.hhoteladactin.LoginPage;
using UnitTestProject3.hhoteladactin.SearchHotelPage;
using UnitTestProject3.NewFolder1.NewFolder4;

namespace UnitTestProject3
{
    [TestClass]
    public class TestExecution
    {
        #region Setups and Cleanups
        public TestContext instance;
        public TestContext TestContext
        {
            set { instance = value; }
            get { return instance; }
        }
        [ClassInitialize()]
        public static void ClassInit(TestContext context)
        {

        }
        [ClassCleanup()]
        public static void ClassCleanup()
        {

        }
        [TestInitialize()]
        public void TestInit()
        {
            CorePage.SeleniumInit(ConfigurationManager.AppSettings["DeviceBrowser"].ToString());
        }
        [TestCleanup()]
        public void TestCleanup()
        {
            CorePage.driver.Close();
        }
        #endregion
        LoginPage loginPage = new LoginPage();
        SearchPage searchPage = new SearchPage();
        SelectPage selectPage = new SelectPage();
        BookingPage bookingPage = new BookingPage();
        [TestCategory("Login")]
        [TestMethod]
        public void LoginWithValidDetails_TC001()
        {
            loginPage.Login("https://adactinhotelapp.com/", "samibaig123", "89O570");
            string actualText = CorePage.driver.FindElement(By.ClassName("welcome_menu")).Text;
            Assert.AreEqual("Welcome to Adactin Group of Hotels", actualText);
        }
        [TestCategory("Assertion using Invalid ID and Password")]
        [TestMethod]
        public void LoginWIthInvalidDetails_TC002()
        {

            loginPage.Login("https://adactinhotelapp.com/", "sammibaig162", "samisami");
            string actualText = CorePage.driver.FindElement(By.ClassName("auth_error")).Text;
            Assert.AreEqual("Invalid Login details or Your Password might have expired. Click here to reset your password", actualText);
        }
        [TestCategory("Search Hotel")]
        [TestMethod]
        public void SearchHotel_TC001()
        {
            loginPage.Login("https://adactinhotelapp.com/", "samibaig123", "89O570");
            searchPage.SearchHotel();
        }
        [TestCategory("Select Hotel")]
        [TestMethod]
        public void SelectHotel_TC001()
        {
            loginPage.Login("https://adactinhotelapp.com/", "samibaig123", "89O570");
            searchPage.SearchHotel();
            selectPage.SelectHotel();
        }
    }
    [TestClass]
    public class unittest2
    {
        #region Setups and Cleanups
        public TestContext instance;
        public TestContext TestContext
        {
            set { instance = value; }
            get { return instance; }
        }
        [ClassInitialize()]
        public static void ClassInit(TestContext context)
        {

        }
        [ClassCleanup()]
        public static void ClassCleanup()
        {

        }
        [TestInitialize()]
        public void TestInit()
        {
            CorePage.SeleniumInit(ConfigurationManager.AppSettings["DeviceBrowser"].ToString());
        }
        [TestCleanup()]
        public void TestCleanup()
        {
            CorePage.driver.Close();
        }
        #endregion
        LoginPage loginPage = new LoginPage();
        SearchPage searchPage = new SearchPage();
        SelectPage selectPage = new SelectPage();
        BookingPage bookingPage = new BookingPage();

        [TestMethod]
        [TestCategory("BookHotel")]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "XMLFile1.xml", "BookHotel_TC001", DataAccessMethod.Sequential)]
        
        public void BookHotel_TC001()
        {
            /*loginPage.Login("https://adactinhotelapp.com/", "samibaig16", "42J991");*/
            //Upper wali line is liye hide ki q ke data driven se data input liya humne xml file se 
            string url = TestContext.DataRow["url"].ToString();
            string user = TestContext.DataRow["username"].ToString();
            string pass = TestContext.DataRow["password"].ToString();
            loginPage.Login(url, user, pass);
            searchPage.SearchHotel();
            selectPage.SelectHotel();
            bookingPage.BookHotel();
        }
    }
}

