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
    class FinancialDetailsPage
    {
           
        public FinancialDetailsPage() //constructor to initialise the webdriver and the page elements

           {
               PageFactory.InitElements(BrowserFactory.driver, this);

           }

           //Locator for Purchase Price
           [FindsBy(How = How.Name, Using = "purchasePrice")]
           public IWebElement txtPurchasePrice;

           //Locator for Mortgage
           [FindsBy(How = How.Name, Using = "mortgagePrice")]
           public IWebElement txtMortgage;

        //Locator for Home Value
        [FindsBy(How = How.XPath, Using = "//input[@name= 'propertyName' and @data-bind=\"value: CurrentHomeValue, valueUpdate:'afterkeydown'\"]")]
           public IWebElement txtHomeValue;


           //Locator for Amount Repayment
           [FindsBy(How = How.XPath, Using = "//input[@placeholder='Repayments']")]
           public IWebElement txtRepaymentAmt;

           //Locator for repayment start date
           [FindsBy(How = How.Id, Using = "payment-start-date")]
           public IWebElement txtRepaymentStartDate;


           //Locator for repayment end date
        //   [FindsBy(How = How.Id, Using = "")]
         //  public IWebElement txtRepaymentEndDate;


           //Locator for expense amount
           [FindsBy(How = How.XPath, Using = "//input[@placeholder='Expenses']")]
           public IWebElement txtExpenseAmt;

           //Locator for expense Description
           [FindsBy(How = How.XPath, Using = "//input[@placeholder='Description']")]
           public IWebElement txtExpenseDesc;

           //Locator for expense Datee
           [FindsBy(How = How.Id, Using = "expense-date")]
           public IWebElement txtExpenseDate;

        //Locator for Add Repayment button
        [FindsBy(How = How.XPath, Using = "//a[@data-bind=\"click: addRepayment\"]")]
        public IWebElement btnAddRepay;
            

           //Locator for Remove Repayment button
           [FindsBy(How = How.XPath, Using = "//span[@data-bind=\"click:$root.removeRepayment\"]")]
           public IWebElement btnRemoveRepay;

           //Locator for Add Expense Button
           [FindsBy(How = How.XPath, Using = "//a[@data-bind=\"click: addExpense\"]")]
           public IWebElement btnAddExpense;

           //Locator for Remove Expense Button
           [FindsBy(How = How.XPath, Using = "//span[@data-bind=\"click:$root.removeExpense\"]")]
           public IWebElement btnRemoveExpense;


           //Locator for Previous Button
           [FindsBy(How = How.XPath, Using = "//button[@data-bind='click:goP']")]
           public IWebElement btnPrevious;

        //Locator for Next Button
       
        [FindsBy(How = How.XPath, Using = "//div[@class='sixteen wide column text-center']//button[@name='next' and @class='ui teal button']")]
           public IWebElement btnNext;

           //Locator for Cancel Button
           [FindsBy(How = How.XPath, Using = "//div[@class='sixteen wide column text-center']//input[@onclick=\"location.href = '/PropertyOwners'\"]")]
           public IWebElement btnCancel;


        //Enter the financial details
        public void EnterFinancials(Int32 pprice, Int32 mprice, Int32 hvalue)
        {
            txtPurchasePrice.SendKeys(Convert.ToString(pprice));
            System.Threading.Thread.Sleep(1000);
            txtMortgage.SendKeys(Convert.ToString(mprice));
            System.Threading.Thread.Sleep(1000);
            txtHomeValue.SendKeys(Convert.ToString(hvalue));
            System.Threading.Thread.Sleep(1000);

        }

        //Enter the repayment details
        public void EnterRepayments(Int32 repayment, string repaystart)
        {
            txtRepaymentAmt.SendKeys(Convert.ToString(repayment));
            System.Threading.Thread.Sleep(1000);
            txtRepaymentStartDate.SendKeys(repaystart);
            System.Threading.Thread.Sleep(1000);
        }

        //Enter the expense details
        public void EnterExpense(Int32 expenseamt, string expensedesc, string expensedate)
        {
            txtExpenseAmt.SendKeys(Convert.ToString(expenseamt));
            txtExpenseDesc.SendKeys(expensedesc);
            txtExpenseDate.SendKeys(expensedate);
          
        }


        public void click(Boolean brepay, Boolean bexpense, Boolean bnext)
        {
            if (brepay)
            {
                btnAddRepay.Click();
                brepay = false;
            }

            if (bexpense)
            {
                btnAddExpense.Click();
                bexpense = false;
            }

            if (bnext)
            {
                btnNext.Click();
                bnext = false;
            }


        }

    }


}
