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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace курсова
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=NOTIK\SQLEXPRESS;Initial Catalog=LoginCursova;Integrated Security=True");

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void returnToMain_Click(object sender, EventArgs e)
        {
            Form1 mainForm = new Form1();

            this.Hide();
            mainForm.Show();
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            String loginRegister, passwordRegister;

            loginRegister=loginRegisterBox.Text;
            passwordRegister=passwordRegisterBox.Text;

            try
            {
                string query = "INSERT INTO Login_new (username, password) VALUES(@username, @password)";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {

                    cmd.Parameters.AddWithValue("@username", loginRegister);
                    cmd.Parameters.AddWithValue("@password", passwordRegister);

                    conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    

                    if(rowsAffected>0)
                    {
                        MessageBox.Show("Register Success");

                        MainAfterLogin mainForm = new MainAfterLogin();
                        mainForm.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Register Fail");
                    }

                }

            }
            catch
            {
                MessageBox.Show("Error");
            }
            finally
            {
                conn.Close();
            }

        }
    }
}
