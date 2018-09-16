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
    class LoginPage
    {
       public LoginPage() //constructor to initialise the webdriver.
            
        {
            PageFactory.InitElements(BrowserFactory.driver, this);
            
        }
        
        [FindsBy(How = How.Id, Using = "UserName")]
        public IWebElement txtUserId;


        [FindsBy(How = How.Name, Using = "Password")]
        public IWebElement txtPassword;

        [FindsBy(How = How.XPath, Using = "//*[@id='sign_in']/div[1]/div[4]/button")]
        public IWebElement btnLogin;


        public void Login(string username, string password)
        {
            txtUserId.SendKeys(username);
            txtPassword.SendKeys(password);

        }

        public void clickLogin()
        {
            btnLogin.Click();
            
        }


        
    }


}
