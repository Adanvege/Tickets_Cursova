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
            this.arrowLeft = new System.Windows.Forms.PictureBox();
            this.arrowRight = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.popular = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.arrowLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arrowRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popular)).BeginInit();
            this.SuspendLayout();
            // 
            // concert
            // 
            this.concert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(42)))), ((int)(((byte)(82)))));
            this.concert.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.concert.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(230)))), ((int)(((byte)(170)))));
            this.concert.Location = new System.Drawing.Point(27, 29);
            this.concert.Name = "concert";
            this.concert.Size = new System.Drawing.Size(287, 542);
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
            this.mainLoginButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(42)))), ((int)(((byte)(82)))));
            this.mainLoginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mainLoginButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(230)))), ((int)(((byte)(170)))));
            this.mainLoginButton.Location = new System.Drawing.Point(939, 507);
            this.mainLoginButton.Name = "mainLoginButton";
            this.mainLoginButton.Size = new System.Drawing.Size(156, 64);
            this.mainLoginButton.TabIndex = 8;
            this.mainLoginButton.Text = "Вхід";
            this.mainLoginButton.UseVisualStyleBackColor = false;
            this.mainLoginButton.Click += new System.EventHandler(this.mainLoginButton_Click);
            // 
            // arrowLeft
            // 
            this.arrowLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(42)))), ((int)(((byte)(82)))));
            this.arrowLeft.Image = global::курсова.Properties.Resources.arrow;
            this.arrowLeft.Location = new System.Drawing.Point(821, 570);
            this.arrowLeft.Name = "arrowLeft";
            this.arrowLeft.Size = new System.Drawing.Size(35, 38);
            this.arrowLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.arrowLeft.TabIndex = 10;
            this.arrowLeft.TabStop = false;
            // 
            // arrowRight
            // 
            this.arrowRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(42)))), ((int)(((byte)(82)))));
            this.arrowRight.Image = global::курсова.Properties.Resources._556_arrowright_removebg_preview;
            this.arrowRight.Location = new System.Drawing.Point(862, 570);
            this.arrowRight.Name = "arrowRight";
            this.arrowRight.Size = new System.Drawing.Size(35, 38);
            this.arrowRight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.arrowRight.TabIndex = 9;
            this.arrowRight.TabStop = false;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(66)))), ((int)(((byte)(107)))));
            this.ClientSize = new System.Drawing.Size(1107, 608);
            this.Controls.Add(this.arrowLeft);
            this.Controls.Add(this.arrowRight);
            this.Controls.Add(this.mainLoginButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.popular);
            this.Controls.Add(this.concert);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.mainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.arrowLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arrowRight)).EndInit();
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
        private System.Windows.Forms.PictureBox arrowRight;
        private System.Windows.Forms.PictureBox arrowLeft;
    }
}

