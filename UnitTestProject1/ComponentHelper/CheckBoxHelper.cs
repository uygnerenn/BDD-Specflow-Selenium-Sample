using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject1.ComponentHelper
{
    
    public class CheckBoxHelper
    {
        private static IWebElement element;

        public static void CheckedCheckBox(By Locator)
        {
            element = GenericHelper.GetElement(Locator);
            element.Click();
        }
        public static bool IsCheckBoxCheck(By Locator)
        {
            element = GenericHelper.GetElement(Locator);
            string flag  = element.GetAttribute("checked");

            if (flag == null)
                return false;
            else
                return flag.Equals("true") || flag.Equals("checked");
        }
    }
}
