
using OpenQA.Selenium;
using Selenium.Community.PageObjects;
using SeleniumExtras.PageObjects;
using Teamone.PageObjects;

namespace Teamone.PageObjects
{
    class HomePage
    {
        

        [SeleniumExtras.PageObjects.FindsBy(How = (SeleniumExtras.PageObjects.How)Selenium.Community.PageObjects.How.Id, Using = "account")]
        public IWebElement MyAccount { get; set; }
    }
}