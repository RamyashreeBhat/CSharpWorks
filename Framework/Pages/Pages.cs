using Framework;
using OpenQA.Selenium.Support.PageObjects;

namespace QtpTests
{
   public static class Pages
    {
        // below static method can return us any generic page
        //it is private and static. it returns a genric type
        //it always takes a parameter 
        //comstraint on the parameter is always an object type , not int, string etc.,
        //it has to have a parameterless constructor--? why
        private static T GetPage<T>() where T : new()
        {
            var page = new T();
            PageFactory.InitElements(Browser.Driver, page);
            return page;
        }
        //below method is used to return Loginpage
        public static LoginPage Login {
            get {
                return GetPage<LoginPage>();
            }
        }

        public static MyMembershipPage MyMembership { get {
            return GetPage<MyMembershipPage>();
            } }

        public static EditProfile EditProfile
        {
            get
            {
                return GetPage<EditProfile>();
            }
        }
    }
}