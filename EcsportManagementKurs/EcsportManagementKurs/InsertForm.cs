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
                if (klickcounter==2)
                {
                    AddContractButt.ForeColor = System.Drawing.Color.Gray;

                    string selectQuery = "SELECT * FROM Contract;";
                    SqlDataAdapter SqlDataAdapterForContract = new SqlDataAdapter(selectQuery, connection);

                    ContractLineSet = new DataSet();
                    SqlDataAdapterForContract.Fill(ContractLineSet);

                    DataRow newRow = ContractLineSet.Tables[0].NewRow();
                    string fortype = textBox3.Text;
                    newRow["idSupplier"] = textBox1.Text;//int.Parse(fortype);
                    newRow["idRecipient"] = textBox2.Text;
                    newRow["Date"] = Convert.ToDateTime(fortype);

                    ContractLineSet.Tables[0].Rows.Add(newRow);
                    klickcounter++;
                }
                else
                {
                    goodData = DataSelecter.Text;
                    goodData=DataTranslater(goodData);
                    MessageBox.Show(goodData);
                    //По поволду даты конвертирование у чата ГПТ спросить
                }
            }
        }


        public string DataTranslater(string badData)
        {
            string goodData = "";
            string day = ""; day = day + badData[0]; day = day + badData[1];
            string mounth="";
            string year="";

            int i=3;
            switch (badData[i])
            {
                case 'я':
                    mounth = "01";
                    break;
                case 'ф':
                    mounth = "02";
                    break;
                case 'м':
                    if (badData[i + 2] == 'р') { mounth = "03"; } else { mounth = "05"; }
                    break;
                case 'а':
                    if (badData[i + 1] == 'п') { mounth = "04"; } else { mounth = "08"; }
                    break;
                case 'и':
                    if (badData[i + 2] == 'н') { mounth = "06"; } else { mounth = "07"; }
                    break;
                case 'с':
                    mounth = "09";
                    break;
                case 'о':
                    mounth = "10";
                    break;
                case 'н':
                    mounth = "11";
                    break;
                case 'д':
                    mounth = "12";
                    break;
            }

            for ( i = 3; i < badData. Length; i++)
            {
                if (badData[i] ==' ')
                { break; }
            }

            for (int j = 0; i < 4; i++)
            {
                year = year + badData[i+j];
            }

            goodData = year + '-' + mounth + '-' + day;

            return goodData;
        }
    }
}
