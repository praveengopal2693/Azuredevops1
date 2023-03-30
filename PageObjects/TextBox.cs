using OpenQA.Selenium;
using Selenium.Community.PageObjects;
using SeleniumExtras.PageObjects;
using How = SeleniumExtras.PageObjects.How;

namespace Teamone.PageObjects
{
    public class TextBox
    {

        [SeleniumExtras.PageObjects.FindsBy(How = (SeleniumExtras.PageObjects.How)Selenium.Community.PageObjects.How.XPath, Using = "(//span[contains(@class,'pr-1')])[1]")]
        public IWebElement Firstrow { get; set; }

        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.XPath, Using = "//span[normalize-space()='Text Box']")]
        public IWebElement Textboxsection { get; set; }

        [SeleniumExtras.PageObjects.FindsBy(How = How.Id, Using = "userName")]
        public IWebElement FullName { get; set; }

        [SeleniumExtras.PageObjects.FindsBy(How = How.Id, Using = "userEmail")]
        public IWebElement Email { get; set; }

        [SeleniumExtras.PageObjects.FindsBy(How = How.Id, Using = "currentAddress")]
        public IWebElement CurrentAddress { get; set; }

        [SeleniumExtras.PageObjects.FindsBy(How = How.Id, Using = "permanentAddress")]
        public IWebElement PermanentAddress { get; set; }

        [SeleniumExtras.PageObjects.FindsBy(How = How.Id, Using = "submit")]
        public IWebElement SubMit { get; set; }

    }
}