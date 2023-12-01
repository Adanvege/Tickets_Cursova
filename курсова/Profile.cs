using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace курсова
{
    public partial class Profile : Form
    {
        
        public Profile()
        {
            InitializeComponent();
           
        }
        private void returnToMain_Click(object sender, EventArgs e)
        {
            Form1 mainForm = new Form1();

            this.Hide();
            mainForm.Show();
        }

        private void Profile_Load(object sender, EventArgs e)
        {
            userLoginLable.Text = loginForm.SetLoginValue;
        }

        
    }
}
