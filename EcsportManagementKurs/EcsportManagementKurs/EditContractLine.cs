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

namespace EcsportManagementKurs
{
    public partial class EditContractLine : Form
    {
        private DataSet ContractSet = new DataSet();
        private DataSet ContractLineSet = new DataSet();
        private SqlDataAdapter sqlDataAdapterForLeftGrid;
        private SqlDataAdapter SelectForRightGrid;
        private int itemId;
        private string idContractLine;
        public EditContractLine()
        {
            InitializeComponent();
        }

        public EditContractLine(int id, DataSet dataset, SqlDataAdapter adapter)
        {
            InitializeComponent();
            ContractSet = dataset;
            sqlDataAdapterForLeftGrid = adapter;
            itemId = id;
            //если id != -1 (выбрана строка), устанавливаем текст в кнопке на "Изменить"
            changeItemButton.Text = itemId != -1 ? "Изменить" : "Добавить";
            //если данные изменяются, то добавляем в текстбокс текст выбранной строки
            if (itemId != -1)
            {
                var row = ContractSet.Tables[0].Rows[itemId];
                textBox2.Text = row["idMaterial"].ToString();
                textBox4.Text = row["Volume"].ToString();
                textBox1.Text = row["Summ"].ToString();
                idContractLine = row["idLine"].ToString();
            }
        }

        private void EditContractLine_Load(object sender, EventArgs e)
        {

        }

        private void changeItemButton_Click(object sender, EventArgs e)
        {
            //кнопка для редактирования строки 
            //Добавить код для изменения строки контракта
            //кнопка для редактирования контракта   
            string connectionString = @"Data Source=pcsqlstud01;Initial Catalog=10220468;Integrated Security=True;Encrypt=False";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            if (connection.State == System.Data.ConnectionState.Open)
            {
                //Добавить код для изменения контракта
                int recordIdentifier = itemId;

                string newMatereal = textBox2.Text;
                string newValume = textBox4.Text.ToString();
                string newSumm = textBox1.Text.ToString();




                string querySupplier = $"UPDATE ContractLine SET idMaterial =  {Convert.ToInt32(newMatereal)}  WHERE idLine = {Convert.ToInt32(idContractLine)}";
                string queryRecipient = $"UPDATE ContractLine SET Volume = {newValume}  WHERE idLine =  {Convert.ToInt32(idContractLine)}";

                string queryData = $"UPDATE ContractLine SET Summ =  '{newSumm}' WHERE idLine = {Convert.ToInt32(idContractLine)}";

                SqlCommand commandAddSupplier = new SqlCommand(querySupplier, connection);

                commandAddSupplier.Parameters.AddWithValue(textBox2.Text, newMatereal);

                SqlCommand commandAddRecipient = new SqlCommand(queryRecipient, connection);
                commandAddRecipient.Parameters.AddWithValue(textBox4.Text, newValume);

                SqlCommand commandAddData = new SqlCommand(queryData, connection);
                commandAddRecipient.Parameters.AddWithValue(textBox1.Text, newSumm);


                try
                {
                    int rowsAffected=0;

                    //rowsAffected = commandAddSupplier.ExecuteNonQuery(); // Выполняем запрос
                    rowsAffected = rowsAffected + commandAddRecipient.ExecuteNonQuery();
                    rowsAffected = rowsAffected + commandAddData.ExecuteNonQuery();

                    // Проверяем, были ли затронуты строки
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Данные обновлены успешно.");
                    }
                    else
                    {
                        MessageBox.Show("Не удалось обновить данные. Проверьте ID.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Произошла ошибка: " + ex.Message);
                }





            }
        }
    }
}
