using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace курсова
{
    

    public partial class secondForm : Form
    {
        public secondForm()
        {
            InitializeComponent();
        }

        public void setTextBoxText(string text)
        {
            nameOf.Text = text;
        }

        private void nameOf_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void secondForm_Load(object sender, EventArgs e)
        {
            back.Image = Image.FromFile("back.png");
        }

        private void back_Click(object sender, EventArgs e)
        {

        }
    }
}
