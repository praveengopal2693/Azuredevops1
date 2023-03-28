using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using SeleniumExtras.PageObjects;
using Teamone.PageObjects;

namespace Teamone.TestCases
{

    class LogInTest
    {
        [Test]
        public void Test()
        {
           
            OpenQA.Selenium.IWebDriver driver = new ChromeDriver();

            driver.Url = "https://demoqa.com/login";

            driver.Manage().Window.Maximize();
            Console.WriteLine("Browser Maximized");

            //   var homePage = new HomePage();
            //   PageFactory.InitElements(driver, homePage);
            //   homePage.MyAccount.Click();

            var newUser = new Newuser();
            PageFactory.InitElements(driver, newUser);
            newUser.newuserbutton.Click();
            newUser.loginbackbutton.Click();


            var loginPage = new LoginPage();
            PageFactory.InitElements(driver, loginPage);
            loginPage.UserName.SendKeys("TestUser_1");
            loginPage.Password.SendKeys("Test@123");
            loginPage.Submit.Submit();
            Console.WriteLine("Successfully Logged in");

            var textBox = new TextBox();
            PageFactory.InitElements(driver, textBox);
            
            textBox.Firstrow.Click();
            textBox.Textboxsection.Click();
            textBox.FullName.SendKeys("TestUser_1");
            textBox.Email.SendKeys("test@yopmail.com");
            textBox.CurrentAddress.SendKeys("test");
            textBox.PermanentAddress.SendKeys("test");
            textBox.SubMit.Submit();
            Console.WriteLine("Successfully Logged in");

            driver.Close();

        }

    }
}