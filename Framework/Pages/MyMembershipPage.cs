using Framework;
using OpenQA.Selenium;
using System;

namespace QtpTests
{
    public class MyMembershipPage
    {
        private int PAGE_LOAD_TIMEOUT = 10;

        public bool IsAt()
        {
            //return Browser.Title.Contains("My Membership");
            By element = By.XPath(".//h1[contains(text(),'My Membership')]");
            return Browser.WaitUntilElementIsDisplayed(element, PAGE_LOAD_TIMEOUT);
        }

        public void EditProfile()
        {
            // var editProfile = Browser.Driver.FindElement(By.LinkText("Edit Profile"));
            var editProfile = Browser.FindPageElements(By.LinkText("Edit Profile"));
            editProfile.Click();
        }
    }
}