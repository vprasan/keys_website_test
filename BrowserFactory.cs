using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testspecflow.Utility
{
    public static class BrowserFactory
    {
        public static IWebDriver driver = null;

        public static IWebDriver BrowserInit ()
        {
            if (driver==null)
            {
                switch (ConfigFile.Browser.browserName)
                {
                    case "Chrome":
                        driver = new ChromeDriver(@"C:\Users\vprasan\Downloads\chromedriver_win32 (1)");
                        break;
                    case "IE":
                        driver = new InternetExplorerDriver();
                        break;
                    case "Firefox":
                        driver = new FirefoxDriver();
                        break;
                    default:
                        driver = new ChromeDriver(@"C:\Users\vprasan\Downloads\chromedriver_win32 (1)");
                        break;
                }

            }
           

            driver.Manage().Window.Maximize();
            driver.Url = ConfigFile.url.app_url;
           
            return driver;
        }


        public static string Title()
        {
            return driver.Title; 
        }
       
        
        public static void Close()
        {
            driver.Quit();
            driver = null;
    

        }

    }
}
