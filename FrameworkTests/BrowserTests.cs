using Framework;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;

namespace FrameworkTests
{
    [TestClass]
    public class BrowserTests
    {
        [TestMethod]
        public void GivenValidElement_WhenElementIsVisible_ElementIsDisplayedFindsElement()
        {
            Browser.GoTo("data:text/html,<span id =\"hello\">Hello</span>", false);
            Assert.IsTrue(Browser.ElementIsDisplayed(By.Id("hello")), "ElementIsDisplayed Method is supposed to find the element");
        }

        [TestMethod]
        public void GivenValidElement_WhenElementIshidden_ElementIsDisplayedDoesNotFindElement()
        {
            Browser.GoTo("data:text/html,<span id =\"hello\" style=\"position:absolute;left:-9000px;width=0;overflow:hidden\">Hello</span>", false);
            Assert.IsFalse(Browser.ElementIsDisplayed(By.Id("hello")), "ElementIsDisplayed found an element invalidly");
        }

        [TestMethod]
        public void GivenValidElement_WhenElementDoesNotHaveID_ElementIsDisplayedFindsElement()
        {
            Browser.GoTo("data:text/html,hello", false);
            Assert.IsFalse(Browser.ElementIsDisplayed(By.Id("hello")), "ElementIsDisplayed Method found an element that should not have been found");
        }
    }
}
