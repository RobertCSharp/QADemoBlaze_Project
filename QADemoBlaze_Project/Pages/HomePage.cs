using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace QADemoBlaze_Project.Pages
{
    public class HomePage
    {
        IWebDriver driver;

        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
        }

        private IWebElement LoginButton => driver.FindElement(By.CssSelector("#login2"));
        private IWebElement BackHomeButton => driver.FindElement(By.CssSelector("#nava"));

        public void ClickLoginButton()
        {
            LoginButton.Click();
        }

        public void ScrollDownPage()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollTo(0, 0)");
        }

        public void CLickBackHomePage()
        {
            BackHomeButton.Click();
        }
    }
}
