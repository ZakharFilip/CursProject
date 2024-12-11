using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace EcsportManagementKurs
{

    public partial class InsertForm : Form
    {
        private DataSet ContractSet = new DataSet();
        private DataSet ContractLineSet = new DataSet();
        private SqlDataAdapter sqlDataAdapterForataInsertGrid;
        private SqlDataAdapter SqlDataAdapterForContract;
        private int itemId;
        public InsertForm()
        {
            InitializeComponent();
            string connectionString = @"Data Source=pcsqlstud01;Initial Catalog=10220468;Integrated Security=True;Encrypt=False";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            if (connection.State == System.Data.ConnectionState.Open)
            {

                
                string SelectForDataInsertGrid = "SELECT * FROM Contract;";
                sqlDataAdapterForataInsertGrid = new SqlDataAdapter(SelectForDataInsertGrid, connection);

                sqlDataAdapterForataInsertGrid.Fill(ContractSet);
                DataInsertGrid.DataSource = ContractSet.Tables[0];
            }
        }

        private void backToMainButt_Click(object sender, EventArgs e)
        {
            InsertForm form2 = new InsertForm();
            form2.Hide();


        }

        private void InsertForm_Load(object sender, EventArgs e)
        {

        }
        public InsertForm(int id, DataSet dataset, SqlDataAdapter adapter)
        {
           
        }

        private void changeItemButton_Click(object sender, EventArgs e)
        {
            
        }

        private void AddContractButt_Click(object sender, EventArgs e)
        {
            
            int klickcounter = 0;
            string goodData = "";

            string connectionString = @"Data Source=pcsqlstud01;Initial Catalog=10220468;Integrated Security=True;Encrypt=False";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            if (connection.State == System.Data.ConnectionState.Open)
            {
                if (klickcounter==0)
                {
                    MessageBox.Show("Раблотав");
                    AddContractButt.ForeColor = System.Drawing.Color.Gray;

                    string selectQuery = "SELECT * FROM Contract;";
                    SqlDataAdapter SqlDataAdapterForContract = new SqlDataAdapter(selectQuery, connection);

                    ContractLineSet = new DataSet();
                    SqlDataAdapterForContract.Fill(ContractLineSet);

                    DataRow newRow = ContractLineSet.Tables[0].NewRow();
                   
                    newRow["idSupplier"] = textBox1.Text;//int.Parse(fortype);
                    newRow["idRecipient"] = textBox2.Text;

                    string newData = DataSelecter.Text;
                    newData = newData.Replace('.', '_').Replace(' ', '_');
                    newRow["Date"] = DataSelecter.Text;

                    ContractLineSet.Tables[0].Rows.Add(newRow);
                    klickcounter++;
                }
                else
                {
                    MessageBox.Show("Чебукиска");
                    //По поволду даты конвертирование у чата ГПТ спросить
                }
            }
        }


       

        private void RedactPenisbutton_Click(object sender, EventArgs e)
        {
            var selectedRowIndex = -1;
            if (DataInsertGrid.SelectedRows.Count > 0 && DataInsertGrid.SelectedRows[0].Index < DataInsertGrid.Rows.Count - 1)
            {
                selectedRowIndex = DataInsertGrid.SelectedRows[0].Index;
            }
            else
            {
                MessageBox.Show("Вы не выбрали строку для редактирования!");
                return;
            }
            EditAddPage editAddPage = new EditAddPage(selectedRowIndex, ContractSet, sqlDataAdapterForataInsertGrid);
            editAddPage.Show();
        }
    }
}
