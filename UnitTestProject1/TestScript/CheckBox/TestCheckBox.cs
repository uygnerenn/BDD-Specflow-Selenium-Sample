using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestProject1.ComponentHelper;
using UnitTestProject1.Settings;

namespace CheckBox
{
    [TestClass]
    public class TestCheckBox
    {
        [TestMethod]

        public void TestBox()
        {
            NavigationHelper.NavigateToUrl(ObjectRepository.Config.GetWebsite());
            LinkHelper.ClickLink(By.LinkText("File a Bug"));
            TextBoxHelper.TypeInTextBox(By.Id("Bugzilla_login"), ObjectRepository.Config.GetUserName());
            TextBoxHelper.TypeInTextBox(By.Id("Bugzilla_password"), ObjectRepository.Config.GetPassword());
            TextBoxHelper.ClearTextBox(By.Id("Bugzilla_login"));
            TextBoxHelper.ClearTextBox(By.Id("Bugzilla_password"));
            //IWebElement ele = ObjectRepository.Driver.FindElement(By.Id("Bugzilla_restrictlogin"));
            //ele.Click();
            Console.WriteLine(CheckBoxHelper.IsCheckBoxCheck(By.Id("Bugzilla_restrictlogin")));
            CheckBoxHelper.CheckedCheckBox(By.Id("Bugzilla_restrictlogin"));
            Console.WriteLine(CheckBoxHelper.IsCheckBoxCheck(By.Id("Bugzilla_restrictlogin")));
        }
    }
}
