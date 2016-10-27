using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace DemoQA_WebTest
{
    class RegistrationPageObject
    { 
        public RegistrationPageObject()
        {
            PageFactory.InitElements(PropertiesToChromeDriver.chrome, this);
        }

        [FindsBy(How = How.Id, Using = "name_3_firstname")]
        public IWebElement txtFirstName { get; set; }

        [FindsBy(How = How.Id, Using = "name_3_lastname")]
        public IWebElement txtLastName { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='pie_register']/li[2]/div/div/input[1]")]
        public IWebElement checkboxMaterial { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='pie_register']/li[3]/div/div/input[1]")]
        public IWebElement checkboxHobby1 { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='pie_register']/li[3]/div/div[1]/input[2]")]
        public IWebElement checkboxHobby2 { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='pie_register']/li[3]/div/div[1]/input[3]")]
        public IWebElement checkboxHobby3 { get; set; }

        [FindsBy(How = How.Id, Using = "dropdown_7")]              
        public IWebElement btnCountryDropDown { get; set; }

        [FindsBy(How = How.Id, Using = "mm_date_8")]
        public IWebElement monthDropDown { get; set; }

        [FindsBy(How = How.Id, Using = "dd_date_8")]
        public IWebElement dayDropDown { get; set; }

        [FindsBy(How = How.Id, Using = "yy_date_8")]
        public IWebElement yearDropDown { get; set; }

        [FindsBy(How = How.Id, Using = "phone_9")]
        public IWebElement txtPhone { get; set; }

        [FindsBy(How = How.Id, Using = "username")]
        public IWebElement txtUserName { get; set; }

        [FindsBy(How = How.Id, Using = "email_1")]
        public IWebElement txtEmail { get; set; }

        [FindsBy(How = How.Id, Using = "profile_pic_10")]
        public IWebElement btnPicture { get; set; }

        [FindsBy(How = How.Id, Using = "description")]
        public IWebElement txtDescription { get; set; }

        [FindsBy(How = How.Id, Using = "password_2")]
        public IWebElement txtPassword { get; set; }

        [FindsBy(How = How.Id, Using = "confirm_password_password_2")]
        public IWebElement txtConfirmPassword { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='pie_register']/li[14]/div/input")]
        public IWebElement btnSubmit { get; set; }


        public void FillRegistrationForm(string FirstName, string LastName, string PhoneNumber, string Username, string Email, string PathPicture,
            string Description, string Password, string ConfirmPassword)
        {
            txtFirstName.SendKeys(FirstName);
            txtLastName.SendKeys(LastName);
            checkboxMaterial.Click();
            checkboxHobby1.Click();
            checkboxHobby2.Click();
            checkboxHobby3.Click();
            //btnCountryDropDown.FindElement.(By.XPath("//*[@id='dropdown_7']/option[145]");
            //monthDropDown.Click();
            //dayDropDown.Click();
            //yearDropDown.Click();
            txtPhone.SendKeys(PhoneNumber);
            txtUserName.SendKeys(Username);
            txtEmail.SendKeys(Email);
            btnPicture.SendKeys(PathPicture);
            txtDescription.SendKeys(Description);
            txtPassword.SendKeys(Password);
            txtConfirmPassword.SendKeys(ConfirmPassword);
            //btnSubmit.Submit();

       

        }

    }
}
