﻿using System;
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


               
                string selectForRightGrid = "SELECT * FROM ContractLine";
                 SelectForRightGrid = new SqlDataAdapter(selectForRightGrid, connection);

                SelectForRightGrid.Fill(ContractLineSet);
                RightMainGrid.DataSource = ContractLineSet.Tables[0];

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




        private void button1_Click(object sender, EventArgs e)
        {
            //кнопка удалить

        }

        private void button6_Click(object sender, EventArgs e)
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
    }
    
    
}
