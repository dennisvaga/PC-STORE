using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace PC_STORE
{
    public partial class FORM_NEW_EMPLOYEE : Form
    {
        public FORM_NEW_EMPLOYEE()
        {
            InitializeComponent();
        }


        private void BTN_ADD_EMPLOYEE_Click(object sender, EventArgs e)//הוספת עובד
        {
            Employees employee = new Employees();
            CheckClass check = new CheckClass();
            Regex regex = new Regex(@"^\d+$");//רק מספרים

            if (TB_ID.Text == string.Empty || TB_USERNAME.Text == string.Empty )
                MessageBox.Show("אחד או יותר מהשדות ריקים", "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);

            else if (!(regex.Match(TB_TEL.Text).Success) || !(regex.Match(TB_ID.Text).Success))
                MessageBox.Show("טלפון ותז חייב להכין רק מספרים", "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);

            else if (check.IsValidEmail(TB_EMAIL.Text) == false)
                MessageBox.Show("אימייל לא תקין", "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);

            else
            {
                int checkid = check.CheckId(TB_ID.Text);
                if (checkid == 1)
                {
                    employee.InsertEmployee(Convert.ToInt32(TB_ID.Text), TB_USERNAME.Text, TB_FIRSTNAME.Text, TB_LASTNAME.Text, TB_PASSWORD.Text, TB_TEL.Text, TB_EMAIL.Text);
                    MessageBox.Show("משתמש חדש נוצר בהצלחה", "משתמש חדש", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("תעודת זהות לא תקין");
            }
        }

        private void BTN_CANCEL_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
