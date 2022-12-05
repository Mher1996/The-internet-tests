using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace The_InternetTests
{
    public class CheckBoxTest : BaseTest
    {
        string urlTest = "https://the-internet.herokuapp.com/";
        CheckboxesPage checkboxesPage;
        IList<IWebElement> checkboxes;  
        Helper helper;


        [SetUp]
        public void SetUp()
        {
            helper= new Helper();   
            checkboxesPage= new CheckboxesPage();   
            PageFactory.InitElements(GetWebDriver(), checkboxesPage);
            checkboxes=checkboxesPage.GetCheckboxes();
            goToExamplesPage(urlTest);
        }


        [Test]
        public void CheckBoxes()
        {
            WaitForElement(checkboxesPage.getCheckBoxesLink());
            checkboxesPage.ClickOnCheckBoxesLink();
            for (int i = 0; i < checkboxes.Count; i++)
            {
                if (checkboxes[i].Selected)
                {
                    checkboxes[i].Click();  
                }
                Assert.That(checkboxes[i].Selected, Is.False);
            }
            checkboxesPage.CheckFirstCheckbox();
            Assert.That(checkboxes[0].Selected, Is.True);
            checkboxesPage.CheckSecondCheckbox();
            Assert.That(checkboxes[1].Selected, Is.True);

        }
        [TearDown]
        public void TearDown()
        {
            GetWebDriver().Close();
        }



    }
}
