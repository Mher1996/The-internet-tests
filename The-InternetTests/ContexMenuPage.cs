using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using SeleniumExtras.PageObjects;
using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Text;

namespace The_InternetTests
{
    public class ContexMenuPage 
    {
        [FindsBy(How = How.XPath, Using = "//*[text()=\"Context Menu\"]")]
        [CacheLookup]
        private IWebElement contexMenuPageTittle;
        [FindsBy(How = How.XPath, Using = "//*[@id=\"hot-spot\"]")]
        [CacheLookup]
        private IWebElement hotSpot;
        [FindsBy(How =How.XPath,Using = "//a [text()=\"Context Menu\"]")]
        [CacheLookup]
        private IWebElement contexMenuLink;


        Helper helper= new Helper();  
        

        public void ClickOnContexMenuLink()
        {
            helper.ScrollIntoWiew(contexMenuLink);
            contexMenuLink.Click();

        }

        public string GetTittle()
        {
            return contexMenuPageTittle.Text;
        }

        public void rightClickOnSpot()
        {
            helper.ScrollIntoWiew(hotSpot);
            Actions act = new Actions(BaseTest.GetWebDriver());
            act.ContextClick(hotSpot).Build().Perform();  
        }

    }
}
