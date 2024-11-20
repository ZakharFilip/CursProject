using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            
            InitializeComponent();

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ConfirmBut_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=pcsqlstud01;Initial Catalog=10220468;Integrated Security=True;Encrypt=False";
            string usak="";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();     
            if (connection.State == System.Data.ConnectionState.Open)
            {
                int lol=0;
                connectionStatusLabel.Text = "Connected";
                string selectQuery = "SELECT * FROM Users;";
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(selectQuery, connection);
                DataSet usersSet = new DataSet();
                sqlDataAdapter.Fill(usersSet);
                
                foreach (DataRow row in usersSet.Tables[0].Rows)
                {
                    if (row["login"].ToString() == loginBox.Text && row["password"].ToString() == passwordBox.Text)
                    {
                        usak = row["Name"].ToString();
                        lol = 1;
                        break;
                    }
                }
                if (lol == 0) { MessageBox.Show("Неверный логин или пароль"); }
                if (lol==1)
                {
                    foreach (DataRow row in usersSet.Tables[0].Rows)
                    {
                        if (row["login"].ToString() == loginBox.Text && row["Role"].ToString() == "1")
                        {
                            MessageBox.Show("Добро пожаловать пальзак "+usak+"!");
                            break;
                        }
                        if (row["login"].ToString() == loginBox.Text && row["Role"].ToString() == "2")
                        {
                            MessageBox.Show("Добро пожаловать Админ " + usak + "!");
                            break;
                        }
                        if (row["login"].ToString() == loginBox.Text && row["Role"].ToString() == "3")
                        {
                            MessageBox.Show("Добро пожаловать Менеджер " + usak + "!");
                            break;
                        }
                    }
                    Form2 form2 = new Form2();
                    form2.Show();
                }
            }
        }

        private void RegestrationButton_Click(object sender, EventArgs e)
        {
            Regestration form3 = new Regestration();
            form3.Show();
           
        }
    }
}
