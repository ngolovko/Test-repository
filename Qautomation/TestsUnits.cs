using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System.Threading;


namespace Qautomation
{

           class TestsUnits
    {
        IWebDriver connector;
        
        [SetUp]
        public void initialize ()
        {
              connector = new FirefoxDriver();
        }

        [Test]
        public void OpenAppTest()
        {
            connector.Url = "https://www.toolsqa.com";
            Console.WriteLine("Nunit framimwork is a live");

            string Url = connector.Url;
            Console.WriteLine(Url);

            // exapmle delaym Using System.Threading;
            int milliseconds = 20000;
            Thread.Sleep(milliseconds);
        }

        [TearDown]
        public void output ()
        {
            connector.Close();
           
        }
        


    }
}
