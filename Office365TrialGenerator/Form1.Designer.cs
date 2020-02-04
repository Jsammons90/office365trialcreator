namespace Office365TrialGenerator
{
    partial class office365TrialGenFrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(office365TrialGenFrm));
            this.officeLbl = new System.Windows.Forms.Label();
            this.overviewLbl = new System.Windows.Forms.Label();
            this.fNameLbl = new System.Windows.Forms.Label();
            this.lNameLbl = new System.Windows.Forms.Label();
            this.emailAddressLbl = new System.Windows.Forms.Label();
            this.regionLbl = new System.Windows.Forms.Label();
            this.phoneNumberLbl = new System.Windows.Forms.Label();
            this.passwordLbl = new System.Windows.Forms.Label();
            this.fNameTxt = new System.Windows.Forms.TextBox();
            this.userIdTxt = new System.Windows.Forms.TextBox();
            this.domainNameTxt = new System.Windows.Forms.TextBox();
            this.orgNameTxt = new System.Windows.Forms.TextBox();
            this.passwordTxt = new System.Windows.Forms.TextBox();
            this.phoneNumberTxt = new System.Windows.Forms.TextBox();
            this.emailAddressTxt = new System.Windows.Forms.TextBox();
            this.lNameTxt = new System.Windows.Forms.TextBox();
            this.regionTxt = new System.Windows.Forms.ComboBox();
            this.orgNameLbl = new System.Windows.Forms.Label();
            this.domainNameLbl = new System.Windows.Forms.Label();
            this.userIdLbl = new System.Windows.Forms.Label();
            this.challengeAnswerLbl = new System.Windows.Forms.Label();
            this.challengeAnswerTxt = new System.Windows.Forms.TextBox();
            this.sendSMSBtn = new System.Windows.Forms.Button();
            this.authBtn = new System.Windows.Forms.Button();
            this.createAccountBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // officeLbl
            // 
            this.officeLbl.AutoSize = true;
            this.officeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.officeLbl.Location = new System.Drawing.Point(218, 9);
            this.officeLbl.Name = "officeLbl";
            this.officeLbl.Size = new System.Drawing.Size(327, 31);
            this.officeLbl.TabIndex = 3;
            this.officeLbl.Text = "Office 365 Trial Generator";
            // 
            // overviewLbl
            // 
            this.overviewLbl.AutoSize = true;
            this.overviewLbl.Location = new System.Drawing.Point(89, 40);
            this.overviewLbl.Name = "overviewLbl";
            this.overviewLbl.Size = new System.Drawing.Size(600, 17);
            this.overviewLbl.TabIndex = 4;
            this.overviewLbl.Text = "This tool is intended to simply the process of creating an Office 365 Trial for t" +
    "esting Dynamics.";
            this.overviewLbl.Click += new System.EventHandler(this.Label1_Click);
            // 
            // fNameLbl
            // 
            this.fNameLbl.AutoSize = true;
            this.fNameLbl.Location = new System.Drawing.Point(167, 96);
            this.fNameLbl.Name = "fNameLbl";
            this.fNameLbl.Size = new System.Drawing.Size(76, 17);
            this.fNameLbl.TabIndex = 5;
            this.fNameLbl.Text = "First Name";
            // 
            // lNameLbl
            // 
            this.lNameLbl.AutoSize = true;
            this.lNameLbl.Location = new System.Drawing.Point(544, 96);
            this.lNameLbl.Name = "lNameLbl";
            this.lNameLbl.Size = new System.Drawing.Size(76, 17);
            this.lNameLbl.TabIndex = 6;
            this.lNameLbl.Text = "Last Name";
            this.lNameLbl.Click += new System.EventHandler(this.Label2_Click);
            // 
            // emailAddressLbl
            // 
            this.emailAddressLbl.AutoSize = true;
            this.emailAddressLbl.Location = new System.Drawing.Point(89, 160);
            this.emailAddressLbl.Name = "emailAddressLbl";
            this.emailAddressLbl.Size = new System.Drawing.Size(42, 17);
            this.emailAddressLbl.TabIndex = 7;
            this.emailAddressLbl.Text = "Email";
            // 
            // regionLbl
            // 
            this.regionLbl.AutoSize = true;
            this.regionLbl.Location = new System.Drawing.Point(354, 160);
            this.regionLbl.Name = "regionLbl";
            this.regionLbl.Size = new System.Drawing.Size(53, 17);
            this.regionLbl.TabIndex = 8;
            this.regionLbl.Text = "Region";
            // 
            // phoneNumberLbl
            // 
            this.phoneNumberLbl.AutoSize = true;
            this.phoneNumberLbl.Location = new System.Drawing.Point(567, 160);
            this.phoneNumberLbl.Name = "phoneNumberLbl";
            this.phoneNumberLbl.Size = new System.Drawing.Size(103, 17);
            this.phoneNumberLbl.TabIndex = 9;
            this.phoneNumberLbl.Text = "Phone Number";
            // 
            // passwordLbl
            // 
            this.passwordLbl.AutoSize = true;
            this.passwordLbl.Location = new System.Drawing.Point(58, 282);
            this.passwordLbl.Name = "passwordLbl";
            this.passwordLbl.Size = new System.Drawing.Size(69, 17);
            this.passwordLbl.TabIndex = 10;
            this.passwordLbl.Text = "Password";
            // 
            // fNameTxt
            // 
            this.fNameTxt.Location = new System.Drawing.Point(170, 116);
            this.fNameTxt.Name = "fNameTxt";
            this.fNameTxt.Size = new System.Drawing.Size(179, 22);
            this.fNameTxt.TabIndex = 11;
            // 
            // userIdTxt
            // 
            this.userIdTxt.Location = new System.Drawing.Point(570, 313);
            this.userIdTxt.Name = "userIdTxt";
            this.userIdTxt.Size = new System.Drawing.Size(100, 22);
            this.userIdTxt.TabIndex = 12;
            // 
            // domainNameTxt
            // 
            this.domainNameTxt.Location = new System.Drawing.Point(424, 313);
            this.domainNameTxt.Name = "domainNameTxt";
            this.domainNameTxt.Size = new System.Drawing.Size(100, 22);
            this.domainNameTxt.TabIndex = 13;
            // 
            // orgNameTxt
            // 
            this.orgNameTxt.Location = new System.Drawing.Point(236, 313);
            this.orgNameTxt.Name = "orgNameTxt";
            this.orgNameTxt.Size = new System.Drawing.Size(100, 22);
            this.orgNameTxt.TabIndex = 14;
            // 
            // passwordTxt
            // 
            this.passwordTxt.Location = new System.Drawing.Point(61, 313);
            this.passwordTxt.Name = "passwordTxt";
            this.passwordTxt.Size = new System.Drawing.Size(100, 22);
            this.passwordTxt.TabIndex = 15;
            // 
            // phoneNumberTxt
            // 
            this.phoneNumberTxt.Location = new System.Drawing.Point(570, 180);
            this.phoneNumberTxt.Name = "phoneNumberTxt";
            this.phoneNumberTxt.Size = new System.Drawing.Size(163, 22);
            this.phoneNumberTxt.TabIndex = 16;
            // 
            // emailAddressTxt
            // 
            this.emailAddressTxt.Location = new System.Drawing.Point(92, 180);
            this.emailAddressTxt.Name = "emailAddressTxt";
            this.emailAddressTxt.Size = new System.Drawing.Size(172, 22);
            this.emailAddressTxt.TabIndex = 17;
            // 
            // lNameTxt
            // 
            this.lNameTxt.Location = new System.Drawing.Point(547, 116);
            this.lNameTxt.Name = "lNameTxt";
            this.lNameTxt.Size = new System.Drawing.Size(163, 22);
            this.lNameTxt.TabIndex = 18;
            // 
            // regionTxt
            // 
            this.regionTxt.FormattingEnabled = true;
            this.regionTxt.Items.AddRange(new object[] {
            "US",
            "IE"});
            this.regionTxt.Location = new System.Drawing.Point(319, 180);
            this.regionTxt.Name = "regionTxt";
            this.regionTxt.Size = new System.Drawing.Size(121, 24);
            this.regionTxt.TabIndex = 19;
            // 
            // orgNameLbl
            // 
            this.orgNameLbl.AutoSize = true;
            this.orgNameLbl.Location = new System.Drawing.Point(233, 282);
            this.orgNameLbl.Name = "orgNameLbl";
            this.orgNameLbl.Size = new System.Drawing.Size(130, 17);
            this.orgNameLbl.TabIndex = 21;
            this.orgNameLbl.Text = "Organization Name";
            // 
            // domainNameLbl
            // 
            this.domainNameLbl.AutoSize = true;
            this.domainNameLbl.Location = new System.Drawing.Point(421, 282);
            this.domainNameLbl.Name = "domainNameLbl";
            this.domainNameLbl.Size = new System.Drawing.Size(97, 17);
            this.domainNameLbl.TabIndex = 22;
            this.domainNameLbl.Text = "Domain Name";
            // 
            // userIdLbl
            // 
            this.userIdLbl.AutoSize = true;
            this.userIdLbl.Location = new System.Drawing.Point(587, 282);
            this.userIdLbl.Name = "userIdLbl";
            this.userIdLbl.Size = new System.Drawing.Size(55, 17);
            this.userIdLbl.TabIndex = 23;
            this.userIdLbl.Text = "User ID";
            // 
            // challengeAnswerLbl
            // 
            this.challengeAnswerLbl.AutoSize = true;
            this.challengeAnswerLbl.Location = new System.Drawing.Point(333, 379);
            this.challengeAnswerLbl.Name = "challengeAnswerLbl";
            this.challengeAnswerLbl.Size = new System.Drawing.Size(74, 17);
            this.challengeAnswerLbl.TabIndex = 24;
            this.challengeAnswerLbl.Text = "SMS Code";
            // 
            // challengeAnswerTxt
            // 
            this.challengeAnswerTxt.Location = new System.Drawing.Point(336, 399);
            this.challengeAnswerTxt.Name = "challengeAnswerTxt";
            this.challengeAnswerTxt.Size = new System.Drawing.Size(100, 22);
            this.challengeAnswerTxt.TabIndex = 25;
            // 
            // sendSMSBtn
            // 
            this.sendSMSBtn.Location = new System.Drawing.Point(61, 444);
            this.sendSMSBtn.Name = "sendSMSBtn";
            this.sendSMSBtn.Size = new System.Drawing.Size(107, 23);
            this.sendSMSBtn.TabIndex = 26;
            this.sendSMSBtn.Text = "Send SMS";
            this.sendSMSBtn.UseVisualStyleBackColor = true;
            this.sendSMSBtn.Click += new System.EventHandler(this.SendSMSBtn_Click);
            // 
            // authBtn
            // 
            this.authBtn.Location = new System.Drawing.Point(330, 444);
            this.authBtn.Name = "authBtn";
            this.authBtn.Size = new System.Drawing.Size(110, 23);
            this.authBtn.TabIndex = 27;
            this.authBtn.Text = "Authenticate";
            this.authBtn.UseVisualStyleBackColor = true;
            this.authBtn.Click += new System.EventHandler(this.AuthBtn_Click);
            // 
            // createAccountBtn
            // 
            this.createAccountBtn.Location = new System.Drawing.Point(607, 444);
            this.createAccountBtn.Name = "createAccountBtn";
            this.createAccountBtn.Size = new System.Drawing.Size(155, 23);
            this.createAccountBtn.TabIndex = 28;
            this.createAccountBtn.Text = "Create Account";
            this.createAccountBtn.UseVisualStyleBackColor = true;
            this.createAccountBtn.Click += new System.EventHandler(this.CreateAccountBtn_Click);
            // 
            // office365TrialGenFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 500);
            this.Controls.Add(this.createAccountBtn);
            this.Controls.Add(this.authBtn);
            this.Controls.Add(this.sendSMSBtn);
            this.Controls.Add(this.challengeAnswerTxt);
            this.Controls.Add(this.challengeAnswerLbl);
            this.Controls.Add(this.userIdLbl);
            this.Controls.Add(this.domainNameLbl);
            this.Controls.Add(this.orgNameLbl);
            this.Controls.Add(this.regionTxt);
            this.Controls.Add(this.lNameTxt);
            this.Controls.Add(this.emailAddressTxt);
            this.Controls.Add(this.phoneNumberTxt);
            this.Controls.Add(this.passwordTxt);
            this.Controls.Add(this.orgNameTxt);
            this.Controls.Add(this.domainNameTxt);
            this.Controls.Add(this.userIdTxt);
            this.Controls.Add(this.fNameTxt);
            this.Controls.Add(this.passwordLbl);
            this.Controls.Add(this.phoneNumberLbl);
            this.Controls.Add(this.regionLbl);
            this.Controls.Add(this.emailAddressLbl);
            this.Controls.Add(this.lNameLbl);
            this.Controls.Add(this.fNameLbl);
            this.Controls.Add(this.overviewLbl);
            this.Controls.Add(this.officeLbl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "office365TrialGenFrm";
            this.Text = "Office 365 Trial Generator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label officeLbl;
        private System.Windows.Forms.Label overviewLbl;
        private System.Windows.Forms.Label fNameLbl;
        private System.Windows.Forms.Label lNameLbl;
        private System.Windows.Forms.Label emailAddressLbl;
        private System.Windows.Forms.Label regionLbl;
        private System.Windows.Forms.Label phoneNumberLbl;
        private System.Windows.Forms.Label passwordLbl;
        private System.Windows.Forms.TextBox fNameTxt;
        private System.Windows.Forms.TextBox userIdTxt;
        private System.Windows.Forms.TextBox domainNameTxt;
        private System.Windows.Forms.TextBox orgNameTxt;
        private System.Windows.Forms.TextBox passwordTxt;
        private System.Windows.Forms.TextBox phoneNumberTxt;
        private System.Windows.Forms.TextBox emailAddressTxt;
        private System.Windows.Forms.TextBox lNameTxt;
        private System.Windows.Forms.ComboBox regionTxt;
        private System.Windows.Forms.Label orgNameLbl;
        private System.Windows.Forms.Label domainNameLbl;
        private System.Windows.Forms.Label userIdLbl;
        private System.Windows.Forms.Label challengeAnswerLbl;
        private System.Windows.Forms.TextBox challengeAnswerTxt;
        private System.Windows.Forms.Button sendSMSBtn;
        private System.Windows.Forms.Button authBtn;
        private System.Windows.Forms.Button createAccountBtn;
    }
}

