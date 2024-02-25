using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.DevTools.V119.DOM;

namespace WebAutomation
{
    class Program
    {
        ChromeDriver driver;
        ChromeDriver driver2;
       
        static void Main(string[] args)
        {
            Program obj = new Program();
            //obj.seleniumBasicCommandsforPageNavigation();
            //obj.findingelementsandperformormingActions();
            //string CustID = obj.newcustomer();
            //obj.editcustomerid(CustID);
            //obj.editcustomeridPage();
            //obj.DeleteCustumer(CustID);
          //  Program obj2 = new Program();
            //obj2.linkedin();
            Program obj4 = new Program();
             obj4.linkedin();
           // obj4.udemylogin();
        }
          
        public void seleniumBasicCommandsforPageNavigation() 
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://demo.guru99.com/v4/");
            //to go to thw url of the webpage

        }

        public void findingelementsandperformormingActions() 
        {
            IWebElement userIDelement = driver.FindElement(By.Name("uid"));
            userIDelement.Click();
            userIDelement.SendKeys("mngr47659");

            IWebElement passwordElement = driver.FindElement(By.Name("password"));
            passwordElement.Click();
            passwordElement.SendKeys("12345@125");

            IWebElement loginIDElement = driver.FindElement(By.Name("btnLogin"));
            loginIDElement.Click();


        }

        //class is a prototype(blue print)  class defines how a prototype or blue print should be
        // object is an instance of a class




        public string newcustomer()
        {
            IWebElement newCustomerLink = driver.FindElement(By.LinkText("New Customer"));
            newCustomerLink.Click();
            Thread.Sleep(5000);
            IWebElement customernameElement = driver.FindElement(By.Name("name"));
            customernameElement.Click();
            customernameElement.SendKeys("narasimha");
            IWebElement genderElement = driver.FindElement(By.Name("rad1"));
            genderElement.Click();
            driver.FindElement(By.Id("dob")).SendKeys("27011995");
            IWebElement addressElement = driver.FindElement(By.Name("addr"));
            addressElement.Click();
            addressElement.SendKeys("mehernagar rd no 3");
            IWebElement cityElement = driver.FindElement(By.Name("city"));
            cityElement.Click();
            cityElement.Clear();
            cityElement.SendKeys("karimnagar");
            IWebElement stateElement = driver.FindElement(By.Name("state"));
            stateElement.Click();
            stateElement.Clear();
            stateElement.SendKeys("telangana");
            IWebElement pincodeElement = driver.FindElement(By.Name("pinno"));
            pincodeElement.Click();
            pincodeElement.Clear();
            pincodeElement.SendKeys("505001");
            IWebElement numberElement = driver.FindElement(By.Name("telephoneno"));
            numberElement.Click();
            numberElement.Clear();
            numberElement.SendKeys("6281438142");
            IWebElement emailElement = driver.FindElement(By.Name("emailid"));
            emailElement.Click();
            emailElement.Clear();
            emailElement.SendKeys("saikirangca154@gmail.com");
            IWebElement customerpasswordElemnt = driver.FindElement(By.Name("password"));
            customerpasswordElemnt.Click();
            customerpasswordElemnt.Clear();
            customerpasswordElemnt.SendKeys("sai@2272");

            IWebElement resetElement = driver.FindElement(By.Name("sub"));
            resetElement.Click();
            string cusID = driver.FindElement(By.XPath("//table[@id='customer']/tbody/tr[4]/td[2]")).Text;
            return cusID;
        }

        // Customer numbwe = 9232
        public void editcustomerid(string cusID) 
        {
            Thread.Sleep(5000);
            IWebElement editcustomerLink = driver.FindElement(By.LinkText("Edit Customer"));
            IWebElement exampleelemenr = driver.FindElement(By.PartialLinkText("Customer"));
            editcustomerLink.Click(); 
            IWebElement customerIDElement = driver.FindElement(By.Name("cusid"));
            customerIDElement.Click();
            customerIDElement.SendKeys(cusID);
            IWebElement submetElement = driver.FindElement(By.Name("AccSubmit"));
            submetElement.Click();
        }

