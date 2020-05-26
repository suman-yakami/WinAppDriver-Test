using NUnit.Framework;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.WinAppDriver
{
    public class SessionBase
    {
        public static WindowsDriver<WindowsElement> _session;

        public const string AppId = @"E:\Workstation\DesktopTestApp\DesktopTestApp\bin\Debug\DesktopTestApp.exe";
        public const string WindowsApplicationDriverUrl = @"http://127.0.0.1:4723";

        public static void SetupSession()
        {
            if (_session == null)
            {
                AppiumOptions options = new AppiumOptions();
                options.AddAdditionalCapability("app", AppId);
                _session = new WindowsDriver<WindowsElement>(new Uri(WindowsApplicationDriverUrl), options);
                Assert.IsNotNull(_session);

                // Set implicit timeout to 1.5 seconds to make element search to retry every 500 ms for at most three times
                _session.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1.5);
            }
        }

        public static void EndSession()
        {
            if (_session != null)
            {
                _session.Quit();
                _session = null;
            }
        }

    }
}
