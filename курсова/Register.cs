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
using курсова;

namespace курсова
{
    public partial class Register : Form
    {
        
        public Register()
        {
            InitializeComponent();
            passwordRegisterBox.UseSystemPasswordChar = true;
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
            try
            {
                int CountOfDigit = 0, CountOfSpecSymbols = 0;
                for (int i = 0; i < passwordRegisterBox.Text.Length; i++)
                {
                    if (char.IsDigit(passwordRegisterBox.Text[i]))
                    {
                        CountOfDigit++;
                    }
                    else if (char.IsPunctuation(passwordRegisterBox.Text[i]) 
                        || char.IsUpper(passwordRegisterBox.Text[i]))
                    {
                        CountOfSpecSymbols++;
                    }
                }

                if (CountOfDigit == 0 || CountOfSpecSymbols == 0 || passwordRegisterBox.Text.Length < 10)
                {
                    throw new SecureException();
                }
            }
            catch(SecureException Except)
            {
                MessageBox.Show(Except.Message + "\nMake sure it's at least 15 characters " +
                    "OR at least 10 characters including a number, spec symbols and a Upercase letter.");
                return;
            }
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

                        Form1 mainForm = new Form1();
                        mainForm.Show();
                        this.Hide();
                        
                    }
                    else
                    {
                        throw new ErrorData();
                        //MessageBox.Show("Register Fail");
                    }

                }

            }          
            catch (ErrorData Except)
            {
                MessageBox.Show($"ErrorData: {Except.Message}");
            }           
            catch(Exception ex)
            {
                MessageBox.Show($"General exception: {ex.Message}");
            }
            finally
            {
                conn.Close();
            }

        }

        private void passwordRegisterBox_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void showPassword_CheckedChanged(object sender, EventArgs e)
        {
            if(showPassword.Checked)
            {
                passwordRegisterBox.UseSystemPasswordChar = false;
            }
            else
            {
                passwordRegisterBox.UseSystemPasswordChar = true;
            }
        }
    }
}
