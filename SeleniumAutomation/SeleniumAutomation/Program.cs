using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SeleniumAutomation
{
    class Program
    {
        
        static void Main(string[] args)
        {

        }


        [SetUp]
        public void Initialize()
        {
            PropertiesCollection.driver = new ChromeDriver();

            //Navigate to page
            PropertiesCollection.driver.Navigate().GoToUrl("http://www.executeautomation.com/demosite/index.html");
            Console.WriteLine("Acessando o site");
        }

        [Test]
        public void ExecuteTest()
        {
            //Initialize the page by calling its reference
            EAPageObject page = new EAPageObject();

            //Perform Ops
            page.ddlTitle.SendKeys("Mr.");
            page.txtInitial.SendKeys("Pablo");
            page.btnSave.Click();

            Console.WriteLine("Valor do Title: " + page.ddlTitle.GetAttribute("value"));
            Console.WriteLine("Valor do campo Initial: " + page.txtInitial.GetAttribute("value"));

            Thread.Sleep(5000);

            /*
            SeleniumSetMethods.EnterText("Initial", "pablo", PropertyType.Name);
            SeleniumSetMethods.SelectDropDown("TitleId", "Mr.", PropertyType.Id);
            SeleniumSetMethods.Click("Save", PropertyType.Name);

            Thread.Sleep(10000);

            Console.WriteLine("Valor do campo Initial" + SeleniumGetMethods.GetText("Initial", PropertyType.Name));
            Console.WriteLine("Valor do campo TitleID" + SeleniumGetMethods.GetText("TitleId", PropertyType.Id));
            */

        }

        [TearDown]
        public void CleanUp()
        {
            PropertiesCollection.driver.Quit();
            Console.WriteLine("Fechando o browser");
        }

    }
    
}
