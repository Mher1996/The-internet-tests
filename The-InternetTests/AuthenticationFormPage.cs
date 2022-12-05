using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace The_InternetTests
{
    public class AuthenticationFormPage
    {
        [FindsBy(How = How.XPath, Using = "//*[text()=\"Form Authentication\"]")]
        [CacheLookup]
        private IWebElement formAuthenticationlink;

        [FindsBy(How = How.XPath, Using = "//input[@name=\"username\"]")]
        [CacheLookup]
        private IWebElement userNameField;

        [FindsBy(How = How.XPath, Using = "//input[@name=\"password\"]")]
        [CacheLookup]
        private IWebElement passwordField;

        [FindsBy(How = How.CssSelector, Using = "[type=\"submit\"]")]
        [CacheLookup]
        private IWebElement loginButton;

        [FindsBy(How = How.XPath, Using = "//*[@id=\"flash\"]")]
        [CacheLookup]
        private IWebElement succesMessage;

        Helper helper = new Helper();


        public IWebElement GetSuccessMesage()
        {
            return succesMessage;
        }


        public void ClickOnFormAuthenticationlink()
        {
            helper.ScrollIntoWiew(formAuthenticationlink);
            formAuthenticationlink.Click();

        }

        public IWebElement GetLink()
        {
            return formAuthenticationlink;
        }

        public IWebElement GetUserName()
        {
            return userNameField;
        }

        public IWebElement GetPassword() {
            return passwordField;    
        }
        public void SetUserName(string userNameText)
        {
            helper.ScrollIntoWiew(userNameField);
            userNameField.Click();
            userNameField.SendKeys(userNameText);

        }
        public void SetPassword(string passwordText)
        {
            helper.ScrollIntoWiew(passwordField);
            passwordField.Click();
            passwordField.SendKeys(passwordText);

        }
        public void Login()
        {
            helper.ScrollIntoWiew(loginButton);
            loginButton.Click();

        }

    }
}
