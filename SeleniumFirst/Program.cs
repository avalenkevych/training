using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
        public void FirstTest()
        {
            
           

        }

        [TearDown]
        public void End()
        {
            driver.Close();
        }
    }
        

        




    }

