using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace The_InternetTests
{
    public class FileUploadPage
    {
        [FindsBy(How = How.XPath, Using = "// a[text()=\"File Upload\"]")]
        [CacheLookup]
        private IWebElement fileUploadLink;
        [FindsBy(How =How.XPath,Using = "//*[@id=\"drag-drop-upload\"]")]
        [CacheLookup]
        private IWebElement chooseFileButton;
        [FindsBy(How =How.Id,Using = "[id=\"file-submit\"]")]
        [CacheLookup]
        private IWebElement uploadButton;
        [FindsBy(How =How.XPath,Using = "//*[text()=\"File Uploaded!\"]")]
        [CacheLookup]
        private IWebElement successTittle;

        Helper helper =new Helper();


        public string GetTittle()
        {
            return successTittle.Text;  
        }


        public void ClickOnFileUploadLink()
        {
            helper.ScrollIntoWiew(fileUploadLink);
            fileUploadLink.Click(); 
        }
       
         
        public void SelectFile()
        {
            helper.ScrollIntoWiew(chooseFileButton);
            chooseFileButton.Click();
            chooseFileButton.SendKeys("M:\\D\\uplod.jpg");
            helper.ScrollIntoWiew(uploadButton);    
            uploadButton.Click();   
        }
    }
}
