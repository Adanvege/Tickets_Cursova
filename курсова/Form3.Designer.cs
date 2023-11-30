namespace курсова
{
    partial class loginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loginForm));
            this.loginBox = new System.Windows.Forms.TextBox();
            this.loginLable = new System.Windows.Forms.Label();
            this.passwordLable = new System.Windows.Forms.Label();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.Login = new System.Windows.Forms.Button();
            this.GoToRegisterForm = new System.Windows.Forms.Button();
            this.showPassword = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.returnToMain = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.returnToMain)).BeginInit();
            this.SuspendLayout();
            // 
            // loginBox
            // 
            this.loginBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(42)))), ((int)(((byte)(82)))));
            this.loginBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(230)))), ((int)(((byte)(170)))));
            this.loginBox.Location = new System.Drawing.Point(12, 132);
            this.loginBox.Name = "loginBox";
            this.loginBox.Size = new System.Drawing.Size(340, 38);
            this.loginBox.TabIndex = 0;
            // 
            // loginLable
            // 
            this.loginLable.AutoSize = true;
            this.loginLable.Location = new System.Drawing.Point(12, 113);
            this.loginLable.Name = "loginLable";
            this.loginLable.Size = new System.Drawing.Size(34, 13);
            this.loginLable.TabIndex = 1;
            this.loginLable.Text = "Логін";
            // 
            // passwordLable
            // 
            this.passwordLable.AutoSize = true;
            this.passwordLable.Location = new System.Drawing.Point(12, 197);
            this.passwordLable.Name = "passwordLable";
            this.passwordLable.Size = new System.Drawing.Size(45, 13);
            this.passwordLable.TabIndex = 3;
            this.passwordLable.Text = "Пароль";
            // 
            // passwordBox
            // 
            this.passwordBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(42)))), ((int)(((byte)(82)))));
            this.passwordBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(230)))), ((int)(((byte)(170)))));
            this.passwordBox.Location = new System.Drawing.Point(12, 216);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(340, 38);
            this.passwordBox.TabIndex = 2;
            // 
            // Login
            // 
            this.Login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(42)))), ((int)(((byte)(82)))));
            this.Login.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(230)))), ((int)(((byte)(170)))));
            this.Login.Location = new System.Drawing.Point(12, 303);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(340, 57);
            this.Login.TabIndex = 4;
            this.Login.Text = "Вхід";
            this.Login.UseVisualStyleBackColor = false;
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // GoToRegisterForm
            // 
            this.GoToRegisterForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(42)))), ((int)(((byte)(82)))));
            this.GoToRegisterForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(230)))), ((int)(((byte)(170)))));
            this.GoToRegisterForm.Location = new System.Drawing.Point(12, 366);
            this.GoToRegisterForm.Name = "GoToRegisterForm";
            this.GoToRegisterForm.Size = new System.Drawing.Size(340, 57);
            this.GoToRegisterForm.TabIndex = 5;
            this.GoToRegisterForm.Text = "Зареєструватися";
            this.GoToRegisterForm.UseVisualStyleBackColor = false;
            this.GoToRegisterForm.Click += new System.EventHandler(this.GoToRegisterForm_Click);
            // 
            // showPassword
            // 
            this.showPassword.AutoSize = true;
            this.showPassword.Location = new System.Drawing.Point(12, 260);
            this.showPassword.Name = "showPassword";
            this.showPassword.Size = new System.Drawing.Size(114, 17);
            this.showPassword.TabIndex = 7;
            this.showPassword.Text = "Показати пароль";
            this.showPassword.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::курсова.Properties.Resources.logo_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(132, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // returnToMain
            // 
            this.returnToMain.Image = global::курсова.Properties.Resources.return_104;
            this.returnToMain.Location = new System.Drawing.Point(-2, -1);
            this.returnToMain.Name = "returnToMain";
            this.returnToMain.Size = new System.Drawing.Size(35, 35);
            this.returnToMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.returnToMain.TabIndex = 17;
            this.returnToMain.TabStop = false;
            this.returnToMain.Click += new System.EventHandler(this.returnToMain_Click);
            // 
            // loginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(66)))), ((int)(((byte)(107)))));
            this.ClientSize = new System.Drawing.Size(364, 451);
            this.Controls.Add(this.returnToMain);
            this.Controls.Add(this.showPassword);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.GoToRegisterForm);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.passwordLable);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.loginLable);
            this.Controls.Add(this.loginBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "loginForm";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.returnToMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox loginBox;
        private System.Windows.Forms.Label loginLable;
        private System.Windows.Forms.Label passwordLable;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.Button Login;
        private System.Windows.Forms.Button GoToRegisterForm;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox showPassword;
        private System.Windows.Forms.PictureBox returnToMain;
    }
}