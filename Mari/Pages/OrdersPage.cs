using Mari.CoreUI;
using Mari.Extensions;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mari.Pages
{
  public  class OrdersPage
    {
        protected WebDriverSupport _driverSupport = new WebDriverSupport();

        #region OrdersPage Elements
  
        [FindsBy(How = How.Id, Using = "fname")]
        private IWebElement FirstNameText { get; set; }

        [FindsBy(How = How.Id, Using = "lname")]
        private IWebElement LastNameText { get; set; }

        [FindsBy(How = How.Id, Using = "Starter3")]
        private IWebElement Starter3 { get; set; }
        [FindsBy(How = How.Id, Using = "Starter5")]
        private IWebElement Starter5 { get; set; }

        [FindsBy(How = How.Id, Using = "Main1")]
        private IWebElement Main1 { get; set; }
        [FindsBy(How = How.Id, Using = "Main5")]
        private IWebElement Main5 { get; set; }
        [FindsBy(How = How.Id, Using = "Main7")]
        private IWebElement Main7 { get; set; }

        [FindsBy(How = How.Id, Using = "Checkout")]
        private IWebElement CheckoutButton { get; set; }
        #endregion

        #region OrdersPage Actions
        public void EnterPersonalDetails(string firstname, string lastname)
        {
            WebElementExtension.EnterTextIntoField(FirstNameText, firstname);
           WebElementExtension.EnterTextIntoField(LastNameText, lastname);
        }

        public void SelectStarterMenu(string s1, string s2)
        {
            WebElementExtension.SelectElementByText(Starter3, s2);
            WebElementExtension.SelectElementByText(Starter5, s2);
        }

        public void SelectMainMenu(string m1, string m2, string m3)
        {
          //  WebElementExtension.SelectElementByText(Main1, m1);
           // WebElementExtension.SelectElementByText(Main5, m2);
           // WebElementExtension.SelectElementByText(Main7, m3);
        }

        public void ClickCheckOut()
        {
            CheckoutButton.Click();
        }
        #endregion
    }
}
