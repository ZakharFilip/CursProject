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

        public int klickcounter = 0;
        private void AddContractButt_Click(object sender, EventArgs e)
        {
            
            
            string goodData = "";

            AddContractButt.ForeColor = System.Drawing.Color.Gray;
            string connectionString = @"Data Source=pcsqlstud01;Initial Catalog=10220468;Integrated Security=True;Encrypt=False";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            if (connection.State == System.Data.ConnectionState.Open)
            {
                if (klickcounter==0)
                {
                    
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

                    SqlCommandBuilder commandBuilder = new SqlCommandBuilder(SqlDataAdapterForContract);
                    SqlDataAdapterForContract.Update(ContractLineSet);

                    
                    klickcounter++;


                    ContractSet.Clear();
                    string SelectForDataInsertGrid = "SELECT * FROM Contract;";
                    sqlDataAdapterForataInsertGrid = new SqlDataAdapter(SelectForDataInsertGrid, connection);

                    sqlDataAdapterForataInsertGrid.Fill(ContractSet);
                    DataInsertGrid.DataSource = ContractSet.Tables[0];


                }
                else
                {
                    AddContractButt.ForeColor = System.Drawing.Color.Gray;
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

        private void AddContractLineButt_Click(object sender, EventArgs e)
        {
            //ВВод
            string connectionString = @"Data Source=pcsqlstud01;Initial Catalog=10220468;Integrated Security=True;Encrypt=False";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();



            string selectQuery = "SELECT * FROM ContractLine;";
            SqlDataAdapter SqlDataAdapterForContract = new SqlDataAdapter(selectQuery, connection);

            ContractLineSet = new DataSet();
            ContractLineSet.Clear();
            SqlDataAdapterForContract.Fill(ContractLineSet);

            DataRow newRow = ContractLineSet.Tables[0].NewRow();
            newRow["idContract"] = idchnik;
            newRow["idMaterial"] = textBox5.Text;
            newRow["Volume"] = textBox6.Text;
            newRow["Summ"] = textBox4.Text;

            ContractLineSet.Tables[0].Rows.Add(newRow);

            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(SqlDataAdapterForContract);
            SqlDataAdapterForContract.Update(ContractLineSet);


           


            ContractSet.Clear();

            string SelectForDataInsertGrid = $"SELECT * FROM ContractLine WHERE idContract = {idchnik};";
            sqlDataAdapterForataInsertGrid = new SqlDataAdapter(SelectForDataInsertGrid, connection);

            sqlDataAdapterForataInsertGrid.Fill(ContractSet);
            DataInsertGrid.DataSource = ContractSet.Tables[0];
        }

        int idchnik;
        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=pcsqlstud01;Initial Catalog=10220468;Integrated Security=True;Encrypt=False";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            if (DataInsertGrid.SelectedRows.Count > 0)
            {
                int selectedIndex = DataInsertGrid.SelectedRows[0].Index;
                idchnik = Convert.ToInt32(DataInsertGrid.Rows[selectedIndex].Cells[0].Value);

                string selectForRightGrid = $"SELECT * FROM ContractLine WHERE idContract = {idchnik}";
                sqlDataAdapterForataInsertGrid = new SqlDataAdapter(selectForRightGrid, connection);
                ContractLineSet.Clear();

                sqlDataAdapterForataInsertGrid.Fill(ContractLineSet);

                DataInsertGrid.DataSource = ContractLineSet.Tables[0];

            }
            else { MessageBox.Show("Выберите строку в таблице."); }
        }
    }
}
