using com.keyswebsite_test.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using testspecflow.Features.Pages;
using testspecflow.Utility;
using NUnit.Framework;

namespace testspecflow
{
    [Binding]
    public class ListRentalsSteps
    {

       
        //Launch the browser and navigate to the keys website
        [Given(@"user is in the application")]
        public void GivenUserIsInTheApplication()
        {
           // IWebDriver driver = BrowserFactory.BrowserInit();

        }
        
        [Given(@"user logs in the applicatipn by typing  ""(.*)"", ""(.*)""")]
        public void GivenUserLogsInTheApplicatipnByTyping(string username, string password)
        {
            //create the object of the LoginPage
            LoginPage page = new LoginPage();
            page.Login(username, password);
            page.clickLogin();

            //create the object of the CommonPage
            CommonPage pageproperties = new CommonPage();
            pageproperties.clickOwners();


        }

        [When(@"user clicks on list rentals button and types ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"",""(.*)"", ""(.*)"" and click Save button")]
        public void WhenUserClicksOnListRentalsButtonAndTypesAndClickSaveButton(string property, string title, string Desc, int cost, int rent, string date, int count, string petsallowed)
        {
            //create the object of the OwnersPage
            OwnersPage PageOwners = new OwnersPage();
            PageOwners.clickListARental();

            //create the object of the ListARental Page
            ListARental PageListRental = new ListARental();
            PageListRental.dataentry(property, title, Desc, cost, rent, date, count, petsallowed);

            System.Threading.Thread.Sleep(3000);

            //  Click on the save button

            PageListRental.click(true, false);
            System.Threading.Thread.Sleep(4000);
        }

        [Then(@"users property is listed as rental\.")]
        public void ThenUsersPropertyIsListedAsRental_()
        {
            //BrowserFactory.Close();
        }

     

              
    }
}
