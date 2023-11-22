using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace курсова
{
    public partial class mainForm : Form
    {
        private int currentImageIndex = 0;
        private string[] imagePaths = Directory.GetFiles("C:\\Users\\Влад Бган\\source\\repos\\Cursova\\курсова\\imagesGallery");

        public mainForm()
        {
            InitializeComponent();
            imagesChange.Start();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            imagesChange.Start();
            concert.FlatAppearance.BorderSize = 1;
        }

        private void concert_Click(object sender, EventArgs e)
        {
            secondForm secondForm= new secondForm();
            secondForm.setTextBoxText("Назва гурту...");

            this.Hide();
            secondForm.Show();
        }

        private void circus_Click(object sender, EventArgs e)
        {
            secondForm secondForm = new secondForm();

            secondForm.setTextBoxText("Назва гурту...");

            this.Hide();

            secondForm.Show();
        }

        private void movie_Click(object sender, EventArgs e)
        {
            secondForm secondForm = new secondForm();

            secondForm.setTextBoxText("Назва...");

            this.Hide();

            secondForm.Show();
        }

        private void convention_Click(object sender, EventArgs e)
        {
            secondForm secondForm = new secondForm();

            secondForm.setTextBoxText("Назва...");

            this.Hide();

            secondForm.Show();

        }

        private void theatre_Click(object sender, EventArgs e)
        {
            secondForm secondForm = new secondForm();

            secondForm.setTextBoxText("Назва гурту...");

            this.Hide();

            secondForm.Show();
        }

        private void standUp_Click(object sender, EventArgs e)
        {
            secondForm secondForm = new secondForm();

            secondForm.setTextBoxText("Назва гурту...");

            this.Hide();

            secondForm.Show();
        }

        private void popular_Click(object sender, EventArgs e)
        {
            
        }

        private void imagesChange_Tick(object sender, EventArgs e)
        {
            if (currentImageIndex < imagePaths.Length)
            {
                popular.Image = Image.FromFile(imagePaths[currentImageIndex]);
                currentImageIndex++;
            }
            else
            {
                currentImageIndex = 0;
            }
        }
    }
}
