using NUnit.Framework;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace The_InternetTests
{
    public class AuthenticationFormTest : BaseTest
    {
        string urlTest = "https://the-internet.herokuapp.com/";
        public string userNameText = "tomsmith";
        public string passwordText = "SuperSecretPassword!";
        AuthenticationFormPage authenticationForm;
        Helper helper;

        [SetUp]
        public void SetUp()
        {
            helper = new Helper();
            authenticationForm= new AuthenticationFormPage();   
            PageFactory.InitElements(GetWebDriver(), authenticationForm);
            goToExamplesPage(urlTest);
        }

        [Test]
        public void LoginToPage()
        {
            WaitForElement(authenticationForm.GetLink());
            authenticationForm.ClickOnFormAuthenticationlink();
            WaitForElement(authenticationForm.GetUserName());
            authenticationForm.SetUserName(userNameText);
            WaitForElement(authenticationForm.GetPassword());
            authenticationForm.SetPassword(passwordText);
            authenticationForm.Login();

            Assert.That(authenticationForm.GetSuccessMesage().Displayed, Is.True);    

        }






    }
}
