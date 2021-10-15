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
        //IAutomationService cLoginService;
        IAutomationService cDemoService;
        public MainForm()
        {
            InitializeComponent();          
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            //doService(cLoginService);       
        }
        private void btnDemo_Click(object sender, EventArgs e)
        {
            try
            {
                driver = new ChromeDriver(this.txtWebDriverDir.Text);
                cDemoService = new DemoService(this);
                doService(cDemoService);
            }
            catch (Exception ex)
            {
                this.txtLog.AppendText(ex.Message + Environment.NewLine);
            }
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            setDefaultValue();
        }
        private void setDefaultValue()
        {
            this.txtServerUrl.Text = "http://demo.guru99.com/popup.php";
            this.txtWebDriverDir.Text = "D:\\selenium";
            this.txtEmail.Text = "test3486rbwp@gmail.com";
            //this.txtId.Text = "id";
            //this.txtPassword.Text = "password";
        }
        private void doService(IAutomationService cAutoMationService)
        {
            cAutoMationService.AutoService();
        }
    }
}
