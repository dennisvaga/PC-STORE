using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace PC_STORE
{
    public partial class FORM_ALL_ORDERS : Form
    {
        private Order order = new Order();
        public FORM_ALL_ORDERS()
        {
            InitializeComponent();
        }

        // Print The Selected Order in PDF File Using iTextSharp
        private void BTN_PRINT_ORDER_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(@"C:\Users\Haimv\Desktop\Printed_Order.pdf", FileMode.Create);
            Document document = new Document(PageSize.A4, 25, 25, 30, 30);
            PdfWriter writer = PdfWriter.GetInstance(document, fs);
            document.AddAuthor("PC_STORE");
            document.AddCreator("Haim Vaga");
            document.AddKeywords("Order");
            document.AddSubject("Customer Order");
            document.AddTitle("Order Details");

            // Open the document to enable you to write to the document
            document.Open();
            PdfPTable table = new PdfPTable(5);
            String totalOrderAmount = order.GetOrderTotalAmount(Convert.ToInt32(DGV_ALL_ORDERS.CurrentRow.Cells[0].Value.ToString())).Rows[0][0].ToString();
            string ordId = DGV_ALL_ORDERS.CurrentRow.Cells[0].Value.ToString();
            string ordDate = DGV_ALL_ORDERS.CurrentRow.Cells[3].Value.ToString();
            DataTable SelectedOrderDetails = order.GetOrderDetails(Convert.ToInt32(DGV_ALL_ORDERS.CurrentRow.Cells[0].Value.ToString()));
            PdfPCell cellHeader = new PdfPCell(new Phrase("Order " + ordId + " Details"))
            {
                Colspan = 5,
                HorizontalAlignment = 1,
                ExtraParagraphSpace = 20
            };
            table.AddCell(cellHeader);
            table.AddCell("Product Id");
            table.AddCell("Product Name");
            table.AddCell("Qty");
            table.AddCell("Price");
            table.AddCell("Qty x Price");

            for (int i = 0; i < SelectedOrderDetails.Rows.Count; i++)
            {
                table.AddCell(SelectedOrderDetails.Rows[i][0].ToString());
                table.AddCell(SelectedOrderDetails.Rows[i][1].ToString());
                table.AddCell(SelectedOrderDetails.Rows[i][2].ToString());
                table.AddCell(SelectedOrderDetails.Rows[i][3].ToString());
                table.AddCell(SelectedOrderDetails.Rows[i][4].ToString());
            }

            string custFullName = DGV_ALL_ORDERS.CurrentRow.Cells[1].Value.ToString() + " " + DGV_ALL_ORDERS.CurrentRow.Cells[2].Value.ToString();

            Paragraph prg = new Paragraph("Order Date : " + ordDate + "\n\n\nCustomer : " + custFullName + "\n" + "Order Id : " + ordId + "\n\n");

            PdfPCell cellAmount = new PdfPCell(new Phrase("Total Amount : " + totalOrderAmount))
            {
                HorizontalAlignment = 2,
                Colspan = 5
            };

            document.Add(prg);
            table.AddCell(cellAmount);

            document.Add(table);
            document.Close();
            writer.Close();
            fs.Close();
            MessageBox.Show("Report Generated Successfully");
        }
    }
}