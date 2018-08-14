using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumFirst
{
    class Program
    {
        IWebDriver driver;
        static void Main(string[] args) { } 
        
       [SetUp]
        public void setup()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://amazon.com");
            driver.Manage().Window.Maximize();
        }

        [Test]
        public void CreateNewUserTest()
        {
            IWebElement SignIn = driver.FindElement(By.CssSelector("#nav-link-accountList > span.nav-line-1"));
            SignIn.Click();

            IWebElement CreateAccountButton = driver.FindElement(By.CssSelector("#createAccountSubmit"));
            CreateAccountButton.Click();

            IWebElement YourName = driver.FindElement(By.CssSelector("#ap_customer_name"));
            YourName.SendKeys("Jon Doe");

            IWebElement Email = driver.FindElement(By.CssSelector("#ap_email"));
            Email.SendKeys("jondoe999@yopmail.com");

            IWebElement Password = driver.FindElement(By.CssSelector("#ap_password"));
            Password.SendKeys("zPau7ZXr");
           

            IWebElement Renterpass = driver.FindElement(By.CssSelector("#ap_password_check"));
            Renterpass.SendKeys("zPau7ZXr");

            IWebElement ContinueButton = driver.FindElement(By.CssSelector("#continue"));
            ContinueButton.Click();

            Thread.Sleep(5000);


        }

        [TearDown]
        public void End()
        {
            driver.Close();
        }
    }
        

        




    }

