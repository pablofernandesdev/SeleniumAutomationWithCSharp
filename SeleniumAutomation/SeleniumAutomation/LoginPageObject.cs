using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumAutomation
{
    class LoginPageObject
    {
        public LoginPageObject()
        {
            PageFactory.InitElements(PropertiesCollection.driver, this);
        }

        //Form Login
        [FindsBy(How = How.Name, Using = "UserName")]
        public IWebElement txtUsername { get; set; }

        [FindsBy(How = How.Name, Using = "Password")]
        public IWebElement txtPassword { get; set; }

        [FindsBy(How = How.Name, Using = "Login")]
        public IWebElement btnLogin { get; set; }

        //Insert in to Login
        public LoginPageObject Login(string userName, string password)
        {
            txtUsername.SendKeys(userName);
            txtPassword.SendKeys(password);
            btnLogin.Submit();

            //return the page object
            return new LoginPageObject();
    }
    }

    
}
