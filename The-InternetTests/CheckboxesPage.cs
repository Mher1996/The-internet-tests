using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace The_InternetTests
{
    public class CheckboxesPage
    {
        [FindsBy(How = How.XPath, Using = "// *[text()=\"Checkboxes\"]")]
        [CacheLookup]
        private IWebElement checkBoxesLink;

        [FindsBy(How = How.XPath, Using = "//*[text()='Checkboxes']")]
        [CacheLookup]
        private IWebElement checkboxesTitle;

        [FindsBy(How = How.CssSelector, Using = "[type=\"checkbox\"]")]
        [CacheLookup]
        private IList<IWebElement> checkBoxes;

        Helper helper = new Helper();

        public void ClickOnCheckBoxesLink()
        {
            checkBoxesLink.Click();

        }

        public IWebElement getCheckBoxesLink()
        {
            return checkBoxesLink;
        }

        public IList<IWebElement> GetCheckboxes()
        {
            return checkBoxes;
        }
        public void CheckFirstCheckbox()
        {
            IWebElement firstCheckbox= checkBoxes[0];   
            helper.ScrollIntoWiew(firstCheckbox);
            firstCheckbox.Click();
        }
        public void CheckSecondCheckbox()
        {
            IWebElement secondCheckbox = checkBoxes[1];
            helper.ScrollIntoWiew(secondCheckbox);
            secondCheckbox.Click();
        }

        public bool IsChecked(int indexOfCheckbox)
        {
            if (checkBoxes.ElementAt(indexOfCheckbox).Selected)
            {
                return true;

            }
            else
            {
                return false;
            }
        }

    }
}
