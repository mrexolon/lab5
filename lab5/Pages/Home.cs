using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Support.PageObjects;

namespace lab5.Pages
{
    class Home
    {

        private const string BASE_URL = "https://www.skyscanner.ru/";
        private IWebDriver driver;

        [FindsBy(How = How.Id, Using = "reservationFlightSearchForm.originAirport")]
        private IWebElement inputFrom;

        [FindsBy(How = How.Id, Using = "reservationFlightSearchForm.destinationAirport")]
        private IWebElement inputTo;

        [FindsBy(How = How.Name, Using = "adultOrSeniorPassengerCount")]
        private IWebElement selectNumberList;

        [FindsBy(How = How.Id, Using = "aa-leavingOn")]
        private IWebElement inputDepart;

        [FindsBy(How = How.Id, Using = "aa-returningFrom")]
        private IWebElement inputReturn;

        [FindsBy(How = How.Id, Using = "flightSearchForm.button.vacationSubmit")]
        private IWebElement buttonSearch;

        [FindsBy(How = How.Id, Using = "cookieConsentAccept")]
        private IWebElement buttonAcceptCookie;

        [FindsBy(How = How.XPath, Using = "//SPAN[@aria-hidden='true'][text()='One way']")]
        private IWebElement buttonInOneWay;

        public Home(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(this.driver, this);
        }

        public void OpenPage()
        {
            driver.Navigate().GoToUrl(BASE_URL);
        }

        public void SearchInManyPlace(string from, string to, string numberOfPassangers, string departDate, string returnDate)
        {
            ClearValue(InOneWay: false);
            inputFrom.SendKeys(from);
            inputTo.SendKeys(to);
            selectNumberList.SendKeys(numberOfPassangers);
            inputDepart.SendKeys(departDate);
            inputReturn.SendKeys(returnDate);
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("arguments[0].click();", buttonSearch);
        }

        public void SearchInOnePlace(string from, string to, string numberOfPassangers, string departDate)
        {
            ClearValue(InOneWay: true);
            inputFrom.SendKeys(from);
            inputTo.SendKeys(to);
            selectNumberList.SendKeys(numberOfPassangers);
            inputDepart.SendKeys(departDate);
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("arguments[0].click();", buttonSearch);
        }

        public void ClearValue(bool InOneWay)
        {
            if (InOneWay)
            {
                buttonAcceptCookie.Click();
                buttonInOneWay.Click();
                inputFrom.Clear();
                inputDepart.Clear();
            }
            else
            {
                buttonAcceptCookie.Click();
                inputFrom.Clear();
                inputDepart.Clear();
                inputReturn.Clear();
            }
        }

    }
}
