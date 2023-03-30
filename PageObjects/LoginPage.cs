using OpenQA.Selenium;
using Selenium.Community.PageObjects;
using SeleniumExtras.PageObjects;
using How = SeleniumExtras.PageObjects.How;

namespace Teamone.PageObjects
{
    public class LoginPage
    {
        

        [SeleniumExtras.PageObjects.FindsBy(How = (SeleniumExtras.PageObjects.How)Selenium.Community.PageObjects.How.Id, Using = "userName")]
        public IWebElement UserName { get; set; }

        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.Id, Using = "password")]
        public IWebElement Password { get; set; }

        [SeleniumExtras.PageObjects.FindsBy(How = How.Id, Using = "login")]
        public IWebElement Submit { get; set; }

    }
}