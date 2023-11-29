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
    

    public partial class secondForm : Form
    {
        public secondForm()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=NOTIK\SQLEXPRESS;Initial Catalog=LoginCursova;Integrated Security=True");
        public void setTextBoxText(string text)
        {
            nameOf.Text = text;
        }

        private void nameOf_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void secondForm_Load(object sender, EventArgs e)
        {
            //back.Image = Image.FromFile("back.png");
        }

        private void back_Click(object sender, EventArgs e)
        {
            Form1 mainForm = new Form1();

            this.Hide();
            mainForm.Show();
        }

        private void date_TextChanged(object sender, EventArgs e)
        {

        }

        private void nameOf_MouseDown(object sender, MouseEventArgs e)
        {
            nameOf.Text = "";
        }

        private void city_MouseDown(object sender, MouseEventArgs e)
        {
            city.Text = "";
        }

        private void date_MouseDown(object sender, MouseEventArgs e)
        {
            date.Text = "";
        }

        private void FindButton_Click(object sender, EventArgs e)
        {
            if (nameOf.Text != "")
            {
                String NameOfShow;
                NameOfShow = nameOf.Text;
                try
                {
                    String querry = "SELECT * FROM Shows_Info WHERE showName = '" + nameOf.Text + "'";
                    SqlDataAdapter sda = new SqlDataAdapter(querry, conn);

                    DataTable dtable = new DataTable();
                    sda.Fill(dtable);

                    if (dtable.Rows.Count > 0)
                    {
                        StringBuilder sb = new StringBuilder();

                        foreach (DataRow row in dtable.Rows)
                        {
                            string showName = row["showName"].ToString();
                            string showType = row["showType"].ToString();
                            string showCost = row["showCost"].ToString();
                            string showTown = row["showTown"].ToString();
                            string showLink = row["buyLink"].ToString();
                            sb.AppendLine("Назва: " + showName + " " + "Тип: " + showType + " " + "Ціна: " + showCost + " " + "Місто: " + showTown + " " + "Придбати: " + showLink);
                        }

                        result.Text = sb.ToString();
                    }

                }
                catch
                {

                }
                finally
                {
                    conn.Close();
                }
            }

            if (date.Text != "")
            {
                String ShowType;
                ShowType = date.Text;
                try
                {
                    String querry = "SELECT * FROM Shows_Info WHERE showType = '" + date.Text + "'";
                    SqlDataAdapter sda = new SqlDataAdapter(querry, conn);

                    DataTable dtable = new DataTable();
                    sda.Fill(dtable);

                    if (dtable.Rows.Count > 0)
                    {
                        StringBuilder sb = new StringBuilder();

                        foreach (DataRow row in dtable.Rows)
                        {
                            string showName = row["showName"].ToString();
                            string showType = row["showType"].ToString();
                            string showCost = row["showCost"].ToString();
                            string showTown = row["showTown"].ToString();
                            string showLink = row["buyLink"].ToString();
                            sb.AppendLine("Назва: " + showName + " " + "Тип: " + showType + " " + "Ціна: " + showCost + " " + "Місто: " + showTown + " " + "Придбати: " + showLink);
                        }

                        result.Text = sb.ToString();
                    }

                }
                catch
                {

                }
                finally
                {
                    conn.Close();
                }
            }

            if (city.Text != "")
            {
                String ShowCity;
                ShowCity = city.Text;
                try
                {
                    String querry = "SELECT * FROM Shows_Info WHERE showTown = '" + city.Text + "'";
                    SqlDataAdapter sda = new SqlDataAdapter(querry, conn);

                    DataTable dtable = new DataTable();
                    sda.Fill(dtable);

                    if (dtable.Rows.Count > 0)
                    {
                        StringBuilder sb = new StringBuilder();

                        foreach (DataRow row in dtable.Rows)
                        {
                            string showName = row["showName"].ToString();
                            string showType = row["showType"].ToString();
                            string showCost = row["showCost"].ToString();
                            string showTown = row["showTown"].ToString();
                            string showLink = row["buyLink"].ToString();
                            sb.AppendLine("Назва: " + showName+" " + "Тип: " + showType + " " + "Ціна: " + showCost + " " + "Місто: " + showTown + " " + "Придбати: " + showLink);
                        }

                        result.Text=sb.ToString();
                    }

                }
                catch
                {

                }
                finally
                {
                    conn.Close();
                }
            }

        }

        private void result_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
