using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using QADemoBlaze_Project.Data;

namespace QADemoBlaze_Project
{
    public class LoginPage
    {
        private IWebDriver driver;

        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        private IWebElement LoginButton => driver.FindElement(By.XPath("(//button[@type='button'])[9]"));
        private IWebElement USerName => driver.FindElement(By.CssSelector("#loginusername"));
        private IWebElement Password => driver.FindElement(By.CssSelector("#loginpassword"));

        public void ClickLogin()
        {
           LoginButton.Click();
        }

        public void InputUserNameAndPassword()
        {
            USerName.SendKeys(Constants.UserName);
            Password.SendKeys(Constants.Password);
        }
    }
}
