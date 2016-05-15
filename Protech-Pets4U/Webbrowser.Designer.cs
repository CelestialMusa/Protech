namespace Protech_Pets4U
{
    partial class Webbrowser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Webbrowser));
            this.labelHomeProtechSlogan = new System.Windows.Forms.Label();
            this.labelHomeProtech = new System.Windows.Forms.Label();
            this.labelBack = new System.Windows.Forms.Label();
            this.pictureBoxInformationDeveloperLogo = new System.Windows.Forms.PictureBox();
            this.pictureBoxBack = new System.Windows.Forms.PictureBox();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInformationDeveloperLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBack)).BeginInit();
            this.SuspendLayout();
            // 
            // labelHomeProtechSlogan
            // 
            this.labelHomeProtechSlogan.AutoSize = true;
            this.labelHomeProtechSlogan.BackColor = System.Drawing.Color.Transparent;
            this.labelHomeProtechSlogan.Location = new System.Drawing.Point(93, 647);
            this.labelHomeProtechSlogan.Name = "labelHomeProtechSlogan";
            this.labelHomeProtechSlogan.Size = new System.Drawing.Size(151, 13);
            this.labelHomeProtechSlogan.TabIndex = 109;
            this.labelHomeProtechSlogan.Text = "Innovation through technology";
            // 
            // labelHomeProtech
            // 
            this.labelHomeProtech.AutoSize = true;
            this.labelHomeProtech.BackColor = System.Drawing.Color.Transparent;
            this.labelHomeProtech.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHomeProtech.Location = new System.Drawing.Point(30, 595);
            this.labelHomeProtech.Name = "labelHomeProtech";
            this.labelHomeProtech.Size = new System.Drawing.Size(197, 55);
            this.labelHomeProtech.TabIndex = 108;
            this.labelHomeProtech.Text = "Protech";
            // 
            // labelBack
            // 
            this.labelBack.AutoSize = true;
            this.labelBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.labelBack.Location = new System.Drawing.Point(52, 103);
            this.labelBack.Name = "labelBack";
            this.labelBack.Size = new System.Drawing.Size(43, 16);
            this.labelBack.TabIndex = 106;
            this.labelBack.Text = "Back";
            // 
            // pictureBoxInformationDeveloperLogo
            // 
            this.pictureBoxInformationDeveloperLogo.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxInformationDeveloperLogo.BackgroundImage = global::Protech_Pets4U.Properties.Resources.Entypo_f336_0__1024;
            this.pictureBoxInformationDeveloperLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxInformationDeveloperLogo.Location = new System.Drawing.Point(-46, 382);
            this.pictureBoxInformationDeveloperLogo.Name = "pictureBoxInformationDeveloperLogo";
            this.pictureBoxInformationDeveloperLogo.Size = new System.Drawing.Size(273, 251);
            this.pictureBoxInformationDeveloperLogo.TabIndex = 107;
            this.pictureBoxInformationDeveloperLogo.TabStop = false;
            // 
            // pictureBoxBack
            // 
            this.pictureBoxBack.BackColor = System.Drawing.Color.White;
            this.pictureBoxBack.BackgroundImage = global::Protech_Pets4U.Properties.Resources.octicons_f040_0__256;
            this.pictureBoxBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxBack.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxBack.Name = "pictureBoxBack";
            this.pictureBoxBack.Size = new System.Drawing.Size(109, 88);
            this.pictureBoxBack.TabIndex = 105;
            this.pictureBoxBack.TabStop = false;
            this.pictureBoxBack.Click += new System.EventHandler(this.pictureBoxBack_Click);
            this.pictureBoxBack.MouseLeave += new System.EventHandler(this.pictureBoxBack_MouseLeave);
            this.pictureBoxBack.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBoxBack_MouseMove);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(250, 28);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(882, 622);
            this.webBrowser1.TabIndex = 110;
            this.webBrowser1.Url = new System.Uri("http://www.google.com", System.UriKind.Absolute);
            // 
            // Webbrowser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1144, 662);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.labelHomeProtechSlogan);
            this.Controls.Add(this.labelHomeProtech);
            this.Controls.Add(this.pictureBoxInformationDeveloperLogo);
            this.Controls.Add(this.labelBack);
            this.Controls.Add(this.pictureBoxBack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Webbrowser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Protech technologies";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInformationDeveloperLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelHomeProtechSlogan;
        private System.Windows.Forms.Label labelHomeProtech;
        private System.Windows.Forms.PictureBox pictureBoxInformationDeveloperLogo;
        private System.Windows.Forms.Label labelBack;
        private System.Windows.Forms.PictureBox pictureBoxBack;
        private System.Windows.Forms.WebBrowser webBrowser1;
    }
}