
using OpenQA.Selenium;
using Selenium.Community.PageObjects;
using SeleniumExtras.PageObjects;
using Teamone.PageObjects;

namespace Teamone.PageObjects
{
    class Newuser
    {
        

        [SeleniumExtras.PageObjects.FindsBy(How = (SeleniumExtras.PageObjects.How)Selenium.Community.PageObjects.How.XPath, Using = "//button[@id='newUser']")]
        public IWebElement newuserbutton { get; set; }


        [SeleniumExtras.PageObjects.FindsBy(How = (SeleniumExtras.PageObjects.How)Selenium.Community.PageObjects.How.XPath, Using = "//button[@id='gotologin']")]
        public IWebElement loginbackbutton { get; set; }
    }
}