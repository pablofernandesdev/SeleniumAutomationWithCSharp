using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
            
            driver.Navigate().GoToUrl("http:\\www.google.com");
            Console.WriteLine("Acessando o site");
        }

        [Test]
        public void ExecuteTest()
        {
            
            IWebElement element = driver.FindElement(By.Name("q"));
            element.SendKeys("executeautomation");
            Console.WriteLine("Realizando a pesquisa");
            //teste pra saber o que vai dar
        }

        [TearDown]
        public void CleanUp()
        {
            driver.Quit();
            Console.WriteLine("Fechando o browser");
        }

    }
    
}
