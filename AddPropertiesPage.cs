//using Baseclass.Contrib.SpecFlow.Selenium.NUnit.Bindings;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using testspecflow.Utility;

namespace com.keyswebsite_test.Pages
{

    class AddPropertiesPage
    {

        public AddPropertiesPage()
        {

            PageFactory.InitElements(BrowserFactory.driver, this);

        }

        //Locator for preoperty name
        [FindsBy(How = How.Name, Using = "propertyName")]
        public IWebElement txtPropertyName;

        //Locator for preoperty type
        [FindsBy(How = How.XPath, Using = "//*[@id='property-details']/div[2]/div[2]/div/div[1]")]
        public IWebElement txtPropertyType;

        //Locator for preoperty select
        [FindsBy(How = How.XPath, Using = "//*[@id='property-details']/div[2]/div[2]/div/div[2]/div[3]")]
        public IWebElement txtPropertyTypeSelect;



        //Locator for Address
        //  [FindsBy(How = How.Name, Using = "searchAddress")]
        // public IWebElement txtAddress;


        //input[@id='street_number' and @data-bind="value: Address.Number, valueUpdate:'afterkeydown'"]

        //input[@data-bind="value: Address.Number, valueUpdate:'afterkeydown'"]

        //Locator for Street Number
        [FindsBy(How = How.XPath, Using = "//input[@id='street_number']")]
        public IWebElement txtStreetNumber;


        //Locator for Street Number
        //[FindsBy(How = How.XPath, Using = "//input[@id='street_number' and @data-bind=\"value:Address.Number, valueUpdate:'afterkeydown'\"] +")]
      //  public IWebElement txtStreetNumber;

        
        //Locator for Street
      //  [FindsBy(How = How.XPath, Using = "input[@id='street_number' and @type = 'text' and @data-bind=value: Address.Street, valueUpdate: 'afterkeydown'")]
       // public IWebElement txtRoute;

        //Locator for Street
        [FindsBy(How = How.XPath, Using = "//input[@id='route']")]
         public IWebElement txtRoute;


        //Locator for city
        [FindsBy(How = How.XPath, Using = "//input[@id='street_number' and @data-bind =\"value: Address.City, valueUpdate:'afterkeydown'\"]")]
        public IWebElement txtCity;

       
        //Locator for Post Code
        [FindsBy(How = How.XPath, Using = "//input[@id='street_number' and @data-bind=\"value: Address.PostCode, valueUpdate:'afterkeydown'\"]")]
        public IWebElement txtPostCode;



        //Locator for Region
        [FindsBy(How = How.XPath, Using = "//input[@id='region']")]
        public IWebElement txtRegion;

        
        //Locator for preoperty Description
        [FindsBy(How = How.XPath, Using = "//textarea[@class='add-prop-desc']")]
        public IWebElement txtDescription;

        
        //Locator for Target Rent
        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Rent Amount']")]
        public IWebElement txtRent;

             

        //Locator for number of bedrooms
        [FindsBy(How = How.XPath, Using = "//input[@type='text' and @data-bind=\"value: Bedroom,valueUpdate:'afterkeydown'\"]")]
        public IWebElement txtBedRooms;



        //Locator for number of bath rooms
        [FindsBy(How = How.XPath, Using = "//input[@type='text' and @data-bind=\"value: Bathroom,valueUpdate:'afterkeydown'\"]")]
        public IWebElement txtBathRooms;



        //Locator for number of car parks
        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Number of car parks']")]
        public IWebElement txtCarParks;



        //Locator for Year Built
        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Year Built']")]
        public IWebElement txtYeearBuilt;

        //Locator for Next Button
        [FindsBy(How = How.Name, Using = "next")]
        public IWebElement btnNext;

        //Locator for Cancel Button
        [FindsBy(How = How.XPath, Using = "//*[@id='sign_in']/div[1]/div[4]/button")]
        public IWebElement btnCancel;


        public void dataentry(String property, Int32 streetNumber, String route,String City, Int32 post, string region,string desc,Int32 rent,Int32 bedroom,Int32 bath,Int32 car, Int32 built )
        {
            txtPropertyName.SendKeys(property);
            //  txtAddress.SendKeys(Address);

            System.Threading.Thread.Sleep(1000);
            txtPropertyType.Click();
            System.Threading.Thread.Sleep(1000);
            txtPropertyTypeSelect.Click();
            txtStreetNumber.SendKeys(Convert.ToString(streetNumber));
            txtRoute.SendKeys(route);
            txtCity.SendKeys(City);
            txtPostCode.SendKeys(Convert.ToString(post));
            txtRegion.SendKeys(region);
            txtDescription.SendKeys(desc);
            txtRent.SendKeys(Convert.ToString(rent));
            txtBedRooms.SendKeys(Convert.ToString(bedroom));
            txtBathRooms.SendKeys(Convert.ToString(bath));
            txtCarParks.SendKeys(Convert.ToString(car));
            txtYeearBuilt.SendKeys(Convert.ToString(built)+Keys.Tab);
            
            
        }


        public void click(Boolean bnext, Boolean bcancel)
        {
            if (bnext)
            {
                btnNext.Click();
                bnext = false;
            }

            if (bcancel)
            {
                btnCancel.Click();
                bcancel = false;
            }

        }



    }


}
