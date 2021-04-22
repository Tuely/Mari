using Mari.CoreUI;
using Mari.Pages;
using System;
using TechTalk.SpecFlow;

namespace Mari.Steps
{
    [Binding]
    public class OrderPageSteps
    {
        private PageObjectFactory _page;
        public OrderPageSteps(PageObjectFactory page)
        {
            _page = page;
        }
        [Given(@"I navigate into the order page")]
        public void GivenINavigateIntoTheOrderPage()
        {
            BasePage.NavigateToUrl(AppConfigManager.BaseUrl());
        }

        [Given(@"I enter personal details as '(.*)' and '(.*)'")]
        public void GivenIEnterPersonalDetailsAsAnd(string fname, string lname)
        {
            _page.OrdersPage().EnterPersonalDetails(fname, lname);
        }

        [Given(@"I select starters are '(.*)' and '(.*)'")]
        public void GivenISelectStartersAreAnd(string starter1, string starter2)
        {
            _page.OrdersPage().SelectStarterMenu(starter1, starter2);
        }
        
        [Given(@"I select Main menu items are '(.*)' , '(.*)' and '(.*)'")]
        public void GivenISelectMainMenuItemsAreAnd(string main1, string main2, string main3)
        {
            _page.OrdersPage().SelectMainMenu(main1, main2, main3);
        }
        
        [When(@"I click Checkout Option")]
        public void WhenIClickCheckoutOption()
        {
            _page.OrdersPage().ClickCheckOut();
        }
        
        [Then(@"I should see the total amount as '(.*)'")]
        public void ThenIShouldSeeTheTotalAmountAs(double total)
        {
            _page.OrdersPage().VerifyTotalAmount(total)
        }
    }
}
