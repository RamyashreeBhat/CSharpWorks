using Framework;
using OpenQA.Selenium;

namespace QtpTests
{
    public class EditProfile
    {
        private static int PAGE_LOAD_TIMEOUT = 10;
        // basically isAt method has to wait for specific time for loading and return if element is displayed
        //with the concept of browser tab switch coming in,
        //now aftr clicking wait sometime
        //switch tab
        //wait for timeout and check for element
        public bool IsAt()
        {
            var element = By.XPath(".//h1[contains(text(),'Edit Profile')]");
            if(!Browser.WaitUntilElementIsDisplayed(element, 3))
                Browser.SwitchTabs(1);
            return Browser.WaitUntilElementIsDisplayed(element, PAGE_LOAD_TIMEOUT);
        }
    }
}