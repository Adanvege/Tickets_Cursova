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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(secondForm));
            this.nameOf = new System.Windows.Forms.TextBox();
            this.result = new System.Windows.Forms.RichTextBox();
            this.back = new System.Windows.Forms.PictureBox();
            this.FindButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.showTypeBox = new System.Windows.Forms.ComboBox();
            this.showTownBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.back)).BeginInit();
            this.SuspendLayout();
            // 
            // nameOf
            // 
            this.nameOf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(42)))), ((int)(((byte)(82)))));
            this.nameOf.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameOf.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(230)))), ((int)(((byte)(170)))));
            this.nameOf.Location = new System.Drawing.Point(13, 32);
            this.nameOf.Name = "nameOf";
            this.nameOf.Size = new System.Drawing.Size(215, 35);
            this.nameOf.TabIndex = 0;
            this.nameOf.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nameOf.TextChanged += new System.EventHandler(this.nameOf_TextChanged);
            this.nameOf.MouseDown += new System.Windows.Forms.MouseEventHandler(this.nameOf_MouseDown);
            // 
            // result
            // 
            this.result.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(42)))), ((int)(((byte)(82)))));
            this.result.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.result.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(218)))));
            this.result.Location = new System.Drawing.Point(277, 13);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(885, 170);
            this.result.TabIndex = 3;
            this.result.Text = "";
            this.result.TextChanged += new System.EventHandler(this.result_TextChanged);
            // 
            // back
            // 
            this.back.Image = global::курсова.Properties.Resources.return_104;
            this.back.Location = new System.Drawing.Point(13, 190);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(46, 46);
            this.back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.back.TabIndex = 4;
            this.back.TabStop = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // FindButton
            // 
            this.FindButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(66)))), ((int)(((byte)(107)))));
            this.FindButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FindButton.ForeColor = System.Drawing.Color.Ivory;
            this.FindButton.Location = new System.Drawing.Point(113, 190);
            this.FindButton.Name = "FindButton";
            this.FindButton.Size = new System.Drawing.Size(115, 46);
            this.FindButton.TabIndex = 5;
            this.FindButton.Text = "Пошук";
            this.FindButton.UseVisualStyleBackColor = false;
            this.FindButton.Click += new System.EventHandler(this.FindButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(66)))), ((int)(((byte)(107)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Ivory;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Назва";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(66)))), ((int)(((byte)(107)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Ivory;
            this.label2.Location = new System.Drawing.Point(13, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "Тип шоу";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(66)))), ((int)(((byte)(107)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Ivory;
            this.label3.Location = new System.Drawing.Point(13, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "Місто";
            // 
            // showTypeBox
            // 
            this.showTypeBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(42)))), ((int)(((byte)(82)))));
            this.showTypeBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.showTypeBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(230)))), ((int)(((byte)(170)))));
            this.showTypeBox.FormattingEnabled = true;
            this.showTypeBox.Items.AddRange(new object[] {
            "Стендап",
            "Концерт"});
            this.showTypeBox.Location = new System.Drawing.Point(16, 87);
            this.showTypeBox.Name = "showTypeBox";
            this.showTypeBox.Size = new System.Drawing.Size(212, 37);
            this.showTypeBox.TabIndex = 9;
            this.showTypeBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.showTypeBox_MouseDown);
            // 
            // showTownBox
            // 
            this.showTownBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(42)))), ((int)(((byte)(82)))));
            this.showTownBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.showTownBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(230)))), ((int)(((byte)(170)))));
            this.showTownBox.FormattingEnabled = true;
            this.showTownBox.Items.AddRange(new object[] {
            "Запоріжжя"});
            this.showTownBox.Location = new System.Drawing.Point(16, 146);
            this.showTownBox.Name = "showTownBox";
            this.showTownBox.Size = new System.Drawing.Size(212, 37);
            this.showTownBox.TabIndex = 10;
            this.showTownBox.SelectedIndexChanged += new System.EventHandler(this.showTownBox_SelectedIndexChanged);
            // 
            // secondForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(66)))), ((int)(((byte)(107)))));
            this.ClientSize = new System.Drawing.Size(1174, 239);
            this.Controls.Add(this.showTownBox);
            this.Controls.Add(this.showTypeBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FindButton);
            this.Controls.Add(this.back);
            this.Controls.Add(this.result);
            this.Controls.Add(this.nameOf);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "secondForm";
            this.Load += new System.EventHandler(this.secondForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.back)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameOf;
        private System.Windows.Forms.RichTextBox result;
        private System.Windows.Forms.PictureBox back;
        private System.Windows.Forms.Button FindButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox showTypeBox;
        private System.Windows.Forms.ComboBox showTownBox;
    }
}