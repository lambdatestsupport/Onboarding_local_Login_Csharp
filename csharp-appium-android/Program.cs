using System;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Appium.iOS;
using System.Threading;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace csharp_appium

{
    class Program
    {
        static void Main(string[] args)
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("start-maximized");
            IWebDriver driver = new ChromeDriver(@"C:\Users\rakeshs\AppData\Local\Programs\Python\Python311\Scripts", options);

            // URL of the login website that is tested
            driver.Navigate().GoToUrl("https://accounts.lambdatest.com/");
            Thread.Sleep(2000);

            // Enter your login email id
            driver.FindElement(By.Id("email")).SendKeys("shubhamr@lambdatest.com");

            // Enter your login password
            driver.FindElement(By.Id("password")).SendKeys("Gmail@123");
            driver.FindElement(By.Id("login-button")).SendKeys(Keys.Enter);

            Thread.Sleep(20000);
            driver.Quit();

        

            // Test case for the sample iOS app. 
            // If you have uploaded your app, update the test case here.

        }
    }
}


