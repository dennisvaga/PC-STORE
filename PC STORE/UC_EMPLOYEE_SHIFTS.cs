using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.IO;
using System.Windows.Forms;

namespace PC_STORE
{
    public partial class UC_EMPLOYEE_SHIFTS : UserControl
    {
        public UC_EMPLOYEE_SHIFTS()
        {
            InitializeComponent();
        }
        //כפתור להראות את המשמרות של העובד
        private void BTN_SHOW_SHIFTS_Click(object sender, EventArgs e)
        {
            Employees employee = new Employees();
            if (TB_WORKER_ID.Text == string.Empty)
                MessageBox.Show("הכנס מספר עובד", "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);

            else
            {
                DGV_SHIFTS.DataSource = employee.GetEmployeeShiftsFromDateToDate
                    (Convert.ToInt32(TB_WORKER_ID.Text), dateTimePicker1.Value.ToString("yyyy/MM/dd"), dateTimePicker2.Value.ToString("yyyy/MM/dd"));

                DGV_SHIFTS.Columns[0].HeaderText = "מ'ס עובד";
                DGV_SHIFTS.Columns[1].HeaderText = "שם פרטי";
                DGV_SHIFTS.Columns[2].HeaderText = "שם משפחה";
                DGV_SHIFTS.Columns[3].HeaderText = "טלפון";
                DGV_SHIFTS.Columns[4].HeaderText = "אימייל";
                DGV_SHIFTS.Columns[5].HeaderText = "תחילת משמרת";
                DGV_SHIFTS.Columns[6].HeaderText = "סוף משמרת";

                LBL_SELL_COUNT.Text = employee.GetEmployeeSellsCount(Convert.ToInt32(TB_WORKER_ID.Text));
                LBL_SELL_COUNT_MONTH.Text = employee.GetEmployeeSellsMonthCount
                    (Convert.ToInt32(TB_WORKER_ID.Text), dateTimePicker1.Value.ToString("yyyy/MM/dd"), dateTimePicker2.Value.ToString("yyyy/MM/dd"));
                LBL_LAST_SELL_DATE.Text = employee.GetEmployeeLastSellDate(Convert.ToInt32(TB_WORKER_ID.Text));
            }
        }
        //כפתור יצירת דוח שעות של העובד
        private void BTN_PRINT_Click(object sender, EventArgs e)
        {
            if (TB_WORKER_ID.Text == string.Empty)
                MessageBox.Show("הכנס מספר עובד", "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);

            if (DGV_SHIFTS.Rows.Count == 0)
                MessageBox.Show("טבלת המשמרות ריקה", "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);

            else
            {
                Document Doc = new Document(PageSize.A4, 25, 25, 30, 30);

                using (FileStream fs = new FileStream(@"C:\Users\Haimv\Desktop\" + "עובד "
                    + DGV_SHIFTS.Rows[0].Cells[0].Value + ".pdf", FileMode.Create, FileAccess.Write, FileShare.Read))
                {
                    PdfWriter writer = PdfWriter.GetInstance(Doc, fs);
                    Doc.Open();
                    Doc.NewPage();
                    string ARIALUNI_TFF = Path.Combine(@"C:\Users\Haimv\Desktop\PC STORE", "ARIAL.TTF");
                    BaseFont bf = BaseFont.CreateFont(ARIALUNI_TFF, BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);
                    Font f1 = new Font(bf, 8);
                    PdfPTable Table = new PdfPTable(3);
                    PdfPTable Table1 = new PdfPTable(1);

                    Table.RunDirection = PdfWriter.RUN_DIRECTION_RTL;
                    Table1.RunDirection = PdfWriter.RUN_DIRECTION_RTL;
                    Table1.DefaultCell.BorderWidth = 0;

                    //-------------------------------------------------------------------------
                    //הוספת תמונה
                    Image image = Image.GetInstance("C:\\Users\\Haimv\\Desktop\\PC STORE\\Design\\Logo\\logo_transparent.png");
                    image.ScaleAbsolute(100, 100);
                    image.Alignment = Element.ALIGN_CENTER;
                    Doc.Add(image);

                    PdfPCell employee = new PdfPCell(new Phrase("תאריך הדפסה:" + " " + DateTime.Now.ToString("dd/MM/yyyy HH:mm ")
                        + "\n" + "שם מלא:" + " " + DGV_SHIFTS.Rows[0].Cells[1].Value + " " + DGV_SHIFTS.Rows[0].Cells[2].Value, f1))
                    {
                        ExtraParagraphSpace = 5,
                        HorizontalAlignment = 2,
                    };
                    employee.Border = 0;
                    Table1.AddCell(employee);
                    Doc.Add(Table1);

                    Table.AddCell(new Phrase("תאריך משמרת", f1));
                    Table.AddCell(new Phrase("תחילת משמרת", f1));
                    Table.AddCell(new Phrase("סיום משמרת", f1));


                    for (int i = 0; i < DGV_SHIFTS.Rows.Count; i++)
                    {
                        var date = Convert.ToDateTime(DGV_SHIFTS.Rows[i].Cells[5].Value).ToString("dd/MM/yyy");
                        var startshift = Convert.ToDateTime(DGV_SHIFTS.Rows[i].Cells[5].Value).ToString("H:mm");
                        var endshift = Convert.ToDateTime(DGV_SHIFTS.Rows[i].Cells[6].Value).ToString("H:mm");
                        Table.AddCell(new Phrase(date, f1));
                        Table.AddCell(new Phrase(startshift, f1));
                        Table.AddCell(new Phrase(endshift, f1));
                    }
                    Doc.Add(Table);


                    //חישוב שעות העבודה של העובד
                    TimeSpan totalhours = new TimeSpan();
                    for (int i = 0; i < DGV_SHIFTS.Rows.Count; i++)
                        totalhours += Convert.ToDateTime(DGV_SHIFTS.Rows[i].Cells[6].Value) - Convert.ToDateTime(DGV_SHIFTS.Rows[i].Cells[5].Value);

                    Table1.DeleteLastRow();
                    PdfPCell cellAmount = new PdfPCell
                        (new Phrase("סה\"כ שעות עבודה:" + " " + String.Format("{0:0.00}", Convert.ToDecimal(totalhours.TotalHours)), f1))
                    {
                        HorizontalAlignment = 2,
                        ExtraParagraphSpace = 10
                    };
                    cellAmount.Border = 0;
                    Table1.AddCell(cellAmount);
                    Doc.Add(Table1);

                    //---------------------------------------------------------
                    Doc.Close();
                    MessageBox.Show("דוח השעות נוצר בהצלחה");
                }
            }
        }
    }

}