using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System.Threading;
using NUnit.Framework;

namespace Qautomation.Selenium_Basics
{
    class TimeExampleWait
    {
        IWebDriver driver;

        [Test]

        public void waitTest()
        {
            driver = new FirefoxDriver();
            // driver.Url = "http://localhost/litecart";
            driver.Url = "http://google.com";
            driver.FindElement(By.Name("q")).SendKeys("Webdrive");
            Thread.Sleep(10000);
            driver.FindElement(By.Name("btnK")).Click();
           // Console.WriteLine("Test console write");
        
          
            driver.Close();
        }
    
    }
}
