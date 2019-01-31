using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using NUnit.Framework;
using System.Threading;


namespace Qautomation.Selenium_Basics
{
    class FindsElements
    {
        IWebDriver driver;
        int i = 0;
        [Test]
        public void FindSomeExample()
        {
            driver = new FirefoxDriver();

            driver.Url = "http://localhost/motorservice/contact/";

            // vvod imenni 
            IWebElement Name_nm = driver.FindElement(By.Name("your-name"));
            
            //
            IWebElement Name_em = driver.FindElement(By.Name("your-email"));
           

            //
            IWebElement Name_sb = driver.FindElement(By.Name("your-subject"));
            
            //
            IWebElement Name_ms = driver.FindElement(By.Name("your-message"));

            // searchin button and click

            IWebElement Button_AC = driver.FindElement(By.ClassName("wpcf7-submit"));
            while (i < 33)
            {
                i++;
                Name_nm.SendKeys("Nikolay Golovko");
                Name_em.SendKeys("Golovko@gamail.com");
                Name_sb.SendKeys("Nikolay Golovko");
                Name_ms.SendKeys("Nikolay Golovko");
                Button_AC.Click();
                Thread.Sleep(5000);
            }
            

            
            


            Thread.Sleep(5000);
            driver.Close();
        }



    }
}
