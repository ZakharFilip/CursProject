﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aunteficatio0nBD
{
    public partial class Regestration : Form
    {
        public Regestration()
        {
            InitializeComponent();



        }

        private void Regestration_Load(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=pcsqlstud01;Initial Catalog=10220468;Integrated Security=True;Encrypt=False";
            int lol = 0;
            int charCount = 0;
            int numbletter = 0;
            int numbletter1 = 0;
            string passwd ="";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            string selectQuery = "SELECT * FROM Users;";
            SqlDataAdapter DataAdapter = new SqlDataAdapter(selectQuery, connection);
            DataSet usersSet = new DataSet();
            DataAdapter.Fill(usersSet);


            foreach (DataRow row in usersSet.Tables[0].Rows)
            {
                if (row["login"].ToString() == loginTextBox.Text || row["mail"].ToString() == mailTextBox.Text)
                {
                    MessageBox.Show("Данный пользователь занят");


                }
                else
                { lol = 1; break;

                    passwd = passwordTextBox.Text;
                }
            }
            
                if (lol == 1)
                {
                    if (loginTextBox.Text == "" || passwordTextBox.Text == "" || NameTextBox.Text == "" || SecNameTextBox.Text == "" || passwordTextBox.Text == "" || mailTextBox.Text == "")
                    {
                        MessageBox.Show("Заполните все поля!");
                    }
                    else
                    {

                    for (int i = 0; i < passwd.Length; i++)
                    {
                        if (passwd[i]== passwd.ToUpper()[i])
                        {
                            numbletter = 1;
                        }
                        if (passwd[i] != passwd.ToUpper()[i])
                        {
                            numbletter1 = 1;
                        }
                        if (passwd[i] == '1'|| passwd[i] == '2' || passwd[i] == '3' || passwd[i] == '4' || passwd[i] == '5' || passwd[i] == '6' || passwd[i] == '7' || passwd[i] == '8' || passwd[i] == '9' )
                        {
                            charCount = 1;
                        }

                    }

                    if (numbletter == 1&& numbletter1 == 1&& charCount == 1) {
                        DataRow newRow = usersSet.Tables[0].NewRow();

                        newRow["login"] = loginTextBox.Text;
                        newRow["password"] = passwordTextBox.Text;
                        newRow["name"] = NameTextBox.Text;
                        newRow["secName"] = SecNameTextBox.Text;
                        newRow["phone"] = phoneTextBox.Text;
                        newRow["mail"] = mailTextBox.Text;
                        newRow["Role"] = "1";
                        usersSet.Tables[0].Rows.Add(newRow);
                        SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(DataAdapter);

                        DataAdapter.Update(usersSet);

                        MessageBox.Show("Вы зарегистрированы");
                        }

                    }
                }




        }
    }
}
