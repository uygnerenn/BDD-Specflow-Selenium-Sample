using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestProject1.ComponentHelper;
using UnitTestProject1.Settings;

namespace HandleDropDown
{
    [TestClass]
    public class DropDownList
    {
        [TestMethod]

        public void TestList()
        {

            NavigationHelper.NavigateToUrl(ObjectRepository.Config.GetWebsite());
            LinkHelper.ClickLink(By.LinkText("File a Bug"));
            TextBoxHelper.TypeInTextBox(By.Id("Bugzilla_login"), ObjectRepository.Config.GetUserName());
            TextBoxHelper.TypeInTextBox(By.Id("Bugzilla_password"), ObjectRepository.Config.GetPassword());
            ButtonHelper.ClickButton(By.Id("log_in"));
           // LinkHelper.ClickLink(By.LinkText("Testng"));
            IWebElement element = ObjectRepository.Driver.FindElement(By.Id("bug_severity"));
            SelectElement select = new SelectElement(element);
            select.SelectByIndex(2);
            select.SelectByValue("normal");
            select.SelectByText("blocker");
           
        }
    }
}
