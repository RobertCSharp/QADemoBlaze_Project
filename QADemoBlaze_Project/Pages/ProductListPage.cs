using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace QADemoBlaze_Project.Pages
{
    public class ProductListPage
    {
        IWebDriver driver;

        public ProductListPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        private IWebElement PlaceOrderButton => driver.FindElement(By.CssSelector("#cartur"));
        private IWebElement Name => driver.FindElement(By.CssSelector("#name"));
        private IWebElement Country => driver.FindElement(By.CssSelector("#country"));
        private IWebElement City => driver.FindElement(By.CssSelector("#city"));
        private IWebElement Card => driver.FindElement(By.CssSelector("#card"));
        private IWebElement Month => driver.FindElement(By.CssSelector("#month"));
        private IWebElement Year => driver.FindElement(By.CssSelector("#year"));
        private IWebElement PurchaseButton => driver.FindElement(By.XPath("//button[@onclick='purchaseOrder()']"));
        private IWebElement ConfrimButton => driver.FindElement(By.CssSelector(".confirm.btn.btn-lg.btn-primary"));

        public void ClickPlaceOrder()
        {
           PlaceOrderButton.Click();
        }

        public void AddData()
        {
            Name.SendKeys("Jonny");
            Country.SendKeys("Belgium");
            City.SendKeys("Kortrijk");
            Card.SendKeys("05749404092384");
            Month.SendKeys("12");
            Year.SendKeys("2022");
        }

        public void ClickOnPurchaseButton()
        {
            PurchaseButton.Click();
        }

        public void ClickOnConfrim()
        {
           ConfrimButton.Click();
        }
    }
}
