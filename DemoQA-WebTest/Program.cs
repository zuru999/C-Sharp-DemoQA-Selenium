using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;

namespace DemoQA_WebTest
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        [SetUp]

        public void DriverInitialize ()
        {
            //Reference to Chrome driver in other class

            PropertiesToChromeDriver.chrome = new ChromeDriver(@"C:\C#\Automatyzacja\DemoQA-Test\DemoQA-WebTest\");

            // Navigate to site

            PropertiesToChromeDriver.chrome.Navigate().GoToUrl("http://demoqa.com/registration/");
            Console.WriteLine("Open URL");

        }

        [Test]

        public void RegistrationTest()
        {
            RegistrationPageObject pageRegistration = new RegistrationPageObject();

            pageRegistration.FillRegistrationForm("Jan", "Kowalski", "6667778899", "Janek123", "janeczkomuzykant123@yopmail.com",
                @"C:\Users\Zuru\Desktop\TestPicture.jpg","This is the test", "Password123", "Password123");

           

        }


        //[TearDown]

        //public void CloseDriver()
        //{
        //    PropertiesToChromeDriver.chrome.Close();
        //    Console.WriteLine("Close the driver");
        //}

    }
}