        public void editcustomeridPage() 
        {
            IWebElement editAddressElement = driver.FindElement(By.Name("addr"));
            editAddressElement.Click(); 
            editAddressElement.Clear();
            editAddressElement.SendKeys("seetharampur");
            IWebElement editcityElement = driver.FindElement(By.Name("city"));
            editcityElement.Click();
            editcityElement.Clear();
            editcityElement.SendKeys("hyderabad");
            IWebElement editElement = driver.FindElement(By.Name("pinno"));
            editElement.Click();
            editElement.Clear();
            editElement.SendKeys("500084");
            IWebElement editmobileELement = driver.FindElement(By.Name("telephoneno"));
            editmobileELement.Click();
            editmobileELement.Clear();
            editmobileELement.SendKeys("7097068454");
            IWebElement submetElement = driver.FindElement(By.Name("sub"));
            submetElement.Click();
        }

        public void DeleteCustumer(string cusID) 
        {
            Thread.Sleep(5000); 
            driver.FindElement(By.LinkText("Delete Customer")).Click();
            Thread.Sleep(3000);
            driver.FindElement(By.Name("cusid")).SendKeys(cusID);
            driver.FindElement(By.Name("AccSubmit")).Click();
        }

        public void linkedin() 
        {
            driver2 = new ChromeDriver();
            driver2.Navigate().GoToUrl("https://www.linkedin.com/home");
            IWebElement linkedinloginelement = driver2.FindElement(By.Name("session_key"));
            linkedinloginelement.Click();
            linkedinloginelement.SendKeys("saikiranpeddapally@outlook.com");
            IWebElement loginpasswordelement = driver2.FindElement(By.Id("session_password"));
            loginpasswordelement.Click();
            loginpasswordelement.SendKeys("Mando@2272");
            IWebElement linkedinloginbuttonelement = driver2.FindElement(By.CssSelector("button[data-id='sign-in-form__submit-btn']"));
            linkedinloginbuttonelement.Click();
        }

        ChromeDriver driver3;
        public void udemylogin() 
        {
            driver3= new ChromeDriver();
            driver3.Navigate().GoToUrl("https://www.udemy.com/join/login-popup/?locale=en_US&next=https%3A%2F%2Fwww.udemy.com%2Fjoin%2Flogin-popup%2F&response_type=html&skip_suggest=1");
            IWebElement udemyloginelement = driver3.FindElement(By.Name("email"));
            udemyloginelement.Click();
            udemyloginelement.SendKeys("saikiran@gmail.com");
            IWebElement udemypasswordelement = driver3.FindElement(By.Name("password"));
            udemypasswordelement.Click();
            udemypasswordelement.SendKeys("Mando@2272");
            IWebElement udemyloginbuttonelement = driver3.FindElement(By.CssSelector("button[class='ud-btn ud-btn-large ud-btn-brand ud-heading-md helpers--auth-submit-button--W3Tqk ']"));
            udemyloginbuttonelement.Click() ;
        }

        ChromeDriver driver4;
        public void youtubeplayer() 
        {
            driver4= new ChromeDriver();
            driver4.Navigate().GoToUrl("https://www.youtube.com/");
            IWebElement YoutubeElement = driver4.FindElement(By.Name("search_query"));
            YoutubeElement.Click();
            YoutubeElement.SendKeys("leo telugu trailer");
            IWebElement YoutubeserchElement = driver4.FindElement(By.Id("search-icon-legacy"));
            YoutubeserchElement.Click();
            Thread.Sleep(3000);
            IWebElement YoutubeLeoElement = driver4.FindElement(By.ClassName("style-scope ytd-video-renderer"));
        }
    }
}
