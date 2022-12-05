using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace The_InternetTests
{
    public class DropDownPage
    {
        [FindsBy(How = How.XPath, Using = "//*[text()=\"Dropdown List\"]")]
        [CacheLookup]
        private IWebElement dropDownText;


        [FindsBy(How = How.XPath, Using = "//a[text()=\"Dropdown\"]")]
        [CacheLookup]
        private IWebElement dropDownLink;

        [FindsBy(How = How.XPath, Using = "//select[@id=\"dropdown\"]")]
        [CacheLookup]
        private IWebElement dropDownMenu;

        Helper helper = new Helper();


        public void clickOnDropDownLink()
        {
            helper.ScrollIntoWiew(dropDownLink);
            dropDownLink.Click();
        }
        public void selectOption1InDropDownMenu()
        {
            helper.ScrollIntoWiew(dropDownMenu);
            dropDownMenu.Click();
            SelectElement element = new SelectElement(dropDownMenu);
            element.SelectByText("Option 1");
        }
        public void selectOption2InDropDownMenu()
        {
            helper.ScrollIntoWiew(dropDownMenu);
            dropDownMenu.Click();   
            SelectElement element = new SelectElement(dropDownMenu);
            element.SelectByText("Option 2");


        }
        public IWebElement getDropDownText()
        {
            return dropDownText;
        }
        public  IWebElement getDropDownMenu()
        {
            return dropDownMenu;    
        }
        public IWebElement getDropDownLink()
        {
            return dropDownLink;    
        }



    }
}
