﻿using System;
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

        

        private void nameOf_MouseDown(object sender, MouseEventArgs e)
        {
            nameOf.Text = "";
            showTypeBox.Text = "";
            showTownBox.Text = "";
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
                        List<showClass> showList = new List<showClass>();

                        foreach (DataRow row in dtable.Rows)
                        {

                            string showName = row["showName"].ToString();
                            string showType = row["showType"].ToString();
                            int showCost = Convert.ToInt32(row["showCost"].ToString());
                            string showTown = row["showTown"].ToString();
                            string showLink = row["buyLink"].ToString();
                            // Формируем строку для отображения
                            //string showInfo = $"Назва: {showName} Тип: {showType} Ціна: {showCost} Місто: {showTown} Придбати: {showLink}";
                            showClass show = new showClass(showName, showType, showCost, showTown, showLink);
                            // Добавляем в список
                            showList.Add(show);


                        }

                        // Сортируем список по цене
                        for (int i = 0; i < showList.Count - 1; i++)
                        {
                            for (int j = i + 1; j < showList.Count; j++)
                            {
                                int costI = showList[i].getCost();
                                int costJ = showList[j].getCost();

                                if (costI > costJ)
                                {
                                    // Обмен элементов списка для сортировки
                                    showClass temp = showList[i];
                                    showList[i] = showList[j];
                                    showList[j] = temp;
                                }
                            }
                        }

                        // Формируем отсортированную строку и выводим в result
                        var sortedShowInfo = showList.Select(show => $"Назва: {show.getName()} Тип: {show.getType()} Ціна: {show.getCost()} Місто: {show.getTown()} Придбати: {show.getLink()}");
                        result.Text = string.Join(Environment.NewLine, sortedShowInfo);
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

            if (showTypeBox.Text != "")
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
                        List<showClass> showList = new List<showClass>();

                        foreach (DataRow row in dtable.Rows)
                        {

                            string showName = row["showName"].ToString();
                            string showType = row["showType"].ToString();
                            int showCost = Convert.ToInt32(row["showCost"].ToString());
                            string showTown = row["showTown"].ToString();
                            string showLink = row["buyLink"].ToString();
                            // Формируем строку для отображения
                            //string showInfo = $"Назва: {showName} Тип: {showType} Ціна: {showCost} Місто: {showTown} Придбати: {showLink}";
                            showClass show = new showClass(showName, showType, showCost, showTown, showLink);
                            // Добавляем в список
                            showList.Add(show);


                        }

                        // Сортируем список по цене
                        for (int i = 0; i < showList.Count - 1; i++)
                        {
                            for (int j = i + 1; j < showList.Count; j++)
                            {
                                int costI = showList[i].getCost();
                                int costJ = showList[j].getCost();

                                if (costI > costJ)
                                {
                                    // Обмен элементов списка для сортировки
                                    showClass temp = showList[i];
                                    showList[i] = showList[j];
                                    showList[j] = temp;
                                }
                            }
                        }

                        // Формируем отсортированную строку и выводим в result
                        var sortedShowInfo = showList.Select(show => $"Назва: {show.getName()} Тип: {show.getType()} Ціна: {show.getCost()} Місто: {show.getTown()} Придбати: {show.getLink()}");
                        result.Text = string.Join(Environment.NewLine, sortedShowInfo);
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

            if (showTownBox.Text != "")
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
                        List<showClass> showList = new List<showClass>();

                        foreach (DataRow row in dtable.Rows)
                        {

                            string showName = row["showName"].ToString();
                            string showType = row["showType"].ToString();
                            int showCost = Convert.ToInt32(row["showCost"].ToString());
                            string showTown = row["showTown"].ToString();
                            string showLink = row["buyLink"].ToString();
                            // Формируем строку для отображения
                            //string showInfo = $"Назва: {showName} Тип: {showType} Ціна: {showCost} Місто: {showTown} Придбати: {showLink}";
                            showClass show = new showClass(showName, showType, showCost, showTown, showLink);
                            // Добавляем в список
                            showList.Add(show);


                        }

                        // Сортируем список по цене
                        for (int i = 0; i < showList.Count - 1; i++)
                        {
                            for (int j = i + 1; j < showList.Count; j++)
                            {
                                int costI = showList[i].getCost();
                                int costJ = showList[j].getCost();

                                if (costI > costJ)
                                {
                                    // Обмен элементов списка для сортировки
                                    showClass temp = showList[i];
                                    showList[i] = showList[j];
                                    showList[j] = temp;
                                }
                            }
                        }

                        // Формируем отсортированную строку и выводим в result
                        var sortedShowInfo = showList.Select(show => $"Назва: {show.getName()} Тип: {show.getType()} Ціна: {show.getCost()} Місто: {show.getTown()} Придбати: {show.getLink()}");
                        result.Text = string.Join(Environment.NewLine, sortedShowInfo);
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
            showTownBox.Text = "";
            nameOf.Text = "";
        }

        private void showTownBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            showTownBox.Text = "";
            showTypeBox.Text = "";
            nameOf.Text = "";
        }
    }
}
