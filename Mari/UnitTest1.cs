using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Mari
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("file:///C:/TC/Mari/Mari/UI/ResDemo.html");
            driver.Manage().Window.Maximize();
            driver.FindElement(By.Id("Starter3")).Click();
        }
    }
}