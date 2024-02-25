using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAutomation
{
    public class Ebay
    {
        ChromeDriver driver;
        public void Navigate_to_Ebay()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.ebay.co.uk/");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
        }

        public void Search_On_Ebay(string searchText) 
        {
            driver.FindElement(By.Name("_nkw")).SendKeys(searchText);
            driver.FindElement(By.Id("gh-btn")).Click();
        }

        public void FindingElements(int NoOfElements) 
        {
            List<IWebElement> SearchedreturnedItems = driver.FindElements(By.CssSelector("span[role='heading']")).ToList();
            Console.WriteLine();
            for (int i = 1; i <= NoOfElements; i++) 
            {
                string Item = SearchedreturnedItems[i].Text;
                Console.WriteLine(Item);
            }

            //string Item1 = SearchedreturnedItems[1].Text;
            //Console.WriteLine(Item1);
            //string Item2 = SearchedreturnedItems[2].Text;
            //Console.WriteLine(Item2);
            //string Item3 = SearchedreturnedItems[3].Text;
            //Console.WriteLine(Item3);
            //string Item4 = SearchedreturnedItems[4].Text;
            //Console.WriteLine(Item4);
            //string Item5 = SearchedreturnedItems[5].Text;
            //Console.WriteLine(Item5);
        }
    }
}
