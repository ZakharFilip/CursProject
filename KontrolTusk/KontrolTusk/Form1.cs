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

namespace KontrolTusk
{
    public partial class Form1 : Form
    {
        SqlDataAdapter sqlDataAdapterForLeftGrid;
        DataSet SubjectDebtsSet = new DataSet();
        public Form1()
        {
            InitializeComponent();
            GridUpdater();

        }

        public void GridUpdater() 
        {
            string connectionString = @"Data Source=pcsqlstud01;Initial Catalog=10220468;Integrated Security=True;Encrypt=False";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connectionStatusLabel.Text = "Connected";
                connectionStatusLabel.ForeColor = System.Drawing.Color.Green;
                string SelectForLeftGrid = "SELECT * FROM MSubjectDebts;";
                sqlDataAdapterForLeftGrid = new SqlDataAdapter(SelectForLeftGrid, connection);
                SubjectDebtsSet.Clear();
                sqlDataAdapterForLeftGrid.Fill(SubjectDebtsSet);
                Grid.DataSource = SubjectDebtsSet.Tables[0];
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (REeta == true)
            {
                string connectionString = @"Data Source=pcsqlstud01;Initial Catalog=10220468;Integrated Security=True;Encrypt=False";
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();



                string selectQuery = "SELECT * FROM MSubjectDebts;";
                SqlDataAdapter SqlDataAdapterForContract = new SqlDataAdapter(selectQuery, connection);

                SubjectDebtsSet = new DataSet();
                SubjectDebtsSet.Clear();
                SqlDataAdapterForContract.Fill(SubjectDebtsSet);

                string newData = dateTimePicker1.Text;

                // newData = newData.Replace('.', '_').Replace(' ', '_');

                DataRow newRow = SubjectDebtsSet.Tables[0].NewRow();
                newRow["StudentName"] = studentTextBox.Text;
                newRow["Subject"] = subjectTextBox.Text;
                newRow["Description"] = creditTextBox.Text;

                newRow["DueDate"] = newData;

                newRow["Status"] = comboBox.Text;

                SubjectDebtsSet.Tables[0].Rows.Add(newRow);

                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(SqlDataAdapterForContract);
                SqlDataAdapterForContract.Update(SubjectDebtsSet);

                GridUpdater();
            }
            else
            {
                var selectedRowIndex = -1;
                if (Grid.SelectedRows.Count > 0 && Grid.SelectedRows[0].Index < Grid.Rows.Count - 1)
                {
                    selectedRowIndex = Grid.SelectedRows[0].Index;

                }
                else
                {
                    List<string> updates = new List<string>();
                    List<SqlParameter> parameters = new List<SqlParameter>();
                    MessageBox.Show("Вы не выбрали строку для редактирования!");
                    return;

                    if (!string.IsNullOrEmpty(studentTextBox.Text))
                    {
                        updates.Add($"StudentName = @newValue");
                        parameters.Add(new SqlParameter("@newValue", studentTextBox));
                    }
                    if (!string.IsNullOrEmpty(subjectTextBox.Text))
                    {
                        updates.Add($"Subject = @newValue");
                        parameters.Add(new SqlParameter("@newValue", studentTextBox));
                    }
                    if (!string.IsNullOrEmpty(creditTextBox.Text))
                    {
                        updates.Add($"StudentName = @newValue");
                        parameters.Add(new SqlParameter("@newValue", studentTextBox));
                    }
                    if (!string.IsNullOrEmpty(dateTimePicker1.Text))
                    {
                        updates.Add($"StudentName = @newValue");
                        parameters.Add(new SqlParameter("@newValue", studentTextBox));
                    }
                    if (!string.IsNullOrEmpty(comboBox.Text))
                    {
                        updates.Add($"StudentName = @newValue");
                        parameters.Add(new SqlParameter("@newValue", studentTextBox));
                    }
                }
            }
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=pcsqlstud01;Initial Catalog=10220468;Integrated Security=True;Encrypt=False";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            var selectedRowIndex = -1;
            if (Grid.SelectedRows.Count > 0 && Grid.SelectedRows[0].Index < Grid.Rows.Count - 1)
            {
                selectedRowIndex = Grid.SelectedRows[0].Index;
            }
            else
            {
                MessageBox.Show("Вы не выбрали строку для УДАЛЕНИЯ!!!");
                return;
            }
            DialogResult result = MessageBox.Show("Вы уверенны, что хотите удалить???", "Удалить", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {

                DataGridViewRow currentRow = Grid.CurrentRow;
                var idValue = currentRow.Cells["id"].Value;
                Convert.ToInt32(idValue);


                string deletequery = "DELETE FROM MSubjectDebts WHERE id = " + idValue + ";";
                SqlCommand deleteComand = new SqlCommand(deletequery, connection);

                int rowsAffected = deleteComand.ExecuteNonQuery();

                GridUpdater();
            }
        }

        bool REeta=true;
        private void редактироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBox1.Text = "РЕДАКТИРОВАТЬ";
            button1.Text = "РЕДАКТИРОВАТЬ";
            REeta = false;

            var selectedRowIndex = -1;

            if (Grid.SelectedRows.Count > 0 && Grid.SelectedRows[0].Index < Grid.Rows.Count - 1)
            {
                selectedRowIndex = Grid.SelectedRows[0].Index;

            }
            else
            {
                MessageBox.Show("Вы не выбрали строку для редактирования!");
                return;
            }
            var row = SubjectDebtsSet.Tables[0].Rows[selectedRowIndex];
            

            studentTextBox.Text = row["StudentName"].ToString();
            subjectTextBox.Text = row["Subject"].ToString();
            creditTextBox.Text = row["Description"].ToString();
            comboBox.Text = row["Status"].ToString();

            string newData = row["DueDate"].ToString();
            newData = newData.Replace('_', ' ');


            dateTimePicker1.Text = newData;
        }
    }
}
