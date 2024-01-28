using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAutomation
{
    class Program
    {
        ChromeDriver driver;


        static void Main(string[] args)
        {
            Program obj = new Program();
            obj.seleniumBasicCommandsforPageNavigation();
            obj.findingelementsandperformormingActions();

        }

        public void seleniumBasicCommandsforPageNavigation() 
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.youtube.com/");

            driver.Navigate().GoToUrl("https://demo.guru99.com/v4/");
            //to go to thw url of the webpage

            driver.Navigate().Back();
            //to go to back from the current page

            driver.Navigate().Forward();
            //to go to Forward from the current page

            driver.Navigate().Refresh();
            //it reloads a page
        }

        public void findingelementsandperformormingActions() 
        {
            Thread.Sleep(5000);
            IWebElement userIDelement = driver.FindElement(By.Name("uid"));
            userIDelement.Click();
            userIDelement.SendKeys("mngr47659");

            IWebElement passwordElement = driver.FindElement(By.Name("password"));
            passwordElement.Click();
            passwordElement.SendKeys("12345@125");

            IWebElement loginIDElement = driver.FindElement(By.Name("btnLogin"));
            loginIDElement.Click();

            IWebElement NewcustomerLink = driver.FindElement(By.LinkText("New Customer"));

           // IWebElement exampleelemenr = driver.FindElement(By.PartialLinkText("Customer"));
            NewcustomerLink.Click();
        }

        // class is a prototype (blue print)  class defines how a prototype or blue print should be
        // object is an instance of a class 
        //  
    }
}
