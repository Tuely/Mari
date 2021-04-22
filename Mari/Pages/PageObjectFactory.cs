using Mari.CoreUI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mari.Pages
{
  public  class PageObjectFactory
    {
        public IWebDriver _driver;
        public BasePage _basePage;
        public PageObjectFactory(IWebDriver driver, BasePage basePage)
        {
            _driver = driver;
            _basePage = basePage;
        }

        public OrdersPage OrdersPage()
        {
            return _basePage.GetPage<OrdersPage>(_driver);
        }

       
    }
}
