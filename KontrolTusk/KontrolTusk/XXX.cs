using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KontrolTusk
{
    internal class XXX
    {





        //        var selectedRowIndex = -1;

        //                if (Grid.SelectedRows.Count > 0 && Grid.SelectedRows[0].Index<Grid.Rows.Count - 1)
        //                {
        //                    selectedRowIndex = Grid.SelectedRows[0].Index;

        //                }
        //                else
        //                {
        //                    MessageBox.Show("Вы не выбрали строку для редактирования!");
        //                    return;
        //                }

        //var row = SubjectDebtsSet.Tables[0].Rows[selectedRowIndex];
        //string itemId = row["id"].ToString();

        //string connectionString = @"Data Source=pcsqlstud01;Initial Catalog=10220468;Integrated Security=True;Encrypt=False";
        //SqlConnection connection = new SqlConnection(connectionString);
        //connection.Open();


        //MessageBox.Show(dateTimePicker1.Text);

        //if (connection.State == System.Data.ConnectionState.Open)
        //{

        //    //Добавить код для изменения контракта


        //    string StudentName = studentTextBox.Text;
        //    string Subject = subjectTextBox.Text;
        //    string Description = creditTextBox.Text;
        //    string Status = comboBox.Text;
        //    string newData = dateTimePicker1.Text;
        //    //newData = newData.Replace('.', '_');
        //    //newData = newData.Replace(' ', '_');

        //    MessageBox.Show(newData);


        //    string queryStudentName = $"UPDATE MSubjectDebts SET StudentName =  '{StudentName}'  WHERE id = {itemId}";
        //    string querySubject = $"UPDATE MSubjectDebts SET Subject =  '{Subject}'  WHERE id = {itemId}";

        //    string queryDescription = $"UPDATE MSubjectDebts SET Description =  '{Description}'  WHERE id = {itemId}";
        //    string queryStatus = $"UPDATE MSubjectDebts SET Status =  '{Status}'  WHERE id = {itemId}";
        //    string querynewData = $"UPDATE MSubjectDebts SET newData =  '{newData}'  WHERE id = {itemId}";






        //    SqlCommand commandAddSupplier = new SqlCommand(queryStudentName, connection);
        //    commandAddSupplier.Parameters.AddWithValue(studentTextBox.Text, StudentName);

        //    SqlCommand commandAddRecipient = new SqlCommand(querySubject, connection);
        //    commandAddRecipient.Parameters.AddWithValue(subjectTextBox.Text, Subject);

        //    SqlCommand commandAddData = new SqlCommand(queryDescription, connection);
        //    commandAddRecipient.Parameters.AddWithValue(creditTextBox.Text, Description);

        //    SqlCommand commandAdd4 = new SqlCommand(queryStatus, connection);
        //    commandAddRecipient.Parameters.AddWithValue(comboBox.Text, Status);

        //    SqlCommand commandAdd5 = new SqlCommand(querynewData, connection);
        //    commandAddRecipient.Parameters.AddWithValue(dateTimePicker1.Text, newData);


        //    try
        //    {

        //        int rowsAffected = commandAddSupplier.ExecuteNonQuery();
        //        rowsAffected = rowsAffected + commandAddSupplier.ExecuteNonQuery();
        //        rowsAffected = rowsAffected + commandAddRecipient.ExecuteNonQuery();
        //        rowsAffected = rowsAffected + commandAddData.ExecuteNonQuery();
        //        rowsAffected = rowsAffected + commandAdd4.ExecuteNonQuery();

        //        rowsAffected = rowsAffected + commandAdd5.ExecuteNonQuery();


        //        // Проверяем, были ли затронуты строки
        //        if (rowsAffected > 0)
        //        {
        //            MessageBox.Show("Данные обновлены успешно.");
        //        }
        //        else
        //        {
        //            MessageBox.Show("Не удалось обновить данные. Проверьте ID.");
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Произошла ошибка: " + ex.Message);
        //    }
        //    GridUpdater();
        //    groupBox1.Text = "Добавить";
        //    button1.Text = "Добавить";
        //    REeta = true;
        //}
    //}
    }
}
