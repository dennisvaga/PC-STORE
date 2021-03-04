using System;
using System.Data;
using System.Windows.Forms;

namespace PC_STORE
{
    public partial class FORM_CUSTOMER_ORDERS : Form
    {
        public FORM_CUSTOMER_ORDERS()
        {
            InitializeComponent();

        }
        
        private void CheckGntee()//בדיקת אחריות
        {
            for (int i = 0; i < DGV_CUSTOMER_DETAILS.Rows.Count; i++)
            {
                DateTime OrderDate = Convert.ToDateTime(DGV_CUSTOMER_DETAILS.Rows[i].Cells[6].Value);//תאריך קנייה
                DateTime GnteeEnd = OrderDate.AddMonths(Convert.ToInt32(DGV_CUSTOMER_DETAILS.Rows[i].Cells[5].Value));//מוסיפים את החודשים של האחריות
                DateTime today = DateTime.Now;

                long diffTicks = (GnteeEnd - today).Ticks;
                if (diffTicks > 0)
                    DGV_CUSTOMER_DETAILS.Rows[i].Cells[7].Value = "כן";
                else
                    DGV_CUSTOMER_DETAILS.Rows[i].Cells[7].Value = "לא";

            }
        }
        private void LoadHeaders()//משנה כותרות
        {
            DGV_CUSTOMER_DETAILS.AutoGenerateColumns = false;
            DGV_CUSTOMER_DETAILS.Columns[0].HeaderText = "קוד מוצר";
            DGV_CUSTOMER_DETAILS.Columns[1].HeaderText = "שם המוצר";
            DGV_CUSTOMER_DETAILS.Columns[2].HeaderText = "כמות";
            DGV_CUSTOMER_DETAILS.Columns[3].HeaderText = "מחיר המוצר";
            DGV_CUSTOMER_DETAILS.Columns[4].HeaderText = "סה\"כ מחיר";
            DGV_CUSTOMER_DETAILS.Columns[5].Visible = false;
            DGV_CUSTOMER_DETAILS.Columns[6].Visible = false;
            DataGridViewTextBoxColumn dgvGntee = new DataGridViewTextBoxColumn
            {
                HeaderText = "באחריות"
            };
            DGV_CUSTOMER_DETAILS.Columns.Add(dgvGntee);
            DGV_CUSTOMER_DETAILS.Columns[7].HeaderText = "באחריות";
        }

        private void FORM_CUSTOMER_ORDERS_Load(object sender, EventArgs e)
        {
            Order order = new Order();
            DGV_CUSTOMER_ORDERS.Columns[0].HeaderText = "מ'ס הזמנה";
            DGV_CUSTOMER_ORDERS.Columns[1].HeaderText = "תאריך הזמנה";

            //מראה את ההזמנות של הלקוח
            if (DGV_CUSTOMER_ORDERS.Rows.Count != 0)
            {
                int orderId = Convert.ToInt32(DGV_CUSTOMER_ORDERS.CurrentRow.Cells[0].Value);
                DataTable details = order.GetOrderDetails(orderId);
                DGV_CUSTOMER_DETAILS.DataSource = details;

                if (details.Rows.Count != 0)
                {
                    LoadHeaders();
                    CheckGntee();
                }
            }
        }   

        //מראה את המוצרים של הלקוח הנבחר
        private void DGV_CUSTOMER_ORDERS_Click(object sender, EventArgs e)
        {
            Order order = new Order();
            int orderId = Convert.ToInt32(DGV_CUSTOMER_ORDERS.CurrentRow.Cells[0].Value);
            DataTable details = order.GetOrderDetails(orderId);
            if (details.Rows.Count != 0)
            {
                DGV_CUSTOMER_DETAILS.DataSource = details;
                CheckGntee();
            }
        }
    }
}