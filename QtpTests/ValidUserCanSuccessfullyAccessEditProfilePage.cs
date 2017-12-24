using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace QtpTests
{
    [TestClass]
    public class ValidUserCanSuccessfullyAccessEditProfilePage : TestBase
    {
        [TestMethod]
        public void RunTestValidUserCanSuccessfullyAccessEditProfilePage()
        {
            Pages.Login.Login("ramya93", "Test@password");
            Assert.IsTrue(Pages.MyMembership.IsAt(),"Not in Membership page ");
            Pages.MyMembership.EditProfile();
            Assert.IsTrue(Pages.EditProfile.IsAt(),"User was not able to view Edit Profile Page");
            
            }

    }
}