using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
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
            driver.Manage().Window.Maximize();
           driver.Manage().Timeouts().ImplicitWait =  TimeSpan.FromSeconds(10);
            driver.Navigate().GoToUrl("https://www.amazon.in/");
        }
        
        public void closeBrowser() 
        {
            driver.Quit();
        }

        public void SearchOnAmazon() 
        {
            driver.FindElement(By.Id("twotabsearchtextbox")).SendKeys("Watches");
            driver.FindElement(By.Id("nav-search-submit-button")).Click();
        }

        public void findingElementsOnAmazon() 
        {
            List<IWebElement> ListOfSearchReturned  = driver.FindElements(By.XPath("//div[@data-cy='title-recipe']/h2/a")).ToList();
            for (int i = 0; i <= 10; i++)
            {
                ListOfSearchReturned[i].Click();
                addToCart();
            }
        }

        public void addToCart()
        {
            string originalWindow = driver.CurrentWindowHandle;
            //Loop through until we find a new window handle
            foreach (string window in driver.WindowHandles)
            {
                if (originalWindow != window)
                {
                    driver.SwitchTo().Window(window);
                    break;
                }
            }
            List<IWebElement> AddToCart =   driver.FindElements(By.Id("add-to-cart-button")).ToList();
            if (AddToCart.Count == 1)
            {
                AddToCart[0].Click();
                if (IsElementPresent(driver, By.Id("attachSiNoCoverage")))
                {
                    try
                    {
                        driver.FindElement(By.Id("attachSiNoCoverage")).Click();
                    }
                    catch (ElementNotInteractableException)
                    {

                    }
                }
            }

            else
            {
                AddToCart[1].Click();
                if (IsElementPresent(driver, By.Id("attachSiNoCoverage")))
                {
                    try
                    {
                        driver.FindElement(By.Id("attachSiNoCoverage")).Click();
                    }
                    catch (ElementNotInteractableException)
                    {
                        
                    }
                }
            }
            driver.Close();
            driver.SwitchTo().Window(originalWindow);
        }

        public bool IsElementPresent(IWebDriver driver, By by)
        {
            try
            {
                // Attempt to find the element
                driver.FindElement(by);
                return true;
            }
            catch (NoSuchElementException)
            {
                // Element was not found
                return false;
            }
        }
    }
}
