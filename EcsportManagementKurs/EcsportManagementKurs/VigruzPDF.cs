//using iText.Layout;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System;
using System.Windows.Forms;
//using iText.Kernel.Pdf;

using iText.Layout.Element;
using iText.Layout.Properties;
using iText.Kernel.Font;
using iText.IO.Font.Constants;
using System.IO;


//using System.Windows. Documents;
//using System.Windows.Input;
//using System.Windows.Media;
//using System.Windows.Media.Imaging;
//using System.Windows.Navigation;
//using System.Windows.Shapes;
//using System.Xml.Linq;

using iTextSharp.text;
using iTextSharp.text.pdf;
//using iTextSharp.text.pdf;
//using Image = iTextSharp.text.Image;
//using System.Windows.Markup;
//using System.Windows.Documents;
//using Paragraph = iTextSharp.text.Paragraph;


namespace EcsportManagementKurs
{
    internal class VigruzPDF
    {
       static public void Maker(SqlDataReader reader, string Name)
        {
             
                string connectionString = @"Data Source=pcsqlstud01;Initial Catalog=10220468;Integrated Security=True;Encrypt=False";

                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();

                Document pdfDoc = new Document();

                PdfWriter.GetInstance(pdfDoc, new FileStream($"C:\\Users\\10220468\\Documents\\{Name}.pdf", FileMode.Create));
                pdfDoc.Open();

                PdfPTable pdfTable = new PdfPTable(reader.FieldCount);

                // Заголовки колонок
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    pdfTable.AddCell(new Phrase(reader.GetName(i)));
                }

                while (reader.Read())
                {
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        pdfTable.AddCell(new Phrase(reader[i].ToString()));
                    }
                }

                pdfDoc.Add(pdfTable);
                pdfDoc.Close();
                connection.Close();
            

        }
    }
}
