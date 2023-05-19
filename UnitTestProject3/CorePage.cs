using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject3
{
    internal class CorePage
    {
        public static IWebDriver driver;

        public static void SeleniumInit(string browser)
        {
            if (browser == "Chrome")
            {
                var ChromeOptions = new ChromeOptions();
                ChromeOptions.AddArguments("--start-maximized");
                ChromeOptions.AddArguments("--incognito");
                IWebDriver chromeDriver = new ChromeDriver(ChromeOptions);
                driver = chromeDriver;
            }
            else if (browser == "FireFox")
            {
                FirefoxOptions options = new FirefoxOptions();
                options.AddArguments("");
                driver = new FirefoxDriver(options);
            }
            else if (browser == "MicrosoftEdge")
            {
                var options = new OpenQA.Selenium.Edge.EdgeOptions();
                var service = EdgeDriverService.CreateDefaultService(@"C:\Users\shahr\source\repos\DATA DRIVEN YT PROJ\DATA DRIVEN YT PROJ\bin\Debug", @"C:\Program Files (x86)\Microsoft\Edge\Application\msedge.exe");
                service.Start();
                driver = new RemoteWebDriver(service.ServiceUrl, options);
            }

        }
    }
}
