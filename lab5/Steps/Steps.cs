using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;

namespace lab5.Steps
{
    class Steps
    {
        IWebDriver driver;

        public void InitBrowser()
        {
            driver = Driver.DriverInstance.GetInstance();
        }

        public void CloseBrowser()
        {
            Driver.DriverInstance.CloseBrowser();
        }

        public void SearchCaseOne(string from, string to, string numberOfPassangers, string departDate, string returnDate)
        {
            Pages.Home home = new Pages.Home(driver);
            home.OpenPage();
            home.SearchInManyPlace(from, to, numberOfPassangers, departDate, returnDate);
            foreach (var windowHandle in driver.WindowHandles)
            {
                if (windowHandle != driver.CurrentWindowHandle)
                {
                    driver.SwitchTo().Window(windowHandle);
                    IWebElement dynamicElement = (new WebDriverWait(driver, TimeSpan.Parse("60"))).Until(ExpectedConditions.ElementExists(By.Id("view-itinerary")));
                    Assert.IsTrue(dynamicElement.Text.Contains("Hide"));
                }
            }

        }

        public void SearchCaseTwo(string from, string to, string numberOfPassangers, string departDate, string returnDate)
        {
            Pages.Home home = new Pages.Home(driver);
            home.OpenPage();
            home.SearchInManyPlace(from, to, numberOfPassangers, departDate, returnDate);
            foreach (var windowHandle in driver.WindowHandles)
            {
                if (windowHandle != driver.CurrentWindowHandle)
                {
                    driver.SwitchTo().Window(windowHandle);
                    IWebElement dynamicElement = (new WebDriverWait(driver, TimeSpan.Parse("60"))).Until(ExpectedConditions.ElementExists(By.XPath("//H3[@small=''][text()='Oops!  Something went wrong!']")));
                    Assert.IsTrue(dynamicElement.Text.Contains("Oops! Something went wrong!"));
                }
            }
        }

        public void SearchCaseThree(string from, string to, string numberOfPassangers, string departDate)
        {
            Pages.Home homePage = new Pages.Home(driver);
            homePage.OpenPage();
            homePage.SearchInOnePlace(from, to, numberOfPassangers, departDate);
            foreach (var windowHandle in driver.WindowHandles)
            {
                if (windowHandle != driver.CurrentWindowHandle)
                {
                    driver.SwitchTo().Window(windowHandle);
                    IWebElement dynamicElement = (new WebDriverWait(driver, TimeSpan.Parse("60"))).Until(ExpectedConditions.ElementExists(By.Id("view-itinerary")));
                    Assert.IsTrue(dynamicElement.Text.Contains("Hide"));
                }
            }
        }

        public void SearchCaseFour(string from, string to, string numberOfPassangers, string departDate, string returnDate)
        {

            Pages.Home home = new Pages.Home(driver);
            home.OpenPage();
            home.SearchInManyPlace(from, to, numberOfPassangers, departDate, returnDate);
            foreach (var windowHandle in driver.WindowHandles)
            {
                if (windowHandle != driver.CurrentWindowHandle)
                {
                    driver.SwitchTo().Window(windowHandle);
                    IWebElement dynamicElement = (new WebDriverWait(driver, TimeSpan.Parse("60"))).Until(ExpectedConditions.ElementExists(By.Id("view-itinerary")));
                    Assert.IsTrue(dynamicElement.Text.Contains("Hide"));
                }
            }
        }
    }
}

    
        

