namespace курсова
{
    partial class mainForm
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
            this.concert = new System.Windows.Forms.Button();
            this.circus = new System.Windows.Forms.Button();
            this.movie = new System.Windows.Forms.Button();
            this.standUp = new System.Windows.Forms.Button();
            this.theatre = new System.Windows.Forms.Button();
            this.convention = new System.Windows.Forms.Button();
            this.popular = new System.Windows.Forms.PictureBox();
            this.imagesChange = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.popular)).BeginInit();
            this.SuspendLayout();
            // 
            // concert
            // 
            this.concert.Location = new System.Drawing.Point(29, 29);
            this.concert.Name = "concert";
            this.concert.Size = new System.Drawing.Size(195, 64);
            this.concert.TabIndex = 0;
            this.concert.Text = "Концерт";
            this.concert.UseVisualStyleBackColor = true;
            this.concert.Click += new System.EventHandler(this.concert_Click);
            // 
            // circus
            // 
            this.circus.Location = new System.Drawing.Point(29, 122);
            this.circus.Name = "circus";
            this.circus.Size = new System.Drawing.Size(195, 64);
            this.circus.TabIndex = 1;
            this.circus.Text = "Цирк";
            this.circus.UseVisualStyleBackColor = true;
            this.circus.Click += new System.EventHandler(this.circus_Click);
            // 
            // movie
            // 
            this.movie.Location = new System.Drawing.Point(29, 220);
            this.movie.Name = "movie";
            this.movie.Size = new System.Drawing.Size(195, 64);
            this.movie.TabIndex = 2;
            this.movie.Text = "Кіно";
            this.movie.UseVisualStyleBackColor = true;
            this.movie.Click += new System.EventHandler(this.movie_Click);
            // 
            // standUp
            // 
            this.standUp.Location = new System.Drawing.Point(29, 507);
            this.standUp.Name = "standUp";
            this.standUp.Size = new System.Drawing.Size(195, 64);
            this.standUp.TabIndex = 5;
            this.standUp.Text = "Стендап";
            this.standUp.UseVisualStyleBackColor = true;
            this.standUp.Click += new System.EventHandler(this.standUp_Click);
            // 
            // theatre
            // 
            this.theatre.Location = new System.Drawing.Point(29, 409);
            this.theatre.Name = "theatre";
            this.theatre.Size = new System.Drawing.Size(195, 64);
            this.theatre.TabIndex = 4;
            this.theatre.Text = "Театр";
            this.theatre.UseVisualStyleBackColor = true;
            this.theatre.Click += new System.EventHandler(this.theatre_Click);
            // 
            // convention
            // 
            this.convention.Location = new System.Drawing.Point(29, 316);
            this.convention.Name = "convention";
            this.convention.Size = new System.Drawing.Size(195, 64);
            this.convention.TabIndex = 3;
            this.convention.Text = "Конвенція";
            this.convention.UseVisualStyleBackColor = true;
            this.convention.Click += new System.EventHandler(this.convention_Click);
            // 
            // popular
            // 
            this.popular.Location = new System.Drawing.Point(326, 29);
            this.popular.Name = "popular";
            this.popular.Size = new System.Drawing.Size(824, 542);
            this.popular.TabIndex = 6;
            this.popular.TabStop = false;
            this.popular.Click += new System.EventHandler(this.popular_Click);
            // 
            // imagesChange
            // 
            this.imagesChange.Tick += new System.EventHandler(this.imagesChange_Tick);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1191, 608);
            this.Controls.Add(this.popular);
            this.Controls.Add(this.standUp);
            this.Controls.Add(this.theatre);
            this.Controls.Add(this.convention);
            this.Controls.Add(this.movie);
            this.Controls.Add(this.circus);
            this.Controls.Add(this.concert);
            this.Name = "mainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.mainForm_Load);
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
    }
}

