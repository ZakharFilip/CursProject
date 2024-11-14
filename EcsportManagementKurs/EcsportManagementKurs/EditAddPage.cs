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
            //Добавить код для изменения коетракта

        }


    }
}

       
