using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace WorkAutomation.Service
{
    public class LoginService : IAutomationService
    {
        MainForm mainForm { get; set; }
        public LoginService(MainForm mainForm)
        {
            this.mainForm = mainForm;
        }
        public void AutoService()
        {
            mainForm.driver.Navigate().GoToUrl(mainForm.txtServerUrl.Text);
            mainForm.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10000);
            mainForm.driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(10000);
            mainForm.driver.Manage().Window.Maximize();

            mainForm.driver.FindElement(By.Id("userId")).Click();
            mainForm.driver.FindElement(By.Id("userId")).Clear();
            mainForm.driver.FindElement(By.Id("userId")).SendKeys(mainForm.txtId.Text);
            mainForm.driver.FindElement(By.Id("password")).Click();
            mainForm.driver.FindElement(By.Id("password")).Clear();
            mainForm.driver.FindElement(By.Id("password")).SendKeys(mainForm.txtPassword.Text);
            mainForm.driver.FindElement(By.XPath("//BUTTON[@class='pure-button pure-button-primary login-btn'][text()='로그인']")).Click();

            mainForm.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10000);
            mainForm.driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(10000);

            mainForm.driver.FindElement(By.XPath("//a[contains(text(),'Setting')]")).Click();
        }
    }
}
