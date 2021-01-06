namespace InstagramBotApplication
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.LoginPanel = new System.Windows.Forms.Panel();
            this.passwordTbox = new System.Windows.Forms.TextBox();
            this.passwordLbl = new System.Windows.Forms.Label();
            this.userNameLbl = new System.Windows.Forms.Label();
            this.loginBtn = new System.Windows.Forms.Button();
            this.userNameTbox = new System.Windows.Forms.TextBox();
            this.LoginTitleLbl = new System.Windows.Forms.Label();
            this.titlePanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.appTitleLbl = new System.Windows.Forms.Label();
            this.descriptionPanel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.applicationPanel = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.LoginPanel.SuspendLayout();
            this.titlePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.descriptionPanel.SuspendLayout();
            this.applicationPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // LoginPanel
            // 
            this.LoginPanel.BackColor = System.Drawing.Color.GhostWhite;
            this.LoginPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LoginPanel.Controls.Add(this.passwordTbox);
            this.LoginPanel.Controls.Add(this.passwordLbl);
            this.LoginPanel.Controls.Add(this.userNameLbl);
            this.LoginPanel.Controls.Add(this.loginBtn);
            this.LoginPanel.Controls.Add(this.userNameTbox);
            this.LoginPanel.Controls.Add(this.LoginTitleLbl);
            this.LoginPanel.Location = new System.Drawing.Point(12, 12);
            this.LoginPanel.Name = "LoginPanel";
            this.LoginPanel.Size = new System.Drawing.Size(205, 273);
            this.LoginPanel.TabIndex = 0;
            // 
            // passwordTbox
            // 
            this.passwordTbox.Location = new System.Drawing.Point(19, 146);
            this.passwordTbox.Multiline = true;
            this.passwordTbox.Name = "passwordTbox";
            this.passwordTbox.PasswordChar = '*';
            this.passwordTbox.Size = new System.Drawing.Size(165, 23);
            this.passwordTbox.TabIndex = 6;
            // 
            // passwordLbl
            // 
            this.passwordLbl.AutoSize = true;
            this.passwordLbl.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLbl.Location = new System.Drawing.Point(16, 128);
            this.passwordLbl.Name = "passwordLbl";
            this.passwordLbl.Size = new System.Drawing.Size(25, 15);
            this.passwordLbl.TabIndex = 5;
            this.passwordLbl.Text = "Şifre";
            // 
            // userNameLbl
            // 
            this.userNameLbl.AutoSize = true;
            this.userNameLbl.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameLbl.Location = new System.Drawing.Point(16, 84);
            this.userNameLbl.Name = "userNameLbl";
            this.userNameLbl.Size = new System.Drawing.Size(56, 15);
            this.userNameLbl.TabIndex = 4;
            this.userNameLbl.Text = "Kullanıcı adı";
            // 
            // loginBtn
            // 
            this.loginBtn.BackColor = System.Drawing.Color.SkyBlue;
            this.loginBtn.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginBtn.ForeColor = System.Drawing.Color.White;
            this.loginBtn.Location = new System.Drawing.Point(19, 180);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(165, 23);
            this.loginBtn.TabIndex = 3;
            this.loginBtn.Text = "Giriş Yap";
            this.loginBtn.UseVisualStyleBackColor = false;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // userNameTbox
            // 
            this.userNameTbox.Location = new System.Drawing.Point(19, 102);
            this.userNameTbox.Multiline = true;
            this.userNameTbox.Name = "userNameTbox";
            this.userNameTbox.Size = new System.Drawing.Size(165, 23);
            this.userNameTbox.TabIndex = 1;
            // 
            // LoginTitleLbl
            // 
            this.LoginTitleLbl.AutoSize = true;
            this.LoginTitleLbl.Font = new System.Drawing.Font("Lucida Handwriting", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginTitleLbl.Location = new System.Drawing.Point(13, 41);
            this.LoginTitleLbl.Name = "LoginTitleLbl";
            this.LoginTitleLbl.Size = new System.Drawing.Size(175, 34);
            this.LoginTitleLbl.TabIndex = 0;
            this.LoginTitleLbl.Text = "Instagram";
            // 
            // titlePanel
            // 
            this.titlePanel.BackColor = System.Drawing.SystemColors.Info;
            this.titlePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.titlePanel.Controls.Add(this.pictureBox1);
            this.titlePanel.Controls.Add(this.appTitleLbl);
            this.titlePanel.Location = new System.Drawing.Point(223, 12);
            this.titlePanel.Name = "titlePanel";
            this.titlePanel.Size = new System.Drawing.Size(669, 69);
            this.titlePanel.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(128, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(76, 46);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // appTitleLbl
            // 
            this.appTitleLbl.AutoSize = true;
            this.appTitleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.appTitleLbl.Location = new System.Drawing.Point(210, 18);
            this.appTitleLbl.Name = "appTitleLbl";
            this.appTitleLbl.Size = new System.Drawing.Size(323, 31);
            this.appTitleLbl.TabIndex = 0;
            this.appTitleLbl.Text = "Instagram Bot Application";
            // 
            // descriptionPanel
            // 
            this.descriptionPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.descriptionPanel.Controls.Add(this.label3);
            this.descriptionPanel.Controls.Add(this.label2);
            this.descriptionPanel.Controls.Add(this.label1);
            this.descriptionPanel.Font = new System.Drawing.Font("Mongolian Baiti", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionPanel.Location = new System.Drawing.Point(223, 87);
            this.descriptionPanel.Name = "descriptionPanel";
            this.descriptionPanel.Size = new System.Drawing.Size(669, 198);
            this.descriptionPanel.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(623, 48);
            this.label3.TabIndex = 2;
            this.label3.Text = "Uygulama giriş bilgilerinizi hiç bir şekilde kaydetmez. Sadece instagrama giriş y" +
    "apılabilmesi için InstaSharper kütüphanesi ile API entegrasyonunda kullanılır.";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(623, 48);
            this.label2.TabIndex = 1;
            this.label2.Text = "Yandaki giriş ekranına kullanıcı adı ve şifrenizi girdiğinizde karşınıza takip/ta" +
    "kipçi listeleri yüklenecektir.";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(623, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bu uygulama instagram hesabınızdaki takipçilerinizi ve takip ettiğiniz kişileri k" +
    "olay ve güvenli bir şekilde görüntüleyebilmeniz için geliştirilmiştir.";
            // 
            // applicationPanel
            // 
            this.applicationPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.applicationPanel.Controls.Add(this.label5);
            this.applicationPanel.Controls.Add(this.label4);
            this.applicationPanel.Controls.Add(this.dataGridView2);
            this.applicationPanel.Controls.Add(this.dataGridView1);
            this.applicationPanel.Location = new System.Drawing.Point(223, 87);
            this.applicationPanel.Name = "applicationPanel";
            this.applicationPanel.Size = new System.Drawing.Size(669, 198);
            this.applicationPanel.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(426, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 11);
            this.label5.TabIndex = 3;
            this.label5.Text = "Geri Takip Etmedikleriniz";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(96, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 11);
            this.label4.TabIndex = 2;
            this.label4.Text = "Geri Takip Etmeyenler";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(360, 41);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(289, 135);
            this.dataGridView2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(25, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(289, 135);
            this.dataGridView1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 11F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 301);
            this.Controls.Add(this.applicationPanel);
            this.Controls.Add(this.descriptionPanel);
            this.Controls.Add(this.titlePanel);
            this.Controls.Add(this.LoginPanel);
            this.Font = new System.Drawing.Font("NSimSun", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Instagram Bot Application";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.LoginPanel.ResumeLayout(false);
            this.LoginPanel.PerformLayout();
            this.titlePanel.ResumeLayout(false);
            this.titlePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.descriptionPanel.ResumeLayout(false);
            this.applicationPanel.ResumeLayout(false);
            this.applicationPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel LoginPanel;
        private System.Windows.Forms.Label LoginTitleLbl;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.TextBox userNameTbox;
        private System.Windows.Forms.Label passwordLbl;
        private System.Windows.Forms.Label userNameLbl;
        private System.Windows.Forms.Panel titlePanel;
        private System.Windows.Forms.Label appTitleLbl;
        private System.Windows.Forms.Panel descriptionPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel applicationPanel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox passwordTbox;
    }
}

