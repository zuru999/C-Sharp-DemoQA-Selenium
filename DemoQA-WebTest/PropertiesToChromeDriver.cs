﻿using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoQA_WebTest
{
    enum PropertyType
    {
        Id,
        Name,
        CssName,
        ClassName,
        XPath
    }


    class PropertiesToChromeDriver
    {
        public static IWebDriver chrome { get; set; }
    }
}
