using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using System.Collections.Generic;

namespace The_InternetTests
{
    public class Tests : BaseTest
    {
        string urlTest = "https://the-internet.herokuapp.com/";
        DropDownPage dropDownPage;
        Helper helper;

        [SetUp]
        public void Setup()
        {
            helper = new Helper();
            dropDownPage = new DropDownPage();
            PageFactory.InitElements(GetWebDriver(), dropDownPage);
            goToExamplesPage(urlTest);
        }

        [Test]
        public void DropDownPage()
        {
            WaitForElement(dropDownPage.getDropDownLink());
            dropDownPage.clickOnDropDownLink();
            Assert.That(dropDownPage.getDropDownText().Displayed, Is.True);
            dropDownPage.selectOption1InDropDownMenu();
            SelectElement select = new SelectElement(dropDownPage.getDropDownMenu());
            Assert.That(select.SelectedOption.Text, Is.EqualTo("Option 1"));
            dropDownPage.selectOption2InDropDownMenu();
            Assert.That(select.SelectedOption.Text, Is.EqualTo("Option 2"));
        }

        [TearDown]
        public void TearDown()
        {
            GetWebDriver().Quit();
        }









    }
}














