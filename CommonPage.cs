//using Baseclass.Contrib.SpecFlow.Selenium.NUnit.Bindings;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using testspecflow.Utility;

namespace testspecflow.Features.Pages
{
    class CommonPage
    {
       // public CommonPage(IWebDriver driver) //constructor to initialise the webdriver.
        public CommonPage()

        {
            PageFactory.InitElements(BrowserFactory.driver, this);       

        }

               
        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Skip')]")]
        public IWebElement btnSkip;
        

        [FindsBy(How = How.XPath, Using = "//div[contains(text(),'Owners')]")]
        public IWebElement btnOwner;

        [FindsBy(How = How.LinkText, Using = "Properties")]
        public IWebElement btnProperties;


        public void clickOwners()
        {
            if (btnSkip.Displayed)
            {
                btnSkip.Click();
            }
            
           
            System.Threading.Thread.Sleep(5000);
            btnOwner.Click();
            System.Threading.Thread.Sleep(5000);
            btnProperties.Click();
         

        }



    }



}

