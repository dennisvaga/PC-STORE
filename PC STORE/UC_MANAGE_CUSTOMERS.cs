using System;
using System.Windows.Forms;

namespace PC_STORE
{
    public partial class UC_MANAGE_CUSTOMERS : UserControl
    {
        public UC_MANAGE_CUSTOMERS()
        {
            InitializeComponent();
            Customer customer = new Customer();
            DGV_CUSTOMERS.DataSource = customer.GetCustomers();
            DGV_CUSTOMERS.Columns[0].HeaderText = "תז לקוח";
            DGV_CUSTOMERS.Columns[1].HeaderText = "שם פרטי";
            DGV_CUSTOMERS.Columns[2].HeaderText = "שם משפחה";
            DGV_CUSTOMERS.Columns[3].HeaderText = "טלפון";
            DGV_CUSTOMERS.Columns[4].HeaderText = "אימייל";
        }
        //טעינה התחלתית של תוויות ותיבות טקסט
        private void UC_MANAGE_CUSTOMERS_Load(object sender, EventArgs e)
        {
            if (DGV_CUSTOMERS.Rows.Count != 0)
                Load_TB();
        }
        //טעינת תיבות טקסט ותוויות
        public void Load_TB()
        {
            Order order = new Order();
            TB_ID_CUSTOMER.Text = DGV_CUSTOMERS.CurrentRow.Cells[0].Value.ToString();
            TB_FNAME.Text = DGV_CUSTOMERS.CurrentRow.Cells[1].Value.ToString();
            TB_LNAME.Text = DGV_CUSTOMERS.CurrentRow.Cells[2].Value.ToString();
            TB_TEL.Text = DGV_CUSTOMERS.CurrentRow.Cells[3].Value.ToString();
            TB_EMAIL.Text = DGV_CUSTOMERS.CurrentRow.Cells[4].Value.ToString();
            int cc = Convert.ToInt32(DGV_CUSTOMERS.CurrentRow.Cells[0].Value.ToString());
            LBL_ORDER_COUNT.Text = order.GetCustomerOrdersCount(Convert.ToInt32(cc));
            LBL_ORDER_AMOUNT.Text = String.Format("{0:0.00}", Convert.ToDecimal(order.GetCustomerOrdersTotalAmount(Convert.ToInt32(cc))));
            LBL_LAST_ORDER_DATE.Text = order.GetCustomerLastOrderDate(Convert.ToInt32(cc)).ToString();
        }
        //כפתור לקוח חדש
        private void BTN_INSERT_CUSTOMER_Click(object sender, EventArgs e)
        {
            FORM_NEW_CUSTOMER fnc = new FORM_NEW_CUSTOMER();
            fnc.ShowDialog();
        }
        //כפתור עידכון לקוח
        private void BTN_UPDATE_CUSTOMER_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            if (TB_ID_CUSTOMER.Text == string.Empty)
                MessageBox.Show("בחר לקוח לעדכן", "עידכון לקוח", MessageBoxButtons.OK, MessageBoxIcon.Error);

            else
            {
                if (MessageBox.Show("לעדכן את הלקוח?", "עידכון לקוח", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    customer.UpdateCustomer(Convert.ToInt32(TB_ID_CUSTOMER.Text), TB_FNAME.Text, TB_LNAME.Text, TB_TEL.Text, TB_EMAIL.Text);
                    MessageBox.Show("הלקוח עודכן בהצלחה", "עידכון לקוח", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DGV_CUSTOMERS.DataSource = customer.GetCustomers();
                }
            }
        }
        //כפתור מחיקת לקוח
        private void BTN_DELETE_CUSTOMER_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            if (TB_ID_CUSTOMER.Text == string.Empty)
                MessageBox.Show("בחר לקוח להסרה", "הסרת לקוח", MessageBoxButtons.OK, MessageBoxIcon.Error);

            else
            {
                if (MessageBox.Show("להסיר את הלקוח?", "הסרת לקוח", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    customer.DeleteCustomer(Convert.ToInt32(TB_ID_CUSTOMER.Text));
                    DGV_CUSTOMERS.DataSource = customer.GetCustomers();
                    MessageBox.Show("הלקוח הוסר בהצלחה", "הסרת לקוח");
                    TB_ID_CUSTOMER.Text = "";
                    TB_FNAME.Text = "";
                    TB_LNAME.Text = "";
                    TB_TEL.Text = "";
                    TB_EMAIL.Text = "";
                }
            }
        }
        //כפתור איפוס
        private void BTN_RESET_Click(object sender, EventArgs e)
        {
            TB_ID_CUSTOMER.Text = "";
            TB_FNAME.Text = "";
            TB_LNAME.Text = "";
            TB_TEL.Text = "";
            TB_EMAIL.Text = "";
        }
        // לחיצה על לקוח לטעינת התוויות ותיבות טקסט
        private void DGV_CUSTOMERS_Click(object sender, EventArgs e)
        {
            Load_TB();
        }
        //חיפוש לקוח
        private void BTN_SEARCH_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            DGV_CUSTOMERS.DataSource = customer.SearchCustomers(TB_SEARCH.Text);
        }
    }
}
