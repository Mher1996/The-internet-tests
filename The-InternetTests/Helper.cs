using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace The_InternetTests
{
    public class Helper

    {
        public void ScrollIntoWiew(IWebElement element)
        {
            ((IJavaScriptExecutor)BaseTest.GetWebDriver())
              .ExecuteScript("arguments[0].scrollIntoView(true);", element);
         
        }
    }
}
