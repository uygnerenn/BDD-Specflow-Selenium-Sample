using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Configuration;
using UnitTestProject1.Configuration;
using UnitTestProject1.Interfaces;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //IConfig config = new AppConfigReader();
            //Console.WriteLine("Browser : {0}", config.GetBrowser());
            //Console.WriteLine("Username : {0}", config.GetUserName());
            //Console.WriteLine("Password : {0}", config.GetPassword());
            Console.WriteLine("Test");


        }
    }
}
