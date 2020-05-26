using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Demo.WinAppDriver
{
    [Category("DesktopTest")]
    public class ApplicationTest : SessionBase
    {
        //private static By MyTextBox = By.Id("txtTextBox");
        //private static By MyDropDown = By.Id("cboComboBox");
        //private static By MyRadio = By.Id("rdoOne");
        //private static By MyCheckBox = By.Id("chkOne");

        private const string MyTextBox = "txtTextBox";
        private const string MyDropDown = "cboComboBox";
        private const string MyRadio = "rdoOne";
        private const string MyCheckBox = "chkOne";
        #region Methods

        private WindowsElement GetElement(By locator)
        {
            return _session.FindElement(locator);
        }

        private WindowsElement GetElementByAccessibilityID(string id)
        {
            return _session.FindElementByAccessibilityId(id);
        }

        private WindowsElement GetChildElementByAccessibilityID(WindowsElement parent, string id)
        {
            return (WindowsElement) parent.FindElementByAccessibilityId(id);
        }

        private void SetText(WindowsElement element, string text)
        {
            element.SendKeys(text);
        }

        private void ClickElement(WindowsElement element)
        {
            element.Click();
        }
        #endregion

        [SetUp]
        public void Initialize()
        {
            SessionBase.SetupSession();
        }

        [TearDown]
        public void Quit()
        {
            SessionBase.EndSession();
        }

        [Test]
        public void SetMyTextBox()
        {
            WindowsElement element = GetElementByAccessibilityID(MyTextBox);
            SetText(element, "Demo text");
            Thread.Sleep(2500);
        }

        [Test]
        public void SelectInMyDropDown()
        {
            WindowsElement element = GetElementByAccessibilityID(MyDropDown);
            //WindowsElement dropdown = GetChildElementByAccessibilityID(element, "DropDown");
            //ClickElement(dropdown);
            element.Click();
             var x = element.FindElementById("DropDown");
            //x.SendKeys("First");
            Thread.Sleep(5000);
        }

        [Test]
        public void CheckMyRadio()
        {
            WindowsElement element = GetElementByAccessibilityID("rdoOne");
            element.Click();
            Thread.Sleep(2500);
        }

        [Test]
        public void CheckUncheckMyCheckBox()
        {
            var one = _session.FindElementByAccessibilityId("chkOne");
            var two = _session.FindElementByAccessibilityId("chk2");

            if (!one.Selected)
            {
                one.Click();
            }

            Thread.Sleep(1500);
            if (!two.Selected)
            {
                two.Click();
            }

            Thread.Sleep(1500);
            one.Click();

            Thread.Sleep(2500);
        }
    }
}
