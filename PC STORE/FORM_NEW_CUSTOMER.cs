using System;
using System.Data;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace PC_STORE
{
    public partial class FORM_NEW_CUSTOMER : Form
    {
        public FORM_NEW_CUSTOMER()
        {
            InitializeComponent();
        }
    
        private void BTN_ADD_CUSTOMER_Click(object sender, EventArgs e)//הוספת לקוח
        {
            Customer customer = new Customer();
            CheckClass check = new CheckClass();
            Regex regex = new Regex(@"^\d+$");//רק מספרים

            if (TB_ID.Text == string.Empty || TB_FNAME.Text == string.Empty || TB_LNAME.Text == string.Empty )
                MessageBox.Show("אחד או יותר מהשדות ריק", "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);

            else if (!(regex.Match(TB_TEL.Text).Success) || !(regex.Match(TB_ID.Text).Success))
                MessageBox.Show("טלפון ותז חייב להכין רק מספרים", "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);

            else if(check.IsValidEmail(TB_EMAIL.Text)==false)
                MessageBox.Show("אימייל לא תקין", "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);

            else
            {
                int checkid = check.CheckId(TB_ID.Text);
                DataTable table = customer.CheckDup(TB_ID.Text);
                if (checkid == 1 && table.Rows.Count == 0)
                {
                    customer.InsertCustomer(Convert.ToInt32(TB_ID.Text), TB_FNAME.Text, TB_LNAME.Text, TB_TEL.Text, TB_EMAIL.Text);
                    MessageBox.Show("המשתמש נוסף בהצלחה", "הוספת משתמש", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("תז לא תקין או כבר קיים במערכת", "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BTN_CANCEL_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
