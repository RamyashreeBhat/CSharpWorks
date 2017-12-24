using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace QtpTests
{
    [TestClass]
    public class LoginWithInvalidPasswordShouldNotWork:TestBase
    {
        [TestMethod]
        public void RunTestLoginWithInvalidPasswordShouldNotWork()
        {
            Pages.Login.Login("ramya93", "$1234%");
            Assert.IsFalse(Pages.MyMembership.IsAt());
        }
    }
}