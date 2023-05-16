using Microsoft.VisualStudio.TestPlatform.ObjectModel;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using QADemoBlaze_Project.Pages;
using Constants = QADemoBlaze_Project.Data.Constants;

namespace QADemoBlaze_Project.Tests
{
    public class BaseTest
    {
        IWebDriver driver;
        HomePage homePage;
        ProductPage productPage;
        ProductListPage productList;
        LoginPage loginPage;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl(Constants.URL);
            driver.Manage().Window.Maximize();
            homePage = new HomePage(driver);
            productPage = new ProductPage(driver);
            productList = new ProductListPage(driver);
            loginPage = new LoginPage(driver);
        }

        [Test]
        public void EndToEndTest()
        {
            homePage.ClickLoginButton();
            Thread.Sleep(2000);
            loginPage.InputUserNameAndPassword();
            loginPage.ClickLogin();
            Thread.Sleep(2000);
            homePage.ScrollDownPage();
            productPage.CLickOnPhone();
            Thread.Sleep(2000);
            productPage.AddToCart();
            Thread.Sleep(2000);
            productPage.ConfirmAlert();
            Thread.Sleep(2000);
            homePage.CLickBackHomePage();
            Thread.Sleep(2000);
            productPage.ClickSonyPhone();
            Thread.Sleep(2000);
            productPage.AddToCart();
            Thread.Sleep(2000);
            IAlert alert2 = driver.SwitchTo().Alert();
            alert2.Accept();
            Thread.Sleep(2000);
            homePage.CLickBackHomePage();
            Thread.Sleep(2000);
            productPage.ClickOnNexusPhone();
            Thread.Sleep(2000);
            productPage.AddToCart();
            Thread.Sleep(2000);
            productPage.ConfirmAlert3();
            Thread.Sleep(2000);
            productList.ClickPlaceOrder();
            Thread.Sleep(2000);
            driver.FindElement(By.CssSelector(".btn.btn-success")).Click();
            Thread.Sleep(2000);
            productList.AddData();
            Thread.Sleep(2000);
            productList.ClickOnPurchaseButton();
            Thread.Sleep(2000);
            productList.ClickOnConfrim();
        }
    }
}