using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace PC_STORE
{
    public partial class UC_ALL_ORDERS : UserControl
    {
        public UC_ALL_ORDERS()
        {
            InitializeComponent();
        }
        private void UC_ALL_ORDERS_Load(object sender, EventArgs e)//טעינה של כל ההזמנות
        {
            Order order = new Order();
            DGV_ALL_ORDERS.DataSource = order.GetAllOrders();
            DGV_ALL_ORDERS.Columns[0].HeaderText = "מ'ס הזמנה";
            DGV_ALL_ORDERS.Columns[1].HeaderText = "מ'ס לקוח";
            DGV_ALL_ORDERS.Columns[2].HeaderText = "שם הלקוח";
            DGV_ALL_ORDERS.Columns[3].HeaderText = "שם משפחה";
            DGV_ALL_ORDERS.Columns[4].HeaderText = "תאריך הזמנה";
        }
        public void BTN_PRINT_ORDER_Click(object sender, EventArgs e)//כפתור הדפס
        {
            Order order = new Order();
            string ordId = DGV_ALL_ORDERS.CurrentRow.Cells[0].Value.ToString();
            string totalOrderAmount = order.GetOrderTotalAmount
                (Convert.ToInt32(DGV_ALL_ORDERS.CurrentRow.Cells[0].Value.ToString())).Rows[0][0].ToString();
            string ordDate = DGV_ALL_ORDERS.CurrentRow.Cells[4].Value.ToString();
            DataTable SelectedOrderDetails = order.GetOrderDetails
                (Convert.ToInt32(DGV_ALL_ORDERS.CurrentRow.Cells[0].Value.ToString()));
            string custFullName = DGV_ALL_ORDERS.CurrentRow.Cells[2].Value.ToString()
                + " " + DGV_ALL_ORDERS.CurrentRow.Cells[3].Value.ToString();

            Document Doc = new Document(PageSize.A4, 25, 25, 30, 30);

            using (FileStream fs = new FileStream
                (@"C:\Users\Haimv\Desktop\" + "הזמנה" + ordId + ".pdf", FileMode.Create, FileAccess.Write, FileShare.Read))
            {
                PdfWriter writer = PdfWriter.GetInstance(Doc, fs);
                Doc.Open();
                Doc.NewPage();
                string ARIALUNI_TFF = Path.Combine(@"C:\arial.tff location here", "ARIAL.TTF");
                BaseFont bf = BaseFont.CreateFont(ARIALUNI_TFF, BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);
                Font f = new Font(bf, 8);
                PdfPTable T = new PdfPTable(1);
                T.DefaultCell.BorderWidth = 0;
                T.RunDirection = PdfWriter.RUN_DIRECTION_RTL;

                //----------------------------------------------------------------------
                //הוספת תמונה
                Image image = Image.GetInstance("C:\\Logo location here\\logo_transparent.png");
                image.ScaleAbsolute(100, 100);
                image.Alignment = Element.ALIGN_CENTER;
                Doc.Add(image);

                DateTime orderdate = Convert.ToDateTime(ordDate);
                PdfPCell datecustomer = new PdfPCell(new Phrase
                    ("תאריך הזמנה :" + orderdate.ToString("dd/MM/yyyy HH:mm ") + "\n" + "שם מלא :" + custFullName, f))
                {
                    HorizontalAlignment = 2,
                };
                datecustomer.Border = 0;
                T.AddCell(datecustomer);


                PdfPCell cellHeader = new PdfPCell(new Phrase("קוד הזמנה:" + ordId, f))
                {
                    HorizontalAlignment = 1,
                    ExtraParagraphSpace = 10
                };
                T.AddCell(cellHeader);

                for (int i = 0; i < SelectedOrderDetails.Rows.Count; i++)
                {
                    PdfPCell cell1 = new PdfPCell();
                    cell1.AddElement(new Phrase("קוד מוצר:" + " " + SelectedOrderDetails.Rows[i][0].ToString(), f));
                    cell1.AddElement(new Phrase("שם המוצר:" + " " + SelectedOrderDetails.Rows[i][1].ToString(), f));
                    cell1.AddElement(new Phrase("כמות:" + " " + SelectedOrderDetails.Rows[i][2].ToString(), f));
                    cell1.AddElement(new Phrase("מחיר:" + " " + SelectedOrderDetails.Rows[i][3].ToString(), f));
                    cell1.AddElement(new Phrase("כמות x מחיר:" + " " + SelectedOrderDetails.Rows[i][4].ToString(), f));
                    T.AddCell(cell1);
                }
                double total = Convert.ToDouble(totalOrderAmount);               
                PdfPCell cellAmount = new PdfPCell(new Phrase("מחיר אחרי מע\"מ:" + " " + String.Format("{0:0.00}", (total) + " ₪"), f))
                {
                    HorizontalAlignment = 2,
                    ExtraParagraphSpace = 10
                };
                T.AddCell(cellAmount);

                //------------------------------------------------------------------------
                Doc.Add(T);
                Doc.Close();
                MessageBox.Show("ההזמנה נוצרה בהצלחה");
            }
        }
        //פותח את הפירוט של של ההמזנה שבחרנו
        private void DGV_ALL_ORDERS_DoubleClick(object sender, EventArgs e)
        {
            Order order = new Order();
            FORM_CUSTOMER_ORDERS fco = new FORM_CUSTOMER_ORDERS();
            fco.DGV_CUSTOMER_ORDERS.DataSource = order.GetCustomerOrders(Convert.ToInt32(DGV_ALL_ORDERS.CurrentRow.Cells[1].Value));
            fco.LBL_CUSTOMER.Text =
                "לקוח:" + DGV_ALL_ORDERS.CurrentRow.Cells[2].Value.ToString() + " " + DGV_ALL_ORDERS.CurrentRow.Cells[3].Value.ToString();
            fco.ShowDialog();
        }
        //חיפוש הזמנה
        private void BTN_SEARCH_Click(object sender, EventArgs e)
        {
            Order order = new Order();
            DGV_ALL_ORDERS.DataSource = order.SearchOrder(TB_SEARCH.Text);

        }
    }
}
