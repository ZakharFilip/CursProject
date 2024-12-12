using iText.Layout;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



//using System.Windows. Documents;
//using System.Windows.Input;
//using System.Windows.Media;
//using System.Windows.Media.Imaging;
//using System.Windows.Navigation;
//using System.Windows.Shapes;
//using System.Xml.Linq;

//using iTextSharp.text;

//using iTextSharp.text.pdf;
//using Image = iTextSharp.text.Image;
//using System.Windows.Markup;
//using System.Windows.Documents;
//using Paragraph = iTextSharp.text.Paragraph;


namespace EcsportManagementKurs
{
    internal class VigruzPDF
    {
        VigruzPDF(SqlDataReader reader)
        {
            Document Nig = new Document();

            var dataList = new System.Collections.Generic.List<string>();
            var dataList1 = new System.Collections.Generic.List<string>();

            while (reader.Read())
            {
                string value = reader["Volume"].ToString();
                dataList.Add(value);

                string value1 = reader["Volume"].ToString();
                dataList1.Add(value1);
            }

            string ForMessageBoxeNigga = "";
            for (int i = 0; i < dataList.Count; i++)
            {
                ForMessageBoxeNigga += dataList[i].ToString();
                ForMessageBoxeNigga += " + \n";
            }
            MessageBox.Show(ForMessageBoxeNigga);

        }
    }
}
