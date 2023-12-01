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
            this.imagesChange = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.popular = new System.Windows.Forms.PictureBox();
            this.imageRight = new System.Windows.Forms.Button();
            this.imageLeft = new System.Windows.Forms.Button();
            this.startTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popular)).BeginInit();
            this.SuspendLayout();
            // 
            // goToProfile
            // 
            this.goToProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(42)))), ((int)(((byte)(82)))));
            this.goToProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.goToProfile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(230)))), ((int)(((byte)(170)))));
            this.goToProfile.Location = new System.Drawing.Point(939, 507);
            this.goToProfile.Name = "goToProfile";
            this.goToProfile.Size = new System.Drawing.Size(156, 64);
            this.goToProfile.TabIndex = 19;
            this.goToProfile.Text = "Профіль";
            this.goToProfile.UseVisualStyleBackColor = false;
            this.goToProfile.Click += new System.EventHandler(this.goToProfile_Click_1);
            // 
            // imagesChange
            // 
            this.imagesChange.Interval = 10000;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(42)))), ((int)(((byte)(82)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(230)))), ((int)(((byte)(170)))));
            this.button1.Location = new System.Drawing.Point(27, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(287, 542);
            this.button1.TabIndex = 20;
            this.button1.Text = "Знайти подію";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            // imageRight
            // 
            this.imageRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(66)))), ((int)(((byte)(107)))));
            this.imageRight.BackgroundImage = global::курсова.Properties.Resources._556_arrowright_removebg_preview;
            this.imageRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imageRight.Location = new System.Drawing.Point(855, 571);
            this.imageRight.Name = "imageRight";
            this.imageRight.Size = new System.Drawing.Size(38, 35);
            this.imageRight.TabIndex = 22;
            this.imageRight.UseVisualStyleBackColor = false;
            this.imageRight.Click += new System.EventHandler(this.imageRight_Click);
            // 
            // imageLeft
            // 
            this.imageLeft.BackgroundImage = global::курсова.Properties.Resources.arrow;
            this.imageLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imageLeft.Location = new System.Drawing.Point(811, 571);
            this.imageLeft.Name = "imageLeft";
            this.imageLeft.Size = new System.Drawing.Size(38, 35);
            this.imageLeft.TabIndex = 21;
            this.imageLeft.UseVisualStyleBackColor = false;
            this.imageLeft.Click += new System.EventHandler(this.imageLeft_Click_1);
            // 
            // startTimer
            // 
            this.startTimer.Tick += new System.EventHandler(this.startTimer_Tick);
            // 
            // MainAfterLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(66)))), ((int)(((byte)(107)))));
            this.ClientSize = new System.Drawing.Size(1107, 608);
            this.Controls.Add(this.imageRight);
            this.Controls.Add(this.imageLeft);
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
        private System.Windows.Forms.Button imageRight;
        private System.Windows.Forms.Button imageLeft;
        private System.Windows.Forms.Timer startTimer;
    }
}