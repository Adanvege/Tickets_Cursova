namespace курсова
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.concert = new System.Windows.Forms.Button();
            this.imagesChange = new System.Windows.Forms.Timer(this.components);
            this.mainLoginButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.popular = new System.Windows.Forms.PictureBox();
            this.startTimer = new System.Windows.Forms.Timer(this.components);
            this.imageLeft = new System.Windows.Forms.Button();
            this.imageRight = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popular)).BeginInit();
            this.SuspendLayout();
            // 
            // concert
            // 
            this.concert.BackColor = System.Drawing.Color.White;
            this.concert.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.concert.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(66)))), ((int)(((byte)(107)))));
            this.concert.Location = new System.Drawing.Point(27, 507);
            this.concert.Name = "concert";
            this.concert.Size = new System.Drawing.Size(287, 64);
            this.concert.TabIndex = 0;
            this.concert.Text = "Знайти подію";
            this.concert.UseVisualStyleBackColor = false;
            this.concert.Click += new System.EventHandler(this.concert_Click);
            // 
            // imagesChange
            // 
            this.imagesChange.Interval = 10000;
            this.imagesChange.Tick += new System.EventHandler(this.imagesChange_Tick);
            // 
            // mainLoginButton
            // 
            this.mainLoginButton.BackColor = System.Drawing.Color.Ivory;
            this.mainLoginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mainLoginButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(66)))), ((int)(((byte)(107)))));
            this.mainLoginButton.Location = new System.Drawing.Point(939, 507);
            this.mainLoginButton.Name = "mainLoginButton";
            this.mainLoginButton.Size = new System.Drawing.Size(156, 64);
            this.mainLoginButton.TabIndex = 8;
            this.mainLoginButton.Text = "Вхід";
            this.mainLoginButton.UseVisualStyleBackColor = false;
            this.mainLoginButton.Click += new System.EventHandler(this.mainLoginButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::курсова.Properties.Resources.logo_removebg_preview3;
            this.pictureBox1.Location = new System.Drawing.Point(950, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(145, 145);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // popular
            // 
            this.popular.Image = global::курсова.Properties.Resources.img1;
            this.popular.Location = new System.Drawing.Point(354, 29);
            this.popular.Name = "popular";
            this.popular.Size = new System.Drawing.Size(542, 542);
            this.popular.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.popular.TabIndex = 6;
            this.popular.TabStop = false;
            this.popular.Click += new System.EventHandler(this.popular_Click);
            // 
            // startTimer
            // 
            this.startTimer.Tick += new System.EventHandler(this.StartTimer_Tick);
            // 
            // imageLeft
            // 
            this.imageLeft.BackgroundImage = global::курсова.Properties.Resources.arrow;
            this.imageLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imageLeft.Location = new System.Drawing.Point(354, 571);
            this.imageLeft.Name = "imageLeft";
            this.imageLeft.Size = new System.Drawing.Size(38, 35);
            this.imageLeft.TabIndex = 9;
            this.imageLeft.UseVisualStyleBackColor = false;
            this.imageLeft.Click += new System.EventHandler(this.imageLeft_Click);
            // 
            // imageRight
            // 
            this.imageRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(66)))), ((int)(((byte)(107)))));
            this.imageRight.BackgroundImage = global::курсова.Properties.Resources._556_arrowright_removebg_preview;
            this.imageRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imageRight.Location = new System.Drawing.Point(858, 571);
            this.imageRight.Name = "imageRight";
            this.imageRight.Size = new System.Drawing.Size(38, 35);
            this.imageRight.TabIndex = 10;
            this.imageRight.UseVisualStyleBackColor = false;
            this.imageRight.Click += new System.EventHandler(this.imageRight_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(50)))), ((int)(((byte)(107)))));
            this.ClientSize = new System.Drawing.Size(1107, 608);
            this.Controls.Add(this.imageRight);
            this.Controls.Add(this.imageLeft);
            this.Controls.Add(this.mainLoginButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.popular);
            this.Controls.Add(this.concert);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.mainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popular)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button concert;
        private System.Windows.Forms.PictureBox popular;
        private System.Windows.Forms.Timer imagesChange;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button mainLoginButton;
        private System.Windows.Forms.Timer startTimer;
        private System.Windows.Forms.Button imageLeft;
        private System.Windows.Forms.Button imageRight;
    }
}

