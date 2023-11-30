using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace курсова
{
    public partial class MainAfterLogin : Form
    {
        private int currentImageIndex = 0;
        private string[] imagePaths = Directory.GetFiles("C:\\Users\\Влад Бган\\source\\repos\\Cursova\\курсова\\imagesGallery");


        public MainAfterLogin()
        {
            InitializeComponent();
            imagesChange.Start();
            
        }


        private void mainForm_Load(object sender, EventArgs e)
        {
            imagesChange.Start();
        }


        private void popular_Click(object sender, EventArgs e)
        {

        }

        private void imagesChange_Tick(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void goToProfile_Click_1(object sender, EventArgs e)
        {
            loginForm login = new loginForm();
            string logine = login.GetLoginBox();
            //profileLoginLable.Text = logine;
            Profile Profile = new Profile();
            Profile.UserLogin= logine;
            this.Hide();
            Profile.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void MainAfterLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
