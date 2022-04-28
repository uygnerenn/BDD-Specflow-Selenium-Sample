﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestProject1.ComponentHelper;
using UnitTestProject1.Settings;

namespace HyperLink
{
    [TestClass]
    public class TestHyperLink
    {
        [TestMethod]

        public void ClickLink()
        {
             NavigationHelper.NavigateToUrl(ObjectRepository.Config.GetWebsite());
            //IWebElement element =  ObjectRepository.Driver.FindElement(By.LinkText("File a Bug"));
            // element.Click();
            // IWebElement pelement = ObjectRepository.Driver.FindElement(By.PartialLinkText("File"));
            // pelement.Click();
            LinkHelper.ClickLink(By.LinkText("File a Bug"));
            //LinkHelper.ClickLink(By.PartialLinkText("File"));

        }

    }
}
