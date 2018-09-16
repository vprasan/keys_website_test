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

    class ListARental
    {

      
        public ListARental() //constructor to initialise the webdriver.

        {
         
            PageFactory.InitElements(BrowserFactory.driver, this);

        }


        //Locator for preoperty ddw



        // [FindsBy(How = How.XPath, Using = "//div[@class='text']")]
       // [FindsBy(How = How.XPath, Using = "//div[@class='item active selected' and @data-value='13294']")]        
        //public IWebElement ddwproperty;

        [FindsBy(How = How.XPath, Using = "//*[@id='main-content']/div/form/fieldset/div[2]/div/input[2]")]
        public IWebElement ddwproperty;

        [FindsBy(How = How.XPath, Using = "//*[@id='main-content']/div/form/fieldset/div[2]/div/div[2]/div[3]")]
        public IWebElement ddwpropertyselect;



        /*
    public static void select_Property()
    {
        Browser.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        var select_prop_dropdown = Browser.driver.FindElement(By.XPath("//*[@id='main-content']/div/form/fieldset/div[2]/select"));
        Browser.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);

        var select_prop_dropdown_value = new SelectElement(select_prop_dropdown);
        Browser.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
        select_prop_dropdown_value.SelectByText("44 Wonder Street, Sunshine, Broad Day, 9999");
    }
    */




        //Locator for title
        [FindsBy(How = How.XPath, Using = "//input[@data-bind='textInput : Title']")]
        public IWebElement txttitle;

        //Locator for Description
        [FindsBy(How = How.XPath, Using = "//textarea[@data-bind='textInput : RentalDescription']")]
        public IWebElement txtDesc;

        //Locator for Moving Cost
        [FindsBy(How = How.XPath, Using = "//input[@data-bind='textInput : MovingCost']")]
        public IWebElement txtmovingcost;

        //Locator for Rent
        [FindsBy(How = How.XPath, Using = "//input[@data-bind='textInput : TargetRent']")]
        public IWebElement txtRent;


        //Locator for avaialble date
        [FindsBy(How = How.Name, Using = "AvailableDate")]
        public IWebElement txtdate;

      

        //Locator for occupant count
        [FindsBy(How = How.XPath, Using = "//input[@data-bind='textInput : OccupantCount']")]
        public IWebElement txtcount;

        //Locator for pet allowed
        [FindsBy(How = How.XPath, Using = "//select[@data-bind=\"options: PetsAllowedOption, optionsText: 'Choice',optionsValue : 'Choice', value : PetsAllowed\"]")]
        public IWebElement txtpetsallowed;


        //select[@data-bind="\options: PetsAllowedOption, optionsText: 'Choice',optionsValue : 'Choice', value : PetsAllowed\"]

        //Locator for pet allowed "No"
        //[FindsBy(How = How.XPath, Using = "//select[@data-bind=\"options: PetsAllowedOption, optionsText: 'Choice', optionsValue: 'Choice', value: PetsAllowed\"]//option[@value='No']")]
        //public IWebElement txtpetsallowedNo;



        //Locator for Save Button
        [FindsBy(How = How.XPath, Using = "//button[@data-bind='click : SubmitRentalListing,enable:validInput']")]
        public IWebElement btnSave;

        //Locator for Cancel Button
        [FindsBy(How = How.XPath, Using = "//button[@data-bind='click: confirmationModal']")]
        public IWebElement btnCancel;


        public void dataentry(String property, String title, String Desc, Int32 cost, Int32 rent, string date, Int32 count, String petsallowed)
        {
            //  ddwproperty.SendKeys(property);

            System.Threading.Thread.Sleep(1000);
            ddwproperty.Click();

            System.Threading.Thread.Sleep(1000);
            ddwpropertyselect.Click();

            txttitle.SendKeys(title);
            txtDesc.SendKeys(Desc);
            System.Threading.Thread.Sleep(3000);
            txtmovingcost.SendKeys(Convert.ToString(cost));
            txtRent.SendKeys(Convert.ToString(rent));
            txtdate.SendKeys(date);
            txtcount.SendKeys(Convert.ToString(count));
            txtpetsallowed.SendKeys(petsallowed + Keys.Tab);
            //txtYeearBuilt.SendKeys(Convert.ToString(built) + Keys.Tab);


        }


        public void click(Boolean bsave, Boolean bcancel)
        {
            if (bsave)
            {
                btnSave.Click();
                bsave = false;
            }

            if (bcancel)
            {
                btnCancel.Click();
                bcancel = false;
            }

        }



    }


}
