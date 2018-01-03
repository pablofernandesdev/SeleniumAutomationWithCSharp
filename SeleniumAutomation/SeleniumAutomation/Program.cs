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
        
        IWebDriver driver = new ChromeDriver();
        static void Main(string[] args)
        {

        }

        [SetUp]
        public void Initialize()
        {
            
            driver.Navigate().GoToUrl("http://www.executeautomation.com/demosite/index.html");
            Console.WriteLine("Acessando o site");
        }

        [Test]
        public void ExecuteTest()
        {
            SeleniumSetMethods.EnterText(driver, "Initial", "pablo", "Name");
            SeleniumSetMethods.SelectDropDown(driver, "TitleId", "Mr.", "Id");
            SeleniumSetMethods.Click(driver, "Save", "Name");

            Thread.Sleep(10000);

            Console.WriteLine("Valor do campo Initial" + SeleniumGetMethods.GetText(driver, "Initial", "Name"));
            Console.WriteLine("Valor do campo TitleID" + SeleniumGetMethods.GetText(driver, "TitleId", "Id"));


        }

        [TearDown]
        public void CleanUp()
        {
            driver.Quit();
            Console.WriteLine("Fechando o browser");
        }

    }
    
}
