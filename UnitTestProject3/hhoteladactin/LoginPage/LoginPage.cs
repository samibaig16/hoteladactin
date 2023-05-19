using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject3.hhoteladactin.LoginPage
{


    internal class LoginPage : CorePage
    {
        By usernameTxt = By.Id("username");
        By passwordTxt = By.Id("password");
        By loginBtn = By.Id("login");
        public void Login(string url, string user, string pass)
        {

            driver.Url = url;
            driver.FindElement(usernameTxt).SendKeys(user);
            driver.FindElement(passwordTxt).SendKeys(pass);
            driver.FindElement(loginBtn).Click();
        }
    }
}

