using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestProject1.ComponentHelper;
using UnitTestProject1.Settings;

namespace UnitTestProject1.TestScript.WebElement
{
    [TestClass]
    public class TestWebElement
    {
        [TestMethod]

        public void GetElement()
        {
            NavigationHelper.NavigateToUrl(ObjectRepository.Config.GetWebsite());
            try
            {
                //ObjectRepository.Driver.FindElement(By.TagName("İnput"));
                //ObjectRepository.Driver.FindElement(By.ClassName("btn"));
                //ObjectRepository.Driver.FindElement(By.CssSelector("#find"));
                //ObjectRepository.Driver.FindElement(By.LinkText("File a Bug"));
                //ObjectRepository.Driver.FindElement(By.PartialLinkText("quicksearch"));
                //ObjectRepository.Driver.FindElement(By.Id("find_buttom"));
                //ObjectRepository.Driver.FindElement(By.XPath("//İnput[@id='find']"));
                // ObjectRepository.Driver.FindElement(By.XPath("//İnput[@id='find1']"));

            }
            catch (NoSuchElementException e)
            {

                Console.WriteLine(e);
            }
           
        }
    }
}
