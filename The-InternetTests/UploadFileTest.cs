using NUnit.Framework;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace The_InternetTests
{
    public class UploadFileTest : BaseTest
    {
        string urlTest = "https://the-internet.herokuapp.com/";
        string expectedSuccessMessage = "File Uploaded!";

        FileUploadPage fileUploadPage;

        [SetUp]
        public void SetUp()
        {
            fileUploadPage = new FileUploadPage();
            PageFactory.InitElements(GetWebDriver(), fileUploadPage);
            goToExamplesPage(urlTest);
        }

        [Test]  
        public void FileUpload()
        {
            fileUploadPage.ClickOnFileUploadLink();
            fileUploadPage.SelectFile();
            Assert.That(fileUploadPage.GetTittle(), Is.EqualTo(expectedSuccessMessage));
        }
        [TearDown]
        public void TearDown()
        {
            GetWebDriver().Quit();  
        }
      
    }
}
