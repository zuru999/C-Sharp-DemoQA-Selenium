using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;


namespace DemoQA_WebTest
{
    class SeleniumSetMethods
    {
        // Selecting a dropdown control

        public static void SelectDropDown (IWebElement element, string value)
        {
            
                new SelectElement(element).SelectByText(value);
            

        }
    }
}
