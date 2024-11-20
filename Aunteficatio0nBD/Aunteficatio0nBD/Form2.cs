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
    public partial class Form2 : Form
    {
        private DataSet categoriesSet, usersSet;
        private List<Category> categories = new List<Category>();
        public Form2()
        {
            InitializeComponent();
            Usak();
        }
        public void Usak()
        {
            string usak;
            //InitializeComponent();
            string connectionString = @"Data Source=pcsqlstud01;Initial Catalog=10220468;Integrated Security=True;Encrypt=False";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            if (connection.State == System.Data.ConnectionState.Open)
            {
                
                    connectionStatusLabel.Text = "Connected";
                    string selectQuery = "SELECT * FROM Product;";
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(selectQuery, connection);
                    usersSet = new DataSet();
                    sqlDataAdapter.Fill(usersSet);
                    usersGrid.DataSource = usersSet.Tables[0];
                categoriesSet = new DataSet();
                    //foreach (DataRow categoryRow in usersSet.Tables[0].Rows)
                    //{
                    //    categories.Add(new Category(categoryRow["CategoryName"].ToString(),
                    //        Convert.ToInt32(categoryRow["CategoryID"])));
                    //}
                    //comboBox1.DataSource = categories;
               
               
            }
        }

        private void usersGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void connectionStatusLabel_Click(object sender, EventArgs e)
        {

        }
       public void Tester() { radioButton1.Checked = true; }

        

        private void PodtverdButt_Click(object sender, EventArgs e)
        {
            //string usak;
            //InitializeComponent();
            //string connectionString = @"Data Source=pcsqlstud01;Initial Catalog=10220468;Integrated Security=True;Encrypt=False";
            //SqlConnection connection = new SqlConnection(connectionString);
            //connection.Open();
            //if (connection.State == System.Data.ConnectionState.Open)
            //{
            //    connectionStatusLabel.Text = "Connected";
            //    string selectQuery = "SELECT * FROM Product;";
            //    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(selectQuery, connection);
            //    DataSet usersSet = new DataSet();
            //    sqlDataAdapter.Fill(usersSet);
            //    usersGrid.DataSource = usersSet.Tables[0];




                




                DataRow newRow = usersSet.Tables[0].NewRow();
                string fortype = textBox1.Text;
                newRow["typeOfProduct"] = Convert.ToInt32(fortype);//int.Parse(fortype);
                newRow["nameOfProduct"] = textBox2.Text;
                newRow["articul"] = textBox3.Text;
                newRow["minPrice"] = textBox4.Text;
                usersSet.Tables[0].Rows.Add(newRow);
                Usak();





           // }
            //var selectedCategoryId = _categoriees[categoriesCombo.SelectedIndex].Id;


        }
    }
}
 