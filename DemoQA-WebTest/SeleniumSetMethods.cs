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

        public static void SelectDropDown (string element, string value, PropertyType elementtype)
        {
            if (elementtype == PropertyType.Id)
                new SelectElement(PropertiesToChromeDriver.chrome.FindElement(By.Id(element))).SelectByText(value);
            if (elementtype == PropertyType.Name)
                new SelectElement(PropertiesToChromeDriver.chrome.FindElement(By.Name(element))).SelectByText(value);

        }
    }
}
