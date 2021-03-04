using System;
using System.Windows.Forms;

namespace PC_STORE
{
    public partial class UC_MANAGE_EMPLOYEE : UserControl
    {
        public UC_MANAGE_EMPLOYEE()
        {
            InitializeComponent();
            Employees employee = new Employees();
            DGV_EMPLOYEE.DataSource = employee.GetEmployee();
            DGV_EMPLOYEE.Columns[0].HeaderText = "תעודת זהות";
            DGV_EMPLOYEE.Columns[1].HeaderText = "שם משתמש";
            DGV_EMPLOYEE.Columns[2].HeaderText = "סיסמא";
            DGV_EMPLOYEE.Columns[3].HeaderText = "שם פרטי";
            DGV_EMPLOYEE.Columns[4].HeaderText = "שם משפחה";
            DGV_EMPLOYEE.Columns[5].HeaderText = "טלפון";
            DGV_EMPLOYEE.Columns[6].HeaderText = "אימייל";
        }
        //כפתור עובד חדש
        private void BTN_NEW_USER_Click(object sender, EventArgs e)
        {
            Employees employee = new Employees();
            FORM_NEW_EMPLOYEE fnu = new FORM_NEW_EMPLOYEE();
            fnu.ShowDialog();
            DGV_EMPLOYEE.DataSource = employee.GetEmployee();
        }
        //כפתור עידכון עובד
        private void BTN_UPDATE_Click(object sender, EventArgs e)
        {
            Employees employee = new Employees();
            if (TB_ID.Text != string.Empty)
            {
                employee.UpdateEmployee(TB_USERNAME.Text, TB_FIRSTNAME.Text, TB_LASTNAME.Text, TB_PASSWORD.Text, TB_TEL.Text, TB_EMAIL.Text, Convert.ToInt32(TB_ID.Text));
                MessageBox.Show("המשתמש עודכן בהצלחה", "עידכון משתמש", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DGV_EMPLOYEE.DataSource = employee.GetEmployee();
            }

            else
                MessageBox.Show("בחרו את המשתמש אותו תרצו לעדכן");
        }
        //כפתור מחיקת עובד
        private void BTN_DELETE_Click(object sender, EventArgs e)
        {
            Employees employee = new Employees();
            if (TB_ID.Text != string.Empty)
            {
                if (MessageBox.Show("האם למחוק את המשתמש?", "מחיקת משתמש", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    employee.ChangeIdWhenDelEmp(Convert.ToInt32(TB_ID.Text)); //change emp_id in order_details when emp is deleted
                    employee.BackupDeletedEmployee(Convert.ToInt32(TB_ID.Text)); 


                    employee.DeleteEmployee(Convert.ToInt32(TB_ID.Text));
                    MessageBox.Show("המשתמש הוסר בהצלחה", "הסרת משתמש", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DGV_EMPLOYEE.DataSource = employee.GetEmployee();
                }
            }
            else
                MessageBox.Show("בחרו את העובד אותו תרצה להסיר");
        }
        //טעינת תיבות טקסט כאשר לוחצים על העובד
        private void DGV_EMPLOYEE_Click(object sender, EventArgs e)
        {
            TB_ID.Text = DGV_EMPLOYEE.CurrentRow.Cells[0].Value.ToString();
            TB_USERNAME.Text = DGV_EMPLOYEE.CurrentRow.Cells[1].Value.ToString();
            TB_FIRSTNAME.Text = DGV_EMPLOYEE.CurrentRow.Cells[3].Value.ToString();
            TB_LASTNAME.Text = DGV_EMPLOYEE.CurrentRow.Cells[4].Value.ToString();
            TB_TEL.Text = DGV_EMPLOYEE.CurrentRow.Cells[5].Value.ToString();
            TB_PASSWORD.Text = DGV_EMPLOYEE.CurrentRow.Cells[2].Value.ToString();
            TB_EMAIL.Text = DGV_EMPLOYEE.CurrentRow.Cells[6].Value.ToString();
        }


    }
}
