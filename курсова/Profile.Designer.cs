namespace курсова
{
    partial class Profile
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
            this.profileLoginLable = new System.Windows.Forms.Label();
            this.history = new System.Windows.Forms.RichTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.returnToMain = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.returnToMain)).BeginInit();
            this.SuspendLayout();
            // 
            // profileLoginLable
            // 
            this.profileLoginLable.AutoSize = true;
            this.profileLoginLable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(119)))), ((int)(((byte)(119)))));
            this.profileLoginLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.profileLoginLable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(218)))));
            this.profileLoginLable.Location = new System.Drawing.Point(15, 130);
            this.profileLoginLable.Name = "profileLoginLable";
            this.profileLoginLable.Size = new System.Drawing.Size(120, 25);
            this.profileLoginLable.TabIndex = 0;
            this.profileLoginLable.Text = "Ваш Логин";
            this.profileLoginLable.Click += new System.EventHandler(this.profileLoginLable_Click);
            // 
            // history
            // 
            this.history.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(119)))), ((int)(((byte)(119)))));
            this.history.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(218)))));
            this.history.Location = new System.Drawing.Point(139, 12);
            this.history.Name = "history";
            this.history.Size = new System.Drawing.Size(989, 617);
            this.history.TabIndex = 2;
            this.history.Text = "";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::курсова.Properties.Resources.logo_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(17, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(115, 115);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // returnToMain
            // 
            this.returnToMain.Image = global::курсова.Properties.Resources.return_104;
            this.returnToMain.Location = new System.Drawing.Point(17, 597);
            this.returnToMain.Name = "returnToMain";
            this.returnToMain.Size = new System.Drawing.Size(32, 32);
            this.returnToMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.returnToMain.TabIndex = 3;
            this.returnToMain.TabStop = false;
            this.returnToMain.Click += new System.EventHandler(this.returnToMain_Click);
            // 
            // Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(206)))), ((int)(((byte)(150)))));
            this.ClientSize = new System.Drawing.Size(1140, 641);
            this.Controls.Add(this.returnToMain);
            this.Controls.Add(this.history);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.profileLoginLable);
            this.Name = "Profile";
            this.Text = "Form4";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.returnToMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label profileLoginLable;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RichTextBox history;
        private System.Windows.Forms.PictureBox returnToMain;
    }
}