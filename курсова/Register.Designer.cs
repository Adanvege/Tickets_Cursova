namespace курсова
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            this.showPassword = new System.Windows.Forms.CheckBox();
            this.RegisterButton = new System.Windows.Forms.Button();
            this.passwordLable = new System.Windows.Forms.Label();
            this.passwordRegisterBox = new System.Windows.Forms.TextBox();
            this.loginLable = new System.Windows.Forms.Label();
            this.loginRegisterBox = new System.Windows.Forms.TextBox();
            this.returnToMain = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.returnToMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // showPassword
            // 
            this.showPassword.AutoSize = true;
            this.showPassword.Location = new System.Drawing.Point(12, 268);
            this.showPassword.Name = "showPassword";
            this.showPassword.Size = new System.Drawing.Size(114, 17);
            this.showPassword.TabIndex = 15;
            this.showPassword.Text = "Показати пароль";
            this.showPassword.UseVisualStyleBackColor = true;
            // 
            // RegisterButton
            // 
            this.RegisterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(119)))), ((int)(((byte)(119)))));
            this.RegisterButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(218)))));
            this.RegisterButton.Location = new System.Drawing.Point(12, 324);
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.Size = new System.Drawing.Size(340, 57);
            this.RegisterButton.TabIndex = 12;
            this.RegisterButton.Text = "Зареєструватися";
            this.RegisterButton.UseVisualStyleBackColor = false;
            this.RegisterButton.Click += new System.EventHandler(this.RegisterButton_Click);
            // 
            // passwordLable
            // 
            this.passwordLable.AutoSize = true;
            this.passwordLable.Location = new System.Drawing.Point(12, 205);
            this.passwordLable.Name = "passwordLable";
            this.passwordLable.Size = new System.Drawing.Size(45, 13);
            this.passwordLable.TabIndex = 11;
            this.passwordLable.Text = "Пароль";
            // 
            // passwordRegisterBox
            // 
            this.passwordRegisterBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(119)))), ((int)(((byte)(119)))));
            this.passwordRegisterBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordRegisterBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(218)))));
            this.passwordRegisterBox.Location = new System.Drawing.Point(12, 224);
            this.passwordRegisterBox.Name = "passwordRegisterBox";
            this.passwordRegisterBox.Size = new System.Drawing.Size(340, 38);
            this.passwordRegisterBox.TabIndex = 10;
            // 
            // loginLable
            // 
            this.loginLable.AutoSize = true;
            this.loginLable.Location = new System.Drawing.Point(12, 121);
            this.loginLable.Name = "loginLable";
            this.loginLable.Size = new System.Drawing.Size(34, 13);
            this.loginLable.TabIndex = 9;
            this.loginLable.Text = "Логін";
            // 
            // loginRegisterBox
            // 
            this.loginRegisterBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(119)))), ((int)(((byte)(119)))));
            this.loginRegisterBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginRegisterBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(218)))));
            this.loginRegisterBox.Location = new System.Drawing.Point(12, 140);
            this.loginRegisterBox.Name = "loginRegisterBox";
            this.loginRegisterBox.Size = new System.Drawing.Size(340, 38);
            this.loginRegisterBox.TabIndex = 8;
            // 
            // returnToMain
            // 
            this.returnToMain.Image = global::курсова.Properties.Resources.return_104;
            this.returnToMain.Location = new System.Drawing.Point(0, 0);
            this.returnToMain.Name = "returnToMain";
            this.returnToMain.Size = new System.Drawing.Size(35, 35);
            this.returnToMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.returnToMain.TabIndex = 16;
            this.returnToMain.TabStop = false;
            this.returnToMain.Click += new System.EventHandler(this.returnToMain_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::курсова.Properties.Resources.logo_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(132, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(206)))), ((int)(((byte)(150)))));
            this.ClientSize = new System.Drawing.Size(364, 451);
            this.Controls.Add(this.returnToMain);
            this.Controls.Add(this.showPassword);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.RegisterButton);
            this.Controls.Add(this.passwordLable);
            this.Controls.Add(this.passwordRegisterBox);
            this.Controls.Add(this.loginLable);
            this.Controls.Add(this.loginRegisterBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Register";
            this.Load += new System.EventHandler(this.Register_Load);
            ((System.ComponentModel.ISupportInitialize)(this.returnToMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox showPassword;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button RegisterButton;
        private System.Windows.Forms.Label passwordLable;
        private System.Windows.Forms.TextBox passwordRegisterBox;
        private System.Windows.Forms.Label loginLable;
        private System.Windows.Forms.TextBox loginRegisterBox;
        private System.Windows.Forms.PictureBox returnToMain;
    }
}