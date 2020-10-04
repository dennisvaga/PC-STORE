using System;
using System.Windows.Forms;

namespace PC_STORE
{
    public partial class FORM_MANAGE_CUSTOMER : Form
    {
        private Customer customer = new Customer();
        private Order order = new Order();

        public FORM_MANAGE_CUSTOMER()
        {
            InitializeComponent();
            DGV_CUSTOMERS.DataSource = customer.GetCustomers();

        }
        public void Load_LBL()
        {
            TB_ID_CUSTOMER.Text = DGV_CUSTOMERS.CurrentRow.Cells[0].Value.ToString();
            TB_FNAME.Text = DGV_CUSTOMERS.CurrentRow.Cells[1].Value.ToString();
            TB_LNAME.Text = DGV_CUSTOMERS.CurrentRow.Cells[2].Value.ToString();
            TB_TEL.Text = DGV_CUSTOMERS.CurrentRow.Cells[3].Value.ToString();
            TB_EMAIL.Text = DGV_CUSTOMERS.CurrentRow.Cells[4].Value.ToString();
        }
        private void FORM_MANAGE_CUSTOMER_Load(object sender, EventArgs e)
        {
            if (DGV_CUSTOMERS.Rows.Count != 0)
            {
                Load_LBL();
                int cc = Convert.ToInt32(DGV_CUSTOMERS.CurrentRow.Cells[0].Value.ToString());
                LBL_ORDER_COUNT.Text = order.GetCustomerOrdersCount(Convert.ToInt32(cc));
                LBL_ORDER_AMOUNT.Text = order.GetCustomerOrdersTotalAmount(Convert.ToInt32(cc));
                LBL_LAST_ORDER_DATE.Text = order.GetCustomerLastOrderDate(Convert.ToInt32(cc)).ToString();
            }
        }


        // add customer
        private void BTN_INSERT_CUSTOMER_Click(object sender, EventArgs e)
        {
            customer.InsertCustomer(TB_FNAME.Text, TB_LNAME.Text, TB_TEL.Text, TB_EMAIL.Text);
            MessageBox.Show("New Customer Inserted Successfully", "New Customer", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DGV_CUSTOMERS.DataSource = customer.GetCustomers();
        }

        // delete customer
        private void BTN_DELETE_CUSTOMER_Click(object sender, EventArgs e)
        {
            if (TB_ID_CUSTOMER.Text == string.Empty)
            {
                MessageBox.Show("Select The Costumer To Delete", "Delete A Customer", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("do you really want to delete this Customer", "Remove Customer", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    customer.DeleteCustomer(Convert.ToInt32(TB_ID_CUSTOMER.Text));
                    DGV_CUSTOMERS.DataSource = customer.GetCustomers();
                    MessageBox.Show("Customer Deleted Successfully", "Remove Customer");
                    TB_ID_CUSTOMER.Text = "";
                    TB_FNAME.Text = "";
                    TB_LNAME.Text = "";
                    TB_TEL.Text = "";
                    TB_EMAIL.Text = "";
                }
            }
        }

        // get selected customer info in textboxes

        private void DGV_CUSTOMERS_Click(object sender, EventArgs e)
        {
            TB_ID_CUSTOMER.Text = DGV_CUSTOMERS.CurrentRow.Cells[0].Value.ToString();
            TB_FNAME.Text = DGV_CUSTOMERS.CurrentRow.Cells[1].Value.ToString();
            TB_LNAME.Text = DGV_CUSTOMERS.CurrentRow.Cells[2].Value.ToString();
            TB_TEL.Text = DGV_CUSTOMERS.CurrentRow.Cells[3].Value.ToString();
            TB_EMAIL.Text = DGV_CUSTOMERS.CurrentRow.Cells[4].Value.ToString();
            LBL_ORDER_COUNT.Text = order.GetCustomerOrdersCount(Convert.ToInt32(DGV_CUSTOMERS.CurrentRow.Cells[0].Value.ToString()));
            LBL_ORDER_AMOUNT.Text = order.GetCustomerOrdersTotalAmount(Convert.ToInt32(DGV_CUSTOMERS.CurrentRow.Cells[0].Value.ToString()));
            LBL_LAST_ORDER_DATE.Text = order.GetCustomerLastOrderDate(Convert.ToInt32(DGV_CUSTOMERS.CurrentRow.Cells[0].Value.ToString()));
        }

        private void BTN_UPDATE_CUSTOMER_Click(object sender, EventArgs e)
        {
            if (TB_ID_CUSTOMER.Text == string.Empty)
            {
                MessageBox.Show("Select The Costumer To Update", "Select A Customer", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                customer.UpdateCustomer(Convert.ToInt32(TB_ID_CUSTOMER.Text), TB_FNAME.Text, TB_LNAME.Text, TB_TEL.Text, TB_EMAIL.Text);
                MessageBox.Show("Customer Updated Successfully", "Update Customer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DGV_CUSTOMERS.DataSource = customer.GetCustomers();
            }
        }

        private void BTN_RESET_Click(object sender, EventArgs e)
        {
            TB_ID_CUSTOMER.Text = "";
            TB_FNAME.Text = "";
            TB_LNAME.Text = "";
            TB_TEL.Text = "";
            TB_EMAIL.Text = "";
        }


    }
}
