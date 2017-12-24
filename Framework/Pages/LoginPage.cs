using Framework;
using OpenQA.Selenium;
using System;

namespace QtpTests
{
    public class LoginPage
    {
        //public void GoTo()
        //{
        //    Browser.GoTo("/wp-login.php");
        //}

        public void Login(string userName, string password)
        {
            var userNameField = Browser.Driver.FindElement(By.Id("user_login"));//ramya93 Test@password
            userNameField.Clear();
            userNameField.SendKeys(userName);

            var passwordField = Browser.Driver.FindElement(By.Id("user_pass"));//ramya93 Test@password
            passwordField.Clear();
            passwordField.SendKeys(password);

            Browser.Driver.FindElement(By.Id("wp-submit")).Click();

        }
    }
}