using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace WorkAutomation.Service
{
    class DemoService : IAutomationService
    {
        MainForm mainForm { get; set; }
        IWebDriver driver { get; set; }
        public DemoService(MainForm mainForm)
        {
            this.mainForm = mainForm;
            this.driver = mainForm.driver;
        }
        public void AutoService()
        {
            driver.Navigate().GoToUrl(mainForm.txtServerUrl.Text);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10000);
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(10000);
            driver.Manage().Window.Maximize();

            driver.FindElement(By.XPath("//A[@href='../articles_popup.php'][text()='Click Here']")).Click();

            driver.SwitchTo().Window(driver.WindowHandles[1]);//화면 전환

            driver.FindElement(By.XPath("//INPUT[@type='text']")).Click();
            driver.FindElement(By.XPath("//INPUT[@type='text']")).Clear();
            driver.FindElement(By.XPath("//INPUT[@type='text']")).SendKeys(mainForm.txtEmail.Text);

            driver.FindElement(By.XPath("//INPUT[@type='submit']")).Click();

            //driver.SwitchTo().Window(driver.WindowHandles[2]);//화면 전환

            var webElements = driver.FindElements(By.TagName("td"));
            foreach(var webElement in webElements)
            {
                Console.WriteLine(webElement.Text);
            }
            /*
            mainForm.driver.FindElement(By.Id("userId")).Click();
            mainForm.driver.FindElement(By.Id("userId")).Clear();
            mainForm.driver.FindElement(By.Id("userId")).SendKeys(mainForm.txtId.Text);
            mainForm.driver.FindElement(By.Id("password")).Click();
            mainForm.driver.FindElement(By.Id("password")).Clear();
            mainForm.driver.FindElement(By.Id("password")).SendKeys(mainForm.txtPassword.Text);

            mainForm.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10000);
            mainForm.driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(10000);

            mainForm.driver.FindElement(By.XPath("//a[contains(text(),'Setting')]")).Click();
            */
        }
    }
}
