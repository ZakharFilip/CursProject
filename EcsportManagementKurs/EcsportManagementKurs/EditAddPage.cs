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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EcsportManagementKurs
{
    public partial class EditAddPage : Form
    {
        private DataSet ContractSet = new DataSet();
        private DataSet ContractLineSet = new DataSet();
        private SqlDataAdapter sqlDataAdapterForLeftGrid;
        private SqlDataAdapter SelectForRightGrid;
        private int itemId;
        public EditAddPage()
        {
            InitializeComponent();
        }

        public EditAddPage(int id, DataSet dataset, SqlDataAdapter adapter)
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
                textBox2.Text = row["idSupplier"].ToString();
                textBox4.Text = row["idRecipient"].ToString();
                textBox1.Text = row["Date"].ToString();

            }

        }
        private void changeItemButton_Click(object sender, EventArgs e)
        {
            //кнопка для редактирования контракта 
            

            InitializeComponent();
            string connectionString = @"Data Source=pcsqlstud01;Initial Catalog=10220468;Integrated Security=True;Encrypt=False";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            

            MessageBox.Show(itemId.ToString());

            if (connection.State == System.Data.ConnectionState.Open)
            {
                //Добавить код для изменения коетракта
                
                string querySupplier = "UPDATE Contract SET idSupplier = @updatedValue WHERE idDocument = itemId";
                string queryRecipient = "UPDATE Contract SET idRecipient = @updatedRecipient WHERE idDocument = itemId";
                string queryData = "UPDATE Contract SET idSupplier = @updatedData WHERE idDocument = itemId";


                int recordIdentifier =itemId;
                string newSupplierString = textBox4.Text;
                string newRecipient = textBox2.Text;
                string newData = textBox1.Text;



                SqlCommand commandAddSupplier = new SqlCommand(querySupplier, connection);
                commandAddSupplier.Parameters.AddWithValue("@updatedValue", newSupplierString);

                SqlCommand commandAddRecipient = new SqlCommand(queryRecipient, connection);
                commandAddRecipient.Parameters.AddWithValue("@updatedRecipient", newRecipient);

                SqlCommand commandAddData = new SqlCommand(queryData, connection);
                commandAddRecipient.Parameters.AddWithValue("@updatedData", newData);


                try
                {
                    
                    int rowsAffected = commandAddSupplier.ExecuteNonQuery(); // Выполняем запрос

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

        private void EditAddPage_Load(object sender, EventArgs e)
        {

        }
    }
}

       
