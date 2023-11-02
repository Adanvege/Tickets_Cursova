namespace курсова
{
    partial class secondForm
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
            this.nameOf = new System.Windows.Forms.TextBox();
            this.date = new System.Windows.Forms.TextBox();
            this.city = new System.Windows.Forms.TextBox();
            this.result = new System.Windows.Forms.RichTextBox();
            this.back = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.back)).BeginInit();
            this.SuspendLayout();
            // 
            // nameOf
            // 
            this.nameOf.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameOf.Location = new System.Drawing.Point(13, 13);
            this.nameOf.Name = "nameOf";
            this.nameOf.Size = new System.Drawing.Size(215, 35);
            this.nameOf.TabIndex = 0;
            this.nameOf.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nameOf.TextChanged += new System.EventHandler(this.nameOf_TextChanged);
            // 
            // date
            // 
            this.date.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date.Location = new System.Drawing.Point(13, 79);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(215, 35);
            this.date.TabIndex = 1;
            this.date.Text = "Дата...";
            this.date.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // city
            // 
            this.city.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.city.Location = new System.Drawing.Point(13, 148);
            this.city.Name = "city";
            this.city.Size = new System.Drawing.Size(215, 35);
            this.city.TabIndex = 2;
            this.city.Text = "Місто...";
            this.city.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // result
            // 
            this.result.Location = new System.Drawing.Point(277, 13);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(542, 170);
            this.result.TabIndex = 3;
            this.result.Text = "";
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(13, 190);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(46, 46);
            this.back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.back.TabIndex = 4;
            this.back.TabStop = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // secondForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 239);
            this.Controls.Add(this.back);
            this.Controls.Add(this.result);
            this.Controls.Add(this.city);
            this.Controls.Add(this.date);
            this.Controls.Add(this.nameOf);
            this.Name = "secondForm";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.secondForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.back)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameOf;
        private System.Windows.Forms.TextBox date;
        private System.Windows.Forms.TextBox city;
        private System.Windows.Forms.RichTextBox result;
        private System.Windows.Forms.PictureBox back;
    }
}