using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace QtpTests
{
    [TestClass]
    public class LoginWithInvalidUserNameShouldNotWorkRefactor2:TestBase
    {
        [TestMethod]
        public void RunTestLoginWithInvalidUserNameShouldNotWorkRefactor2()
        {
            Pages.Login.Login("InvalidUserName", "Test@password");
            Assert.IsFalse(Pages.MyMembership.IsAt());
        }
    }
}