using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support;

namespace UIAutomationForVacationDirect
{
    [TestClass]
    public class UnitTest1
    {
        String url = "http://www.vacationsdirect.com";
        private IWebDriver driver;


        [TestMethod]
        public void TestMethod1()
        {
            driver = new ChromeDriver();
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;



            driver.Navigate().GoToUrl(url);
            driver.FindElement(By.XPath("//*[@id='SearchWidgetWrapper']/section/div/ul/li[2]/button")).Click();
            driver.FindElement(By.Id("inputDestination")).SendKeys("New York, NY");

            js.ExecuteScript("document.getElementById('inputCheckInDate').setAttribute('value','07/08/20')");
            js.ExecuteScript("document.getElementById('inputCheckOutDate').setAttribute('value','08/06/20')");

            //driver.FindElement(By.Id("inputCheckInDate")).SendKeys("07/07/2020");
            //driver.FindElement(By.Id("inputCheckOutDate")).SendKeys("08/06/2020");
            driver.FindElement(By.Id("hotelSearchButton")).Click();


        }
    }
}
