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
    class TenantDetailsPage
    {

    public TenantDetailsPage() //constructor to initialise the webdriver.

        {
            PageFactory.InitElements(BrowserFactory.driver, this);

        }

        //Locator for Tenant Email
        [FindsBy(How = How.Id, Using = "email")]
        public IWebElement txtEmail;

        //Locator for First Name
        [FindsBy(How = How.Id, Using = "fname")]
        public IWebElement txtFirstName;

        //Locator for Last Name
        [FindsBy(How = How.Id, Using = "lname")]
        public IWebElement txtLastName;

        //Locator for Start Date
        [FindsBy(How = How.Id, Using = "sdate")]
        public IWebElement txtStartDate;

        //Locator for End Date
        [FindsBy(How = How.Id, Using = "edate")]
        public IWebElement txtEndDate;


        //Locator for Rent Amount
        [FindsBy(How = How.Id, Using = "ramount")]
        public IWebElement txtramt;

        //Locator for Payment Start Date
        [FindsBy(How = How.Id, Using = "psdate")]
        public IWebElement txtPaymentStartDate;



        //Locator for Save Button

        [FindsBy(How = How.Id, Using = "saveProperty")]
        public IWebElement btnSave;


        //Locator for Previous Button

        [FindsBy(How = How.XPath, Using = "//div[@class='sixteen wide text-center']//button[@id='addProperty']")]
        public IWebElement btnPreviousn;

        //Locator for Cancel Button
        [FindsBy(How = How.XPath, Using = "//div[@class='sixteen wide text-center']//input[@onclick=\"location.href = '/PropertyOwners'\"]")]
        public IWebElement btnCancel;

        //Enter the Tenant details
        public void EnterTenantDetails(string email, string fname, string lname, string sdate, string edate, string ramt, string psdate)
        {
            txtEmail.SendKeys(email);
            txtFirstName.SendKeys(fname);
            txtLastName.SendKeys(lname);
            txtStartDate.SendKeys(sdate);
            txtEndDate.SendKeys(edate);
            txtramt.SendKeys(ramt);
            txtPaymentStartDate.SendKeys(psdate);
        }
          

        public void click(Boolean bprevious, Boolean bcancel, Boolean bsave)

        {
            if (bprevious)
            {
                btnPreviousn.Click();
                bprevious = false;
            }


            if (bcancel)
            {
                btnCancel.Click();
                bcancel = false;
            }

            if (bsave)
            {
                btnSave.Click();
                bsave = false;
            }

        }

    }
}
