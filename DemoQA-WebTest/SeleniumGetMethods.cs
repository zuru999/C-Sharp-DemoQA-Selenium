using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace DemoQA_WebTest
{
    class SeleniumGetMethods
    {
        
        public static string GetTextFromDropDown(IWebElement element)
        {
          
                return new SelectElement(element).AllSelectedOptions.SingleOrDefault().Text;
           
        }

    }
}
