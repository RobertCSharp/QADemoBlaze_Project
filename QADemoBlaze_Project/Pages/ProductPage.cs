using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace QADemoBlaze_Project.Pages
{
    public class ProductPage
    {
        IWebDriver driver;

        public ProductPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        private IWebElement OnPhoneButton => driver.FindElement(By.XPath("//a[contains(text(), 'Iphone 6')]"));
        private IWebElement AddToCartButton => driver.FindElement(By.CssSelector(".btn.btn-success.btn-lg"));
        private IWebElement SonyPhoneButton => driver.FindElement(By.XPath("//a[contains(text(), 'Sony vaio i7')]"));
        private IWebElement NexusPhoneButton => driver.FindElement(By.XPath("//a[contains(text(), 'Nexus')]"));

        public void CLickOnPhone()
        {
            OnPhoneButton.Click();
        }

        public void AddToCart()
        {
            AddToCartButton.Click();
        }

        public void ConfirmAlert()
        {
            IAlert alert = driver.SwitchTo().Alert();
            alert.Accept();
        }

        public void ClickSonyPhone()
        {
            SonyPhoneButton.Click();
        }

        public void ClickOnNexusPhone()
        {
            NexusPhoneButton.Click();
        }

        public void ConfirmAlert3()
        {
            IAlert alert3 = driver.SwitchTo().Alert();
            alert3.Accept();
        }
    }
}
