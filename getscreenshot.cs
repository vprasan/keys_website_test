using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using System.Drawing.Imaging;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System.Reflection;

namespace testspecflow.Utility
{
    public static class getscreenshot
    {

       
        public static void capture(string screenshotname)
        {

            //  ITakesScreenshot ts = (ITakesScreenshot)ConfigFile.driver;
            // Screenshot screenshot = ts.GetScreenshot();
            //Screenshot ss = ((ITakesScreenshot)ConfigFile.driver).GetScreenshot();

            // string title = ScenarioContext.Current.ScenarioInfo.Title;
            // title = "first";
            //            
            Screenshot screenshot = ((ITakesScreenshot)ConfigFile.driver).GetScreenshot();
            screenshot.SaveAsFile(@"C:\Users\vprasan\source\repos\testspecflow\testspecflow\screenshots\" + screenshotname + ".png", System.Drawing.Imaging.ImageFormat.Png);







        }




    }
}
