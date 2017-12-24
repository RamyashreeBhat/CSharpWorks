using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace QtpTests
{
    [TestClass]
    public class ValidUserCanSuccessfullyLoginRefactor3 : TestBase
    {
        [TestMethod]
        [TestCategory("FirstGroup")]
        public void RunTestValidUserCanSuccessfullyLogin()
        {
            Pages.Login.Login("ramya93", "Test@password");
            Assert.IsTrue(Pages.MyMembership.IsAt(),"Not in Membership page ");
               
        }
        
    }
}