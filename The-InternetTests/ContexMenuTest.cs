using NUnit.Framework;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace The_InternetTests
{
    public class ContexMenuTest : BaseTest
    {
        string urlTest = "https://the-internet.herokuapp.com/";
        ContexMenuPage contexMenuPage;
        Helper helper;

        [SetUp]
        public void SetUp()
        {
            helper = new Helper();
            contexMenuPage = new ContexMenuPage();
            PageFactory.InitElements(GetWebDriver(), contexMenuPage);
            goToExamplesPage(urlTest);
        }

        [Test]
        public void ContexClick()
        {
            string expectedTittle = "Context Menu";
            contexMenuPage.ClickOnContexMenuLink();
            Assert.That(contexMenuPage.GetTittle(), Is.EqualTo(expectedTittle));
            contexMenuPage.rightClickOnSpot();
            string expectedAllertText = "You selected a context menu";
            string actualAllertText = GetWebDriver().SwitchTo().Alert().Text;
            Assert.That(actualAllertText, Is.EqualTo(expectedAllertText));
            GetWebDriver().SwitchTo().Alert().Accept();
        }

        [TearDown]
        public void TearDown()
        {
            GetWebDriver().Quit();  
        }




    }
}
