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
    public partial class loginForm : Form
    {
        public static string SetLoginValue = "";
        public loginForm()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=NOTIK\SQLEXPRESS;Initial Catalog=LoginCursova;Integrated Security=True");

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void returnToMain_Click(object sender, EventArgs e)
        {
            Form1 mainForm = new Form1();

            this.Hide();
            mainForm.Show();
        }

        private void GoToRegisterForm_Click(object sender, EventArgs e)
        {
            Register register= new Register();
            this.Hide();
            register.Show();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            String username, user_password;

            username = loginBox.Text;
            user_password = passwordBox.Text;

            try
            {
                String querry = "SELECT * FROM Login_new WHERE username = '" + loginBox.Text + "' AND password = '" + passwordBox.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(querry, conn);

                DataTable dtable = new DataTable();
                sda.Fill(dtable);

                if(dtable.Rows.Count > 0)
                {
                    try
                    {
                        if (loginBox.Text != null && passwordBox.Text != null)
                        {
                            username = loginBox.Text;
                            user_password = passwordBox.Text;
                            SetLoginValue = username;
                        }
                        else
                        {
                            throw new ErrorAuthentication(); //For Expection)                            
                        }
                        //page that needed to be load next
                        MainAfterLogin mainForm = new MainAfterLogin();
                        mainForm.Show();
                        this.Hide();
                    }
                    catch(ErrorAuthentication EmptyData) 
                    {
                    MessageBox.Show($"Empty login or password: {EmptyData.Message}");
                    }
                }
                else
                {
                    //MessageBox.Show("Invalid data","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    
                    loginBox.Clear();
                    passwordBox.Clear();
                    loginBox.Focus();
                    throw new ErrorAuthentication();
                }

            }
            catch (ErrorAuthentication Except)
            {
                MessageBox.Show($"ErrorAuthentication: {Except.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"General exception: {ex.Message}");
            }
            finally
            {
                conn.Close();
            }
        }
        
        public string GetLoginBox()
        {
            return loginBox.Text;
        }
    }
}
