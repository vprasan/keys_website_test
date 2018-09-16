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
    class OwnersPage
        
    {
             
      public OwnersPage() //constructor to initialise the webdriver.

        {
            PageFactory.InitElements(BrowserFactory.driver, this);

        }

        //Locator for Add Prorety button
        [FindsBy(How = How.XPath, Using = "//a[@class='ui teal button' and @href = '/PropertyOwners/Property/AddNewProperty']")]
        public IWebElement btnAddProperty;

        //Locator for List as Rental button
        [FindsBy(How = How.XPath, Using = "//a[@class='ui teal button' and @href = '/PropertyOwners/Property/ListRental?propId=-1&returnUrl=%2FPropertyOwners']")]
        public IWebElement btnListAsRental;

        //Locator for Add Tenant button
        [FindsBy(How = How.LinkText, Using = "Add Tenant")]
        public IWebElement btnAddTenant;

        //Locator for List as Rental second button
        [FindsBy(How = How.LinkText, Using = "List As Rental")]
        public IWebElement btnListAsRental1;

        //Locator for Send Request button
        [FindsBy(How = How.LinkText, Using = "Send Request")]
        public IWebElement btnSendRequest;


        //Locator for sort dropdown
        [FindsBy(How = How.XPath, Using = "//div[@class = 'ui dropdown selection']")]
        public IWebElement ddwsort;

        //Locator for sort dropdown by 'Name'
        [FindsBy(How = How.XPath, Using = "//div[@class='item' and @data-value='/PropertyOwners?SortOrder=Name']")]
        public IWebElement ddwsortName;

        //Locator for sort dropdown by 'Name(Desc)'
        [FindsBy(How = How.XPath, Using = "//div[@class='item' and contains(text(),'Name(Desc)')]")]
        public IWebElement ddwsortNameDesc;

        //Locator for sort dropdown by Latest Date)'
        [FindsBy(How = How.XPath, Using = "//div[@class='item' and contains(text(),'Latest Date')]")]
        public IWebElement ddwsortLatestDate;

        //Locator for sort dropdown by Latest Date)'
        [FindsBy(How = How.XPath, Using = "//div[@class='item' and contains(text(),'Earliest Date')]")]
        public IWebElement ddwsortEarliestDate;


        //Locator for group click locator
        [FindsBy(How = How.XPath, Using = "//i[@class='ui more grey list icon']")]
        public IWebElement ddwgroup;

        //Locator for group ddw item Finance
        [FindsBy(How = How.XPath, Using = "//div[@class='item' and contains(text(),'Finance')]")]
        public IWebElement ddwfinance;

        //Locator for group ddw item Property Details
        [FindsBy(How = How.XPath, Using = "//div[@class='item' and contains(text(),'Property Details')]")]
        public IWebElement ddwPropertyDetails;

        //Locator for group ddw item Manage Tenant
        [FindsBy(How = How.XPath, Using = "//a[@class='default-item-color' and (contains(text(),'Manage Tenant'))]")]
        public IWebElement ddwManageTenant;

        //Locator for group ddw item Edit Property
        [FindsBy(How = How.XPath, Using = "//div[@class='item' and contains(text(),'Edit Property')]")]
        public IWebElement ddwEditProperty;

        //Locator for group ddw item Delete
        [FindsBy(How = How.XPath, Using = "//div[@class='item' and contains(text(),'Delete')]")]
        public IWebElement ddwdelete;

        //Locator Confirm delete
        [FindsBy(How = How.XPath, Using = "//button[@data-bind='click: $root.Delete']")]
        public IWebElement btnConfirmdelete;
        

        public void clickAddProperty()
        {
            System.Threading.Thread.Sleep(2000);
            btnAddProperty.Click();
            System.Threading.Thread.Sleep(3000);
            //  btnListAsRental.Click();
            // btnAddTenant.Click();
            // btnListAsRental1.Click();
            // btnSendRequest.Click();
            //  ddwsort.Click();
            // System.Threading.Thread.Sleep(3000);
            //  ddwsortName.Click();
            // System.Threading.Thread.Sleep(3000);
            // ddwsortNameDesc.Click();
            //  ddwsortLatestDate.Click();
            //  ddwsortEarliestDate.Click();
            //  ddwgroup.Click();
            System.Threading.Thread.Sleep(3000);
         //   ddwfinance.Click();
           // ddwPropertyDetails.Click();
           // ddwManageTenant.Click();
          //  ddwEditProperty.Click();
           //ddwdelete.Click();
        }

        public void clickDeleteProperty()
        {
            System.Threading.Thread.Sleep(2000);
            ddwgroup.Click();
            System.Threading.Thread.Sleep(1000);
            ddwdelete.Click();
            System.Threading.Thread.Sleep(2000);
            btnConfirmdelete.Click();
        }

        public void clickListARental()
        {
            System.Threading.Thread.Sleep(2000);
            btnListAsRental.Click();
            System.Threading.Thread.Sleep(2000);
         }

    }

}
