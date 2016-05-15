namespace Protech_Pets4U
{
    partial class HomePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            this.panelHomeStatus = new System.Windows.Forms.Panel();
            this.buttonHomeLogin = new System.Windows.Forms.Button();
            this.linkLabelHavingTrouble = new System.Windows.Forms.LinkLabel();
            this.labelHomePassword = new System.Windows.Forms.Label();
            this.labelUsername = new System.Windows.Forms.Label();
            this.comboBoxHomeUserNames = new System.Windows.Forms.ComboBox();
            this.textBoxHomePassword = new System.Windows.Forms.TextBox();
            this.labelHomeExit = new System.Windows.Forms.Label();
            this.pictureBoxExitHome = new System.Windows.Forms.PictureBox();
            this.labelHomeProtech = new System.Windows.Forms.Label();
            this.labelHomeProtechSlogan = new System.Windows.Forms.Label();
            this.panelHomeInformation = new System.Windows.Forms.Panel();
            this.pictureBoxHomePicture = new System.Windows.Forms.PictureBox();
            this.pictureBoxHomeCopyRight = new System.Windows.Forms.PictureBox();
            this.pictureBoxInformationDeveloperLogo = new System.Windows.Forms.PictureBox();
            this.panelHomeHavingTrouble = new System.Windows.Forms.Panel();
            this.buttonHomeHavingTroubleSubmitAnswer = new System.Windows.Forms.Button();
            this.pictureBoxHomeHavingTroubleProtechLogo = new System.Windows.Forms.PictureBox();
            this.labelHomeHavingTroubleQuestion = new System.Windows.Forms.Label();
            this.comboBoxHomeHavingTroubleUserName = new System.Windows.Forms.ComboBox();
            this.textBoxHomeHavingTroubleAnswer = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panelHomeStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExitHome)).BeginInit();
            this.panelHomeInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHomePicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHomeCopyRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInformationDeveloperLogo)).BeginInit();
            this.panelHomeHavingTrouble.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHomeHavingTroubleProtechLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHomeStatus
            // 
            this.panelHomeStatus.BackColor = System.Drawing.Color.SeaGreen;
            this.panelHomeStatus.Controls.Add(this.buttonHomeLogin);
            this.panelHomeStatus.Controls.Add(this.linkLabelHavingTrouble);
            this.panelHomeStatus.Controls.Add(this.labelHomePassword);
            this.panelHomeStatus.Controls.Add(this.labelUsername);
            this.panelHomeStatus.Controls.Add(this.comboBoxHomeUserNames);
            this.panelHomeStatus.Controls.Add(this.textBoxHomePassword);
            this.panelHomeStatus.Controls.Add(this.labelHomeExit);
            this.panelHomeStatus.Controls.Add(this.pictureBoxExitHome);
            this.panelHomeStatus.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHomeStatus.Location = new System.Drawing.Point(0, 0);
            this.panelHomeStatus.Name = "panelHomeStatus";
            this.panelHomeStatus.Size = new System.Drawing.Size(1144, 100);
            this.panelHomeStatus.TabIndex = 0;
            // 
            // buttonHomeLogin
            // 
            this.buttonHomeLogin.Location = new System.Drawing.Point(729, 32);
            this.buttonHomeLogin.Name = "buttonHomeLogin";
            this.buttonHomeLogin.Size = new System.Drawing.Size(75, 23);
            this.buttonHomeLogin.TabIndex = 8;
            this.buttonHomeLogin.Text = "Login";
            this.buttonHomeLogin.UseVisualStyleBackColor = true;
            this.buttonHomeLogin.Click += new System.EventHandler(this.buttonHomeLogin_Click);
            // 
            // linkLabelHavingTrouble
            // 
            this.linkLabelHavingTrouble.AutoSize = true;
            this.linkLabelHavingTrouble.LinkColor = System.Drawing.Color.White;
            this.linkLabelHavingTrouble.Location = new System.Drawing.Point(507, 61);
            this.linkLabelHavingTrouble.Name = "linkLabelHavingTrouble";
            this.linkLabelHavingTrouble.Size = new System.Drawing.Size(82, 13);
            this.linkLabelHavingTrouble.TabIndex = 7;
            this.linkLabelHavingTrouble.TabStop = true;
            this.linkLabelHavingTrouble.Text = "Having trouble?";
            this.linkLabelHavingTrouble.VisitedLinkColor = System.Drawing.Color.Silver;
            this.linkLabelHavingTrouble.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelHavingTrouble_LinkClicked);
            // 
            // labelHomePassword
            // 
            this.labelHomePassword.AutoSize = true;
            this.labelHomePassword.ForeColor = System.Drawing.Color.White;
            this.labelHomePassword.Location = new System.Drawing.Point(504, 17);
            this.labelHomePassword.Name = "labelHomePassword";
            this.labelHomePassword.Size = new System.Drawing.Size(53, 13);
            this.labelHomePassword.TabIndex = 6;
            this.labelHomePassword.Text = "Password";
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.ForeColor = System.Drawing.Color.White;
            this.labelUsername.Location = new System.Drawing.Point(287, 17);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(58, 13);
            this.labelUsername.TabIndex = 5;
            this.labelUsername.Text = "User name";
            // 
            // comboBoxHomeUserNames
            // 
            this.comboBoxHomeUserNames.FormattingEnabled = true;
            this.comboBoxHomeUserNames.Location = new System.Drawing.Point(288, 33);
            this.comboBoxHomeUserNames.Name = "comboBoxHomeUserNames";
            this.comboBoxHomeUserNames.Size = new System.Drawing.Size(186, 21);
            this.comboBoxHomeUserNames.TabIndex = 4;
            // 
            // textBoxHomePassword
            // 
            this.textBoxHomePassword.Location = new System.Drawing.Point(507, 34);
            this.textBoxHomePassword.Name = "textBoxHomePassword";
            this.textBoxHomePassword.PasswordChar = '•';
            this.textBoxHomePassword.Size = new System.Drawing.Size(197, 20);
            this.textBoxHomePassword.TabIndex = 3;
            this.textBoxHomePassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelHomeExit
            // 
            this.labelHomeExit.AutoSize = true;
            this.labelHomeExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHomeExit.Location = new System.Drawing.Point(1071, 74);
            this.labelHomeExit.Name = "labelHomeExit";
            this.labelHomeExit.Size = new System.Drawing.Size(33, 16);
            this.labelHomeExit.TabIndex = 1;
            this.labelHomeExit.Text = "Exit";
            // 
            // pictureBoxExitHome
            // 
            this.pictureBoxExitHome.BackgroundImage = global::Protech_Pets4U.Properties.Resources.FontAwesome_f011_0__2561;
            this.pictureBoxExitHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxExitHome.Location = new System.Drawing.Point(1031, 3);
            this.pictureBoxExitHome.Name = "pictureBoxExitHome";
            this.pictureBoxExitHome.Size = new System.Drawing.Size(110, 71);
            this.pictureBoxExitHome.TabIndex = 0;
            this.pictureBoxExitHome.TabStop = false;
            this.pictureBoxExitHome.Click += new System.EventHandler(this.pictureBoxExitHome_Click);
            this.pictureBoxExitHome.MouseLeave += new System.EventHandler(this.pictureBoxExitHome_MouseLeave);
            this.pictureBoxExitHome.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBoxExitHome_MouseMove);
            // 
            // labelHomeProtech
            // 
            this.labelHomeProtech.AutoSize = true;
            this.labelHomeProtech.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHomeProtech.Location = new System.Drawing.Point(174, 304);
            this.labelHomeProtech.Name = "labelHomeProtech";
            this.labelHomeProtech.Size = new System.Drawing.Size(197, 55);
            this.labelHomeProtech.TabIndex = 1;
            this.labelHomeProtech.Text = "Protech";
            // 
            // labelHomeProtechSlogan
            // 
            this.labelHomeProtechSlogan.AutoSize = true;
            this.labelHomeProtechSlogan.Location = new System.Drawing.Point(196, 363);
            this.labelHomeProtechSlogan.Name = "labelHomeProtechSlogan";
            this.labelHomeProtechSlogan.Size = new System.Drawing.Size(151, 13);
            this.labelHomeProtechSlogan.TabIndex = 2;
            this.labelHomeProtechSlogan.Text = "Innovation through technology";
            // 
            // panelHomeInformation
            // 
            this.panelHomeInformation.Controls.Add(this.pictureBoxHomePicture);
            this.panelHomeInformation.Controls.Add(this.pictureBoxHomeCopyRight);
            this.panelHomeInformation.Controls.Add(this.labelHomeProtechSlogan);
            this.panelHomeInformation.Controls.Add(this.labelHomeProtech);
            this.panelHomeInformation.Controls.Add(this.pictureBoxInformationDeveloperLogo);
            this.panelHomeInformation.Location = new System.Drawing.Point(12, 106);
            this.panelHomeInformation.Name = "panelHomeInformation";
            this.panelHomeInformation.Size = new System.Drawing.Size(1120, 544);
            this.panelHomeInformation.TabIndex = 1;
            // 
            // pictureBoxHomePicture
            // 
            this.pictureBoxHomePicture.BackgroundImage = global::Protech_Pets4U.Properties.Resources.untitled_pet_project_image_2__140124195237;
            this.pictureBoxHomePicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxHomePicture.Location = new System.Drawing.Point(463, 3);
            this.pictureBoxHomePicture.Name = "pictureBoxHomePicture";
            this.pictureBoxHomePicture.Size = new System.Drawing.Size(654, 466);
            this.pictureBoxHomePicture.TabIndex = 4;
            this.pictureBoxHomePicture.TabStop = false;
            // 
            // pictureBoxHomeCopyRight
            // 
            this.pictureBoxHomeCopyRight.BackgroundImage = global::Protech_Pets4U.Properties.Resources.Copyright;
            this.pictureBoxHomeCopyRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxHomeCopyRight.Location = new System.Drawing.Point(676, 475);
            this.pictureBoxHomeCopyRight.Name = "pictureBoxHomeCopyRight";
            this.pictureBoxHomeCopyRight.Size = new System.Drawing.Size(441, 66);
            this.pictureBoxHomeCopyRight.TabIndex = 3;
            this.pictureBoxHomeCopyRight.TabStop = false;
            // 
            // pictureBoxInformationDeveloperLogo
            // 
            this.pictureBoxInformationDeveloperLogo.BackgroundImage = global::Protech_Pets4U.Properties.Resources.Entypo_f336_0__1024;
            this.pictureBoxInformationDeveloperLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxInformationDeveloperLogo.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxInformationDeveloperLogo.Name = "pictureBoxInformationDeveloperLogo";
            this.pictureBoxInformationDeveloperLogo.Size = new System.Drawing.Size(440, 373);
            this.pictureBoxInformationDeveloperLogo.TabIndex = 0;
            this.pictureBoxInformationDeveloperLogo.TabStop = false;
            // 
            // panelHomeHavingTrouble
            // 
            this.panelHomeHavingTrouble.Controls.Add(this.buttonHomeHavingTroubleSubmitAnswer);
            this.panelHomeHavingTrouble.Controls.Add(this.pictureBoxHomeHavingTroubleProtechLogo);
            this.panelHomeHavingTrouble.Controls.Add(this.labelHomeHavingTroubleQuestion);
            this.panelHomeHavingTrouble.Controls.Add(this.comboBoxHomeHavingTroubleUserName);
            this.panelHomeHavingTrouble.Controls.Add(this.textBoxHomeHavingTroubleAnswer);
            this.panelHomeHavingTrouble.Controls.Add(this.pictureBox1);
            this.panelHomeHavingTrouble.Controls.Add(this.pictureBox2);
            this.panelHomeHavingTrouble.Location = new System.Drawing.Point(12, 106);
            this.panelHomeHavingTrouble.Name = "panelHomeHavingTrouble";
            this.panelHomeHavingTrouble.Size = new System.Drawing.Size(1120, 544);
            this.panelHomeHavingTrouble.TabIndex = 5;
            // 
            // buttonHomeHavingTroubleSubmitAnswer
            // 
            this.buttonHomeHavingTroubleSubmitAnswer.Location = new System.Drawing.Point(199, 404);
            this.buttonHomeHavingTroubleSubmitAnswer.Name = "buttonHomeHavingTroubleSubmitAnswer";
            this.buttonHomeHavingTroubleSubmitAnswer.Size = new System.Drawing.Size(75, 23);
            this.buttonHomeHavingTroubleSubmitAnswer.TabIndex = 9;
            this.buttonHomeHavingTroubleSubmitAnswer.Text = "Submit";
            this.buttonHomeHavingTroubleSubmitAnswer.UseVisualStyleBackColor = true;
            this.buttonHomeHavingTroubleSubmitAnswer.Click += new System.EventHandler(this.buttonHomeHavingTroubleSubmitAnswer_Click);
            // 
            // pictureBoxHomeHavingTroubleProtechLogo
            // 
            this.pictureBoxHomeHavingTroubleProtechLogo.BackgroundImage = global::Protech_Pets4U.Properties.Resources.Entypo_f336_0__1024;
            this.pictureBoxHomeHavingTroubleProtechLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxHomeHavingTroubleProtechLogo.Location = new System.Drawing.Point(139, 149);
            this.pictureBoxHomeHavingTroubleProtechLogo.Name = "pictureBoxHomeHavingTroubleProtechLogo";
            this.pictureBoxHomeHavingTroubleProtechLogo.Size = new System.Drawing.Size(182, 135);
            this.pictureBoxHomeHavingTroubleProtechLogo.TabIndex = 8;
            this.pictureBoxHomeHavingTroubleProtechLogo.TabStop = false;
            // 
            // labelHomeHavingTroubleQuestion
            // 
            this.labelHomeHavingTroubleQuestion.AutoSize = true;
            this.labelHomeHavingTroubleQuestion.Location = new System.Drawing.Point(67, 335);
            this.labelHomeHavingTroubleQuestion.Name = "labelHomeHavingTroubleQuestion";
            this.labelHomeHavingTroubleQuestion.Size = new System.Drawing.Size(170, 13);
            this.labelHomeHavingTroubleQuestion.TabIndex = 7;
            this.labelHomeHavingTroubleQuestion.Text = "Select a user to retrieve password.";
            // 
            // comboBoxHomeHavingTroubleUserName
            // 
            this.comboBoxHomeHavingTroubleUserName.FormattingEnabled = true;
            this.comboBoxHomeHavingTroubleUserName.Location = new System.Drawing.Point(70, 300);
            this.comboBoxHomeHavingTroubleUserName.Name = "comboBoxHomeHavingTroubleUserName";
            this.comboBoxHomeHavingTroubleUserName.Size = new System.Drawing.Size(323, 21);
            this.comboBoxHomeHavingTroubleUserName.TabIndex = 6;
            this.comboBoxHomeHavingTroubleUserName.SelectedIndexChanged += new System.EventHandler(this.comboBoxHomeHavingTroubleUserName_SelectedIndexChanged);
            // 
            // textBoxHomeHavingTroubleAnswer
            // 
            this.textBoxHomeHavingTroubleAnswer.Location = new System.Drawing.Point(70, 365);
            this.textBoxHomeHavingTroubleAnswer.Name = "textBoxHomeHavingTroubleAnswer";
            this.textBoxHomeHavingTroubleAnswer.Size = new System.Drawing.Size(323, 20);
            this.textBoxHomeHavingTroubleAnswer.TabIndex = 5;
            this.textBoxHomeHavingTroubleAnswer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Protech_Pets4U.Properties.Resources.untitled_pet_project_image_2__140124195237;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(463, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(654, 466);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::Protech_Pets4U.Properties.Resources.Copyright;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(676, 475);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(441, 66);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1144, 662);
            this.Controls.Add(this.panelHomeStatus);
            this.Controls.Add(this.panelHomeInformation);
            this.Controls.Add(this.panelHomeHavingTrouble);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "HomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Protech technologies";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.HomePage_FormClosed);
            this.Load += new System.EventHandler(this.HomePage_Load);
            this.panelHomeStatus.ResumeLayout(false);
            this.panelHomeStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExitHome)).EndInit();
            this.panelHomeInformation.ResumeLayout(false);
            this.panelHomeInformation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHomePicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHomeCopyRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInformationDeveloperLogo)).EndInit();
            this.panelHomeHavingTrouble.ResumeLayout(false);
            this.panelHomeHavingTrouble.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHomeHavingTroubleProtechLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHomeStatus;
        private System.Windows.Forms.PictureBox pictureBoxExitHome;
        private System.Windows.Forms.Label labelHomeExit;
        private System.Windows.Forms.LinkLabel linkLabelHavingTrouble;
        private System.Windows.Forms.Label labelHomePassword;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.ComboBox comboBoxHomeUserNames;
        private System.Windows.Forms.TextBox textBoxHomePassword;
        private System.Windows.Forms.Button buttonHomeLogin;
        private System.Windows.Forms.PictureBox pictureBoxInformationDeveloperLogo;
        private System.Windows.Forms.Label labelHomeProtech;
        private System.Windows.Forms.Label labelHomeProtechSlogan;
        private System.Windows.Forms.PictureBox pictureBoxHomeCopyRight;
        private System.Windows.Forms.PictureBox pictureBoxHomePicture;
        private System.Windows.Forms.Panel panelHomeInformation;
        private System.Windows.Forms.Panel panelHomeHavingTrouble;
        private System.Windows.Forms.Button buttonHomeHavingTroubleSubmitAnswer;
        private System.Windows.Forms.PictureBox pictureBoxHomeHavingTroubleProtechLogo;
        private System.Windows.Forms.Label labelHomeHavingTroubleQuestion;
        private System.Windows.Forms.ComboBox comboBoxHomeHavingTroubleUserName;
        private System.Windows.Forms.TextBox textBoxHomeHavingTroubleAnswer;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

