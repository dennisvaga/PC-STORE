using System;
using System.Windows.Forms;

namespace PC_STORE
{
    public partial class FORM_NEW_CUSTOMER : Form
    {
        Customer customer = new Customer();
        public FORM_NEW_CUSTOMER()
        {
            InitializeComponent();
        }


        private void BTN_ADD_CUSTOMER_Click(object sender, EventArgs e)
        {
            if (TB_FNAME.Text == string.Empty || TB_LNAME.Text == string.Empty || TB_TEL.Text == string.Empty || TB_EMAIL.Text == string.Empty)
            {
                MessageBox.Show("One Or More Fields Are Empty", "Empty Fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                customer.InsertCustomer(TB_FNAME.Text, TB_LNAME.Text, TB_TEL.Text, TB_EMAIL.Text);

                MessageBox.Show("Customer Added", "Add Customer", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BTN_CANCEL_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
