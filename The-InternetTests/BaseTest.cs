using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace The_InternetTests
{
    public class BaseTest
    {
        static IWebDriver myDriver;
        static WebDriverWait wait;

      static void setWebDriver()
        {
            myDriver = new ChromeDriver();
        }
        public static IWebDriver GetWebDriver()
        {
            if(myDriver == null)
            {
                setWebDriver();
            }
            return myDriver;
        }
        public static WebDriverWait GetWait()
        {
            if (wait == null)
            {
                wait = new WebDriverWait(myDriver, TimeSpan.FromSeconds(10));
            }
            return wait;
        }


        public static void WaitForElement(IWebElement element)
        {
           GetWait().Until(GetWebDriver=>element.Displayed);
        } 

        public static void goToExamplesPage(string urlText)
        {
            GetWebDriver().Navigate().GoToUrl(urlText);
            GetWebDriver().Manage().Window.Maximize();
        }


    }
}
