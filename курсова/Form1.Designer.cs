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
            this.circus = new System.Windows.Forms.Button();
            this.movie = new System.Windows.Forms.Button();
            this.standUp = new System.Windows.Forms.Button();
            this.theatre = new System.Windows.Forms.Button();
            this.convention = new System.Windows.Forms.Button();
            this.imagesChange = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.popular = new System.Windows.Forms.PictureBox();
            this.mainLoginButton = new System.Windows.Forms.Button();
            this.goToProfile = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popular)).BeginInit();
            this.SuspendLayout();
            // 
            // concert
            // 
            this.concert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(119)))), ((int)(((byte)(119)))));
            this.concert.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.concert.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(218)))));
            this.concert.Location = new System.Drawing.Point(64, 29);
            this.concert.Name = "concert";
            this.concert.Size = new System.Drawing.Size(195, 64);
            this.concert.TabIndex = 0;
            this.concert.Text = "Концерт";
            this.concert.UseVisualStyleBackColor = false;
            this.concert.Click += new System.EventHandler(this.concert_Click);
            // 
            // circus
            // 
            this.circus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(119)))), ((int)(((byte)(119)))));
            this.circus.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.circus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(218)))));
            this.circus.Location = new System.Drawing.Point(64, 122);
            this.circus.Name = "circus";
            this.circus.Size = new System.Drawing.Size(195, 64);
            this.circus.TabIndex = 1;
            this.circus.Text = "Цирк";
            this.circus.UseVisualStyleBackColor = false;
            this.circus.Click += new System.EventHandler(this.circus_Click);
            // 
            // movie
            // 
            this.movie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(119)))), ((int)(((byte)(119)))));
            this.movie.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.movie.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(218)))));
            this.movie.Location = new System.Drawing.Point(64, 220);
            this.movie.Name = "movie";
            this.movie.Size = new System.Drawing.Size(195, 64);
            this.movie.TabIndex = 2;
            this.movie.Text = "Кіно";
            this.movie.UseVisualStyleBackColor = false;
            this.movie.Click += new System.EventHandler(this.movie_Click);
            // 
            // standUp
            // 
            this.standUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(119)))), ((int)(((byte)(119)))));
            this.standUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.standUp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(218)))));
            this.standUp.Location = new System.Drawing.Point(64, 507);
            this.standUp.Name = "standUp";
            this.standUp.Size = new System.Drawing.Size(195, 64);
            this.standUp.TabIndex = 5;
            this.standUp.Text = "Стендап";
            this.standUp.UseVisualStyleBackColor = false;
            this.standUp.Click += new System.EventHandler(this.standUp_Click);
            // 
            // theatre
            // 
            this.theatre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(119)))), ((int)(((byte)(119)))));
            this.theatre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.theatre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(218)))));
            this.theatre.Location = new System.Drawing.Point(64, 409);
            this.theatre.Name = "theatre";
            this.theatre.Size = new System.Drawing.Size(195, 64);
            this.theatre.TabIndex = 4;
            this.theatre.Text = "Театр";
            this.theatre.UseVisualStyleBackColor = false;
            this.theatre.Click += new System.EventHandler(this.theatre_Click);
            // 
            // convention
            // 
            this.convention.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(119)))), ((int)(((byte)(119)))));
            this.convention.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.convention.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(218)))));
            this.convention.Location = new System.Drawing.Point(64, 316);
            this.convention.Name = "convention";
            this.convention.Size = new System.Drawing.Size(195, 64);
            this.convention.TabIndex = 3;
            this.convention.Text = "Конвенція";
            this.convention.UseVisualStyleBackColor = false;
            this.convention.Click += new System.EventHandler(this.convention_Click);
            // 
            // imagesChange
            // 
            this.imagesChange.Interval = 10000;
            this.imagesChange.Tick += new System.EventHandler(this.imagesChange_Tick);
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
            // mainLoginButton
            // 
            this.mainLoginButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(119)))), ((int)(((byte)(119)))));
            this.mainLoginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mainLoginButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(218)))));
            this.mainLoginButton.Location = new System.Drawing.Point(939, 437);
            this.mainLoginButton.Name = "mainLoginButton";
            this.mainLoginButton.Size = new System.Drawing.Size(156, 64);
            this.mainLoginButton.TabIndex = 8;
            this.mainLoginButton.Text = "Вхід";
            this.mainLoginButton.UseVisualStyleBackColor = false;
            this.mainLoginButton.Click += new System.EventHandler(this.mainLoginButton_Click);
            // 
            // goToProfile
            // 
            this.goToProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(119)))), ((int)(((byte)(119)))));
            this.goToProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.goToProfile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(218)))));
            this.goToProfile.Location = new System.Drawing.Point(939, 507);
            this.goToProfile.Name = "goToProfile";
            this.goToProfile.Size = new System.Drawing.Size(156, 64);
            this.goToProfile.TabIndex = 9;
            this.goToProfile.Text = "Профіль";
            this.goToProfile.UseVisualStyleBackColor = false;
            this.goToProfile.Click += new System.EventHandler(this.goToProfile_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(206)))), ((int)(((byte)(150)))));
            this.ClientSize = new System.Drawing.Size(1107, 608);
            this.Controls.Add(this.goToProfile);
            this.Controls.Add(this.mainLoginButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.popular);
            this.Controls.Add(this.standUp);
            this.Controls.Add(this.theatre);
            this.Controls.Add(this.convention);
            this.Controls.Add(this.movie);
            this.Controls.Add(this.circus);
            this.Controls.Add(this.concert);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Головна";
            this.Load += new System.EventHandler(this.mainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popular)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button concert;
        private System.Windows.Forms.Button circus;
        private System.Windows.Forms.Button movie;
        private System.Windows.Forms.Button standUp;
        private System.Windows.Forms.Button theatre;
        private System.Windows.Forms.Button convention;
        private System.Windows.Forms.PictureBox popular;
        private System.Windows.Forms.Timer imagesChange;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button mainLoginButton;
        private System.Windows.Forms.Button goToProfile;
    }
}

