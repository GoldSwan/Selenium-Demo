using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

using WorkAutomation.Service;
namespace WorkAutomation
{
    public partial class MainForm : Form
    {
        //protected ChromeDriverService driverService = null;
        //protected ChromeOptions options = null;
        public IWebDriver driver
        {
            get;
            set;
        }

        IAutomationService cLoginService;
        IAutomationService cDemoService;

        public MainForm()
        {
            InitializeComponent();
            driver = new ChromeDriver();
            //cLoginService = new LoginService(this);
            cDemoService = new DemoService(this);
            setDefaultValue();
        }
        private void setDefaultValue()
        {
            this.txtServerUrl.Text = "http://demo.guru99.com/popup.php";
            //this.txtId.Text = "id";
            //this.txtPassword.Text = "password";
        }

        private void setDefaultSetting()
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //doService(cLoginService);       
        }

        private void doService(IAutomationService cAutoMationService)
        {
            cAutoMationService.AutoService();
        }

        private void btnDemo_Click(object sender, EventArgs e)
        {
            doService(cDemoService);
        }
    }
}
