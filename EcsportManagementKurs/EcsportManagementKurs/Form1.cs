using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EcsportManagementKurs
{
    public partial class Form1 : Form
    {
        private DataSet ContractSet = new DataSet();
        private DataSet ContractLineSet = new DataSet();
        private SqlDataAdapter sqlDataAdapterForLeftGrid;
        private SqlDataAdapter SelectForRightGrid; 
        public Form1()
        {
            InitializeComponent();

            //  Data Source = pcsqlstud01; Integrated Security = True; Connect Timeout = 30; Encrypt = False; Trust Server Certificate = False; Application Intent = ReadWrite; Multi Subnet Failover = False
            string connectionString = @"Data Source=pcsqlstud01;Initial Catalog=10220468;Integrated Security=True;Encrypt=False";

            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            if (connection.State == System.Data.ConnectionState.Open)
            {

                connectionStatusLabel.Text = "Connected";
                connectionStatusLabel.ForeColor = System.Drawing.Color.Green;
                string SelectForLeftGrid = "SELECT * FROM Contract;";
                 sqlDataAdapterForLeftGrid = new SqlDataAdapter(SelectForLeftGrid, connection);
                
                sqlDataAdapterForLeftGrid.Fill(ContractSet);
                LeftMainGrid.DataSource = ContractSet.Tables[0];


               
                //string selectForRightGrid = "SELECT * FROM ContractLine";
                // SelectForRightGrid = new SqlDataAdapter(selectForRightGrid, connection);

                //SelectForRightGrid.Fill(ContractLineSet);
                //RightMainGrid.DataSource = ContractLineSet.Tables[0];

            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            //  Data Source = pcsqlstud01; Integrated Security = True; Connect Timeout = 30; Encrypt = False; Trust Server Certificate = False; Application Intent = ReadWrite; Multi Subnet Failover = False
            string connectionString = @"Data Source=pcsqlstud01;Initial Catalog=10220468;Integrated Security=True;Encrypt=False";
           
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            if (connection.State == System.Data.ConnectionState.Open)
            { 
            
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            InsertForm form2 = new InsertForm();
            form2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }




        private void button1_Click(object sender, EventArgs e)
        {
            //кнопка удалить

        }

        private void button6_Click(object sender, EventArgs e)
        {
        }

        private void редактироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Левая кнопака редактировать
            

            var selectedRowIndex = -1;
            if (LeftMainGrid.SelectedRows.Count > 0 && LeftMainGrid.SelectedRows[0].Index < LeftMainGrid.Rows.Count - 1)
            {
                selectedRowIndex = LeftMainGrid.SelectedRows[0].Index;
            }
            else
            {
                MessageBox.Show("Вы не выбрали строку для редактирования!");
                return;
            }
            EditAddPage editAddPage = new EditAddPage(selectedRowIndex, ContractSet, sqlDataAdapterForLeftGrid);
            editAddPage.Show();

            
        }

        private void редактироватьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //правая кнопка редактировать 
            var selectedRowIndex = -1;
            if (RightMainGrid.SelectedRows.Count > 0 && RightMainGrid.SelectedRows[0].Index < RightMainGrid.Rows.Count - 1)
            {
                selectedRowIndex = RightMainGrid.SelectedRows[0].Index;
            }
            else
            {
                MessageBox.Show("Вы не выбрали строку для редактирования!");
                return;
            }
            EditContractLine editContractLine = new EditContractLine(selectedRowIndex, ContractLineSet, SelectForRightGrid);
            editContractLine.Show();
        }

        private void LeftMainGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ViviodLineButton_Click(object sender, EventArgs e)
        {
            //Вывод вправоооооооооооооооооо
            string connectionString = @"Data Source=pcsqlstud01;Initial Catalog=10220468;Integrated Security=True;Encrypt=False";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            if (LeftMainGrid.SelectedRows.Count > 0)
            {
                int selectedIndex = LeftMainGrid.SelectedRows[0].Index;
                int id = Convert.ToInt32(LeftMainGrid.Rows[selectedIndex].Cells[0].Value);

                string selectForRightGrid = $"SELECT * FROM ContractLine WHERE idContract = {id}";
                SelectForRightGrid = new SqlDataAdapter(selectForRightGrid, connection);
                ContractLineSet.Clear();
                SelectForRightGrid.Fill(ContractLineSet);
                RightMainGrid.DataSource = ContractLineSet.Tables[0];

            }
            else{MessageBox.Show("Выберите строку в таблице."); }

        }
        void UpdateDataGrid()
        {
            string connectionString = @"Data Source=pcsqlstud01;Initial Catalog=10220468;Integrated Security=True;Encrypt=False";
            SqlConnection connection = new SqlConnection(connectionString);
            connection = new SqlConnection(connectionString);
            sqlDataAdapterForLeftGrid = new SqlDataAdapter($"SELECT * FROM Contract", connection);
            DataTable dataTable = new DataTable();
            sqlDataAdapterForLeftGrid.Fill(dataTable);
            LeftMainGrid.DataSource = dataTable;

        }
        private void удалитьToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=pcsqlstud01;Initial Catalog=10220468;Integrated Security=True;Encrypt=False";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            var selectedRowIndex = -1;
            if (LeftMainGrid.SelectedRows.Count > 0 && LeftMainGrid.SelectedRows[0].Index < LeftMainGrid.Rows.Count - 1)
            {
                selectedRowIndex = LeftMainGrid.SelectedRows[0].Index;
            }
            else
            {
                MessageBox.Show("Вы не выбрали строку для УДАЛЕНИЯ!!!");
                return;
            }
            DialogResult result = MessageBox.Show("Вы уверенны, что хотите удалить???", "Удалить", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {

                DataGridViewRow currentRow = LeftMainGrid.CurrentRow;
                var idValue = currentRow.Cells["idDocument"].Value;
                Convert.ToInt32(idValue);


                string deletequery = "DELETE FROM Contract WHERE idDocument = " + idValue + ";";
                SqlCommand deleteComand = new SqlCommand(deletequery, connection);

                int rowsAffected = deleteComand.ExecuteNonQuery();

                UpdateDataGrid();
            }
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Вывести содержание на сомом деле

            string connectionString = @"Data Source=pcsqlstud01;Initial Catalog=10220468;Integrated Security=True;Encrypt=False";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            if (LeftMainGrid.SelectedRows.Count > 0)
            {
                int selectedIndex = LeftMainGrid.SelectedRows[0].Index;
                int id = Convert.ToInt32(LeftMainGrid.Rows[selectedIndex].Cells[0].Value);

                string selectForRightGrid = $"SELECT * FROM ContractLine WHERE idContract = {id}";
                SelectForRightGrid = new SqlDataAdapter(selectForRightGrid, connection);
                ContractLineSet.Clear();
                SelectForRightGrid.Fill(ContractLineSet);
                RightMainGrid.DataSource = ContractLineSet.Tables[0];

            }
            else { MessageBox.Show("Выберите строку в таблице."); }


        }
    }
    
    
}
