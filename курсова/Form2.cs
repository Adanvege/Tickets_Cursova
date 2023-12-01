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
using System.Security.Cryptography.X509Certificates;

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

        

        private void FindButton_Click(object sender, EventArgs e)
        {
            if (nameOf.Text != "")
            {
                String NameOfShow;
                NameOfShow = nameOf.Text;
                try
                {
                    String query = "SELECT * FROM Shows_Info WHERE showName LIKE '%" + nameOf.Text + "%'";
                    SqlDataAdapter sda = new SqlDataAdapter(query, conn);

                    DataTable dtable = new DataTable();
                    sda.Fill(dtable);

                    if (dtable.Rows.Count > 0)
                    {
                        // Преобразуем таблицу в список строк
                        List<string> showList = new List<string>();

                        foreach (DataRow row in dtable.Rows)
                        {

                            string showName = row["showName"].ToString();
                            string showType = row["showType"].ToString();
                            string showCost = row["showCost"].ToString();
                            string showTown = row["showTown"].ToString();
                            string showLink = row["buyLink"].ToString();
                            // Формируем строку для отображения
                            string showInfo = $"Назва: {showName} Тип: {showType} Ціна: {showCost} Місто: {showTown} Придбати: {showLink}";

                            // Добавляем в список
                            showList.Add(showInfo);


                        }

                        // Сортируем список по цене
                        for (int i = 0; i < showList.Count - 1; i++)
                        {
                            for (int j = i + 1; j < showList.Count; j++)
                            {
                                int costI = int.Parse(showList[i].Split(new[] { "Ціна: " }, StringSplitOptions.None)[1].Split(' ')[0]);
                                int costJ = int.Parse(showList[j].Split(new[] { "Ціна: " }, StringSplitOptions.None)[1].Split(' ')[0]);

                                if (costI > costJ)
                                {
                                    // Обмен элементов списка для сортировки
                                    string temp = showList[i];
                                    showList[i] = showList[j];
                                    showList[j] = temp;
                                }
                            }
                        }

                        // Формируем отсортированную строку и выводим в result
                        result.Text = string.Join(Environment.NewLine, showList);
                    }
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

            else if (showTypeBox.Text != "")
            {
                String ShowType;
                ShowType = showTypeBox.Text;
                try
                {
                    String query = "SELECT * FROM Shows_Info WHERE showType = '" + showTypeBox.Text + "'";
                    SqlDataAdapter sda = new SqlDataAdapter(query, conn);

                    DataTable dtable = new DataTable();
                    sda.Fill(dtable);

                    if (dtable.Rows.Count > 0)
                    {
                        // Преобразуем таблицу в список строк
                        List<string> showList = new List<string>();

                        foreach (DataRow row in dtable.Rows)
                        {

                            string showName = row["showName"].ToString();
                            string showType = row["showType"].ToString();
                            string showCost = row["showCost"].ToString();
                            string showTown = row["showTown"].ToString();
                            string showLink = row["buyLink"].ToString();

                            // Формируем строку для отображения
                            string showInfo = $"Назва: {showName} Тип: {showType} Ціна: {showCost} Місто: {showTown} Придбати: {showLink}";

                            // Добавляем в список
                            showList.Add(showInfo);


                        }

                        // Сортируем список по цене
                        for (int i = 0; i < showList.Count - 1; i++)
                        {
                            for (int j = i + 1; j < showList.Count; j++)
                            {
                                int costI = int.Parse(showList[i].Split(new[] { "Ціна: " }, StringSplitOptions.None)[1].Split(' ')[0]);
                                int costJ = int.Parse(showList[j].Split(new[] { "Ціна: " }, StringSplitOptions.None)[1].Split(' ')[0]);

                                if (costI > costJ)
                                {
                                    // Обмен элементов списка для сортировки
                                    string temp = showList[i];
                                    showList[i] = showList[j];
                                    showList[j] = temp;
                                }
                            }
                        }

                        // Формируем отсортированную строку и выводим в result
                        result.Text = string.Join(Environment.NewLine, showList);
                    }
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

            else if (showTownBox.Text != "")
            {
                String ShowCity;
                ShowCity = showTownBox.Text;
                try
                {
                    String query = "SELECT * FROM Shows_Info WHERE showTown = '" + showTownBox.Text + "'";
                    SqlDataAdapter sda = new SqlDataAdapter(query, conn);

                    DataTable dtable = new DataTable();
                    sda.Fill(dtable);

                    if (dtable.Rows.Count > 0)
                    {
                        // Преобразуем таблицу в список строк
                        List<string> showList = new List<string>();

                        foreach (DataRow row in dtable.Rows)
                        {

                            string showName = row["showName"].ToString();
                            string showType = row["showType"].ToString();
                            string showCost = row["showCost"].ToString();
                            string showTown = row["showTown"].ToString();
                            string showLink = row["buyLink"].ToString();
                            // Формируем строку для отображения
                            string showInfo = $"Назва: {showName} Тип: {showType} Ціна: {showCost} Місто: {showTown} Придбати: {showLink}";

                            // Добавляем в список
                            showList.Add(showInfo);


                        }

                        // Сортируем список по цене
                        for (int i = 0; i < showList.Count - 1; i++)
                        {
                            for (int j = i + 1; j < showList.Count; j++)
                            {
                                int costI = int.Parse(showList[i].Split(new[] { "Ціна: " }, StringSplitOptions.None)[1].Split(' ')[0]);
                                int costJ = int.Parse(showList[j].Split(new[] { "Ціна: " }, StringSplitOptions.None)[1].Split(' ')[0]);

                                if (costI > costJ)
                                {
                                    // Обмен элементов списка для сортировки
                                    string temp = showList[i];
                                    showList[i] = showList[j];
                                    showList[j] = temp;
                                }
                            }
                        }

                        // Формируем отсортированную строку и выводим в result
                        result.Text = string.Join(Environment.NewLine, showList);
                    }
                }
                catch(Exception Except)
                {
                    MessageBox.Show($"General exception: {Except.Message}");
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

        private void showTypeBox_MouseDown(object sender, MouseEventArgs e)
        {
            showTypeBox.Text = "";
        }

        private void showTownBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            showTownBox.Text = "";
        }
    }
}
