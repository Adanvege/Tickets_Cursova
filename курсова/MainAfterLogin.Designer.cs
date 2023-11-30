namespace курсова
{
    partial class MainAfterLogin
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
            this.components = new System.ComponentModel.Container();
            this.goToProfile = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.popular = new System.Windows.Forms.PictureBox();
            this.imagesChange = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popular)).BeginInit();
            this.SuspendLayout();
            // 
            // goToProfile
            // 
            this.goToProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(119)))), ((int)(((byte)(119)))));
            this.goToProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.goToProfile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(218)))));
            this.goToProfile.Location = new System.Drawing.Point(939, 507);
            this.goToProfile.Name = "goToProfile";
            this.goToProfile.Size = new System.Drawing.Size(156, 64);
            this.goToProfile.TabIndex = 19;
            this.goToProfile.Text = "Профіль";
            this.goToProfile.UseVisualStyleBackColor = false;
            this.goToProfile.Click += new System.EventHandler(this.goToProfile_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::курсова.Properties.Resources.logo_removebg_preview3;
            this.pictureBox1.Location = new System.Drawing.Point(950, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(145, 145);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // popular
            // 
            this.popular.Image = global::курсова.Properties.Resources.img1;
            this.popular.Location = new System.Drawing.Point(354, 29);
            this.popular.Name = "popular";
            this.popular.Size = new System.Drawing.Size(542, 542);
            this.popular.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.popular.TabIndex = 16;
            this.popular.TabStop = false;
            // 
            // imagesChange
            // 
            this.imagesChange.Interval = 10000;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(119)))), ((int)(((byte)(119)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(218)))));
            this.button1.Location = new System.Drawing.Point(27, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(287, 542);
            this.button1.TabIndex = 20;
            this.button1.Text = "Знайти подію";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainAfterLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(206)))), ((int)(((byte)(150)))));
            this.ClientSize = new System.Drawing.Size(1107, 608);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.goToProfile);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.popular);
            this.Name = "MainAfterLogin";
            this.Text = "MainAfterLogin";
            this.Load += new System.EventHandler(this.MainAfterLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popular)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button goToProfile;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox popular;
        private System.Windows.Forms.Timer imagesChange;
        private System.Windows.Forms.Button button1;
    }
}