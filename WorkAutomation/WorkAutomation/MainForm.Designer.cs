namespace WorkAutomation
{
    partial class MainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbxAccessInfo = new System.Windows.Forms.GroupBox();
            this.txtWebDriverDir = new System.Windows.Forms.TextBox();
            this.lblWebDriverDir = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.lblServerUrl = new System.Windows.Forms.Label();
            this.txtServerUrl = new System.Windows.Forms.TextBox();
            this.gbxAutoExecute = new System.Windows.Forms.GroupBox();
            this.btnDemo = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtExcelReadData = new System.Windows.Forms.TextBox();
            this.txtExcelDirectory = new System.Windows.Forms.TextBox();
            this.lblExcelDirectory = new System.Windows.Forms.Label();
            this.btnExcelDirectoryBrowse = new System.Windows.Forms.Button();
            this.gbxAccessInfo.SuspendLayout();
            this.gbxAutoExecute.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxAccessInfo
            // 
            this.gbxAccessInfo.Controls.Add(this.btnExcelDirectoryBrowse);
            this.gbxAccessInfo.Controls.Add(this.lblExcelDirectory);
            this.gbxAccessInfo.Controls.Add(this.txtExcelDirectory);
            this.gbxAccessInfo.Controls.Add(this.txtWebDriverDir);
            this.gbxAccessInfo.Controls.Add(this.lblWebDriverDir);
            this.gbxAccessInfo.Controls.Add(this.txtEmail);
            this.gbxAccessInfo.Controls.Add(this.lblEmail);
            this.gbxAccessInfo.Controls.Add(this.txtPassword);
            this.gbxAccessInfo.Controls.Add(this.lblPassword);
            this.gbxAccessInfo.Controls.Add(this.txtId);
            this.gbxAccessInfo.Controls.Add(this.lblId);
            this.gbxAccessInfo.Controls.Add(this.lblServerUrl);
            this.gbxAccessInfo.Controls.Add(this.txtServerUrl);
            this.gbxAccessInfo.Location = new System.Drawing.Point(12, 12);
            this.gbxAccessInfo.Name = "gbxAccessInfo";
            this.gbxAccessInfo.Size = new System.Drawing.Size(731, 120);
            this.gbxAccessInfo.TabIndex = 0;
            this.gbxAccessInfo.TabStop = false;
            this.gbxAccessInfo.Text = "Access Infomation";
            // 
            // txtWebDriverDir
            // 
            this.txtWebDriverDir.Location = new System.Drawing.Point(101, 91);
            this.txtWebDriverDir.Name = "txtWebDriverDir";
            this.txtWebDriverDir.Size = new System.Drawing.Size(242, 21);
            this.txtWebDriverDir.TabIndex = 10;
            // 
            // lblWebDriverDir
            // 
            this.lblWebDriverDir.Location = new System.Drawing.Point(6, 84);
            this.lblWebDriverDir.Name = "lblWebDriverDir";
            this.lblWebDriverDir.Size = new System.Drawing.Size(89, 33);
            this.lblWebDriverDir.TabIndex = 9;
            this.lblWebDriverDir.Text = "WebDriver \r\nDirectory";
            this.lblWebDriverDir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(456, 54);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(242, 21);
            this.txtEmail.TabIndex = 8;
            // 
            // lblEmail
            // 
            this.lblEmail.Location = new System.Drawing.Point(361, 55);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(89, 21);
            this.lblEmail.TabIndex = 7;
            this.lblEmail.Text = "Email";
            this.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(101, 55);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(242, 21);
            this.txtPassword.TabIndex = 6;
            // 
            // lblPassword
            // 
            this.lblPassword.Location = new System.Drawing.Point(6, 54);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(89, 21);
            this.lblPassword.TabIndex = 5;
            this.lblPassword.Text = "Password";
            this.lblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(456, 22);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(242, 21);
            this.txtId.TabIndex = 4;
            // 
            // lblId
            // 
            this.lblId.Location = new System.Drawing.Point(361, 21);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(89, 21);
            this.lblId.TabIndex = 3;
            this.lblId.Text = "Id";
            this.lblId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblServerUrl
            // 
            this.lblServerUrl.Location = new System.Drawing.Point(6, 21);
            this.lblServerUrl.Name = "lblServerUrl";
            this.lblServerUrl.Size = new System.Drawing.Size(89, 21);
            this.lblServerUrl.TabIndex = 2;
            this.lblServerUrl.Text = "Server URL";
            this.lblServerUrl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtServerUrl
            // 
            this.txtServerUrl.Location = new System.Drawing.Point(101, 21);
            this.txtServerUrl.Name = "txtServerUrl";
            this.txtServerUrl.Size = new System.Drawing.Size(242, 21);
            this.txtServerUrl.TabIndex = 1;
            // 
            // gbxAutoExecute
            // 
            this.gbxAutoExecute.Controls.Add(this.btnDemo);
            this.gbxAutoExecute.Location = new System.Drawing.Point(12, 138);
            this.gbxAutoExecute.Name = "gbxAutoExecute";
            this.gbxAutoExecute.Size = new System.Drawing.Size(731, 76);
            this.gbxAutoExecute.TabIndex = 1;
            this.gbxAutoExecute.TabStop = false;
            this.gbxAutoExecute.Text = "Automation Execute";
            // 
            // btnDemo
            // 
            this.btnDemo.Location = new System.Drawing.Point(20, 20);
            this.btnDemo.Name = "btnDemo";
            this.btnDemo.Size = new System.Drawing.Size(75, 23);
            this.btnDemo.TabIndex = 1;
            this.btnDemo.Text = "Demo";
            this.btnDemo.UseVisualStyleBackColor = true;
            this.btnDemo.Click += new System.EventHandler(this.btnDemo_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtLog);
            this.groupBox1.Location = new System.Drawing.Point(12, 220);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(731, 91);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Log";
            // 
            // txtLog
            // 
            this.txtLog.Location = new System.Drawing.Point(6, 20);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            this.txtLog.Size = new System.Drawing.Size(719, 61);
            this.txtLog.TabIndex = 9;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtExcelReadData);
            this.groupBox2.Location = new System.Drawing.Point(12, 317);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(731, 91);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Excel Read Data";
            // 
            // txtExcelReadData
            // 
            this.txtExcelReadData.Location = new System.Drawing.Point(6, 20);
            this.txtExcelReadData.Multiline = true;
            this.txtExcelReadData.Name = "txtExcelReadData";
            this.txtExcelReadData.ReadOnly = true;
            this.txtExcelReadData.Size = new System.Drawing.Size(719, 61);
            this.txtExcelReadData.TabIndex = 9;
            // 
            // txtExcelDirectory
            // 
            this.txtExcelDirectory.Location = new System.Drawing.Point(456, 91);
            this.txtExcelDirectory.Name = "txtExcelDirectory";
            this.txtExcelDirectory.ReadOnly = true;
            this.txtExcelDirectory.Size = new System.Drawing.Size(199, 21);
            this.txtExcelDirectory.TabIndex = 11;
            // 
            // lblExcelDirectory
            // 
            this.lblExcelDirectory.Location = new System.Drawing.Point(361, 84);
            this.lblExcelDirectory.Name = "lblExcelDirectory";
            this.lblExcelDirectory.Size = new System.Drawing.Size(89, 33);
            this.lblExcelDirectory.TabIndex = 12;
            this.lblExcelDirectory.Text = "Excel \r\nDirectory";
            this.lblExcelDirectory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnExcelDirectoryBrowse
            // 
            this.btnExcelDirectoryBrowse.Location = new System.Drawing.Point(661, 89);
            this.btnExcelDirectoryBrowse.Name = "btnExcelDirectoryBrowse";
            this.btnExcelDirectoryBrowse.Size = new System.Drawing.Size(56, 23);
            this.btnExcelDirectoryBrowse.TabIndex = 13;
            this.btnExcelDirectoryBrowse.Text = "Browse";
            this.btnExcelDirectoryBrowse.UseVisualStyleBackColor = true;
            this.btnExcelDirectoryBrowse.Click += new System.EventHandler(this.btnExcelDirectoryBrowse_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 448);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbxAutoExecute);
            this.Controls.Add(this.gbxAccessInfo);
            this.Name = "MainForm";
            this.Text = "Work Automaiton Form by Selenium";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.gbxAccessInfo.ResumeLayout(false);
            this.gbxAccessInfo.PerformLayout();
            this.gbxAutoExecute.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxAccessInfo;
        private System.Windows.Forms.Label lblServerUrl;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.GroupBox gbxAutoExecute;
        public System.Windows.Forms.TextBox txtServerUrl;
        public System.Windows.Forms.TextBox txtId;
        public System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnDemo;
        private System.Windows.Forms.Label lblEmail;
        public System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.TextBox txtLog;
        public System.Windows.Forms.TextBox txtWebDriverDir;
        private System.Windows.Forms.Label lblWebDriverDir;
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.TextBox txtExcelReadData;
        private System.Windows.Forms.Label lblExcelDirectory;
        private System.Windows.Forms.Button btnExcelDirectoryBrowse;
        public System.Windows.Forms.TextBox txtExcelDirectory;
    }
}

