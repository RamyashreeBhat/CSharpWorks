using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Framework
{
    public static class Browser
    {
        private static IWebDriver _webDriver; 
        private static string _baseUrl = "https://www.qtptutorial.net/wp-login.php";

        public static IWebDriver Driver { get { return _webDriver; } }

        internal static bool WaitUntilElementIsDisplayed(By element, int timeout)
        {
            for (int i = 0; i < timeout; i++)
            {

                if (ElementIsDisplayed(element))
                {
                    return true;
                }
                Thread.Sleep(1000);
            }
            return false;
        }

        internal static IWebElement FindPageElements(By by)
        {
            return _webDriver.FindElement(by);
        }

        public static bool ElementIsDisplayed(By element)
        {

            bool present = false;
            //_webDriver.Manage().Timeouts().ImplicitWait(TimeSpan.FromSeconds(10));//

            try
            {
                present = _webDriver.FindElement(element).Displayed;
            }
            catch (NoSuchElementException)
            {
            }
            // _webDriver.Manage().Timeouts().ImplicitWait(TimeSpan.FromSeconds(10));
            return present;
        }

        public static string Title { get { return _webDriver.Title; } }

        public static void Initialize()
        {
            _webDriver = new ChromeDriver();
            _webDriver.Navigate().GoToUrl(_baseUrl);
        }

        public static void Close()
        {
            _webDriver.Close();//close current tab
            _webDriver.Close();//close all tabs
        }

        //public static void GoTo(string url)
        //{
            
        //    _webDriver.Navigate().GoToUrl(string.Format("{0}/{1}", _baseUrl, url));
            
        //}

        internal static void SwitchTabs(int tabIndex)
        {
            var windows = _webDriver.WindowHandles;
            _webDriver.SwitchTo().Window(windows[tabIndex]);
        }
    }
}
