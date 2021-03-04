using System;
using System.Data;
using System.Windows.Forms;

namespace PC_STORE
{
    public partial class FORM_LOGIN : Form
    {
        public FORM_LOGIN()
        {
            InitializeComponent();
            LBL_ENTER.Visible = true;
            LBL_EXIT.Visible = false;
        }

        private void BTN_LOGIN_Click_Click(object sender, EventArgs e)//כניסה למערכת
        {
            Login log = new Login();
            Employees employee = new Employees();

            DataTable table = log.login(TB_USERNAME.Text, TB_PASSWORD.Text);
            if (table.Rows.Count > 0)
            {
                if (table.Rows[0][3].ToString() == "admin")
                {
                    this.Hide();
                    FORM_HOME_PAGE fhp = new FORM_HOME_PAGE();
                    fhp.BTN_EXIT_SHIFT.Visible = false;//אם המשתמש אדמין כפתור יציאה לא יופיעה
                    fhp.Show();
                }
                else
                {
                    this.Hide();
                    FORM_HOME_PAGE FH = new FORM_HOME_PAGE();
                    FH.BTN_EMPLOYEE_MANAGMENT.Visible = false;//אם המשתמש לא אדמין כפתור יוזרים לא יופיעה
                    FH.BTN_EMPLOYEE_SHIFTS.Visible = false;
                    FH.BTN_INCOME.Visible = false;
                    FH.Show();
                    DateTime check = employee.GetEmployeeLastEnterShiftDate(Convert.ToInt32(table.Rows[0][0]));

                    if (check.Date != DateTime.Today)
                        employee.InsertEmployeeStartShift(Convert.ToInt32(table.Rows[0][0]), DateTime.Now);

                    else if (check.Date.Year == 1999)//בדיקה אם המשתמש בכלל לא נכנס היום למשמרת
                        employee.InsertEmployeeStartShift(Convert.ToInt32(table.Rows[0][0]), DateTime.Now);
                }
            }
            else
                MessageBox.Show("שם המשתמש או הסיסמא לא נכונים");
        }
        private void BTN_END_SHIFT_Click(object sender, EventArgs e)//סיום משמרת
        {
            Login log = new Login();
            Employees employee = new Employees();

            DataTable table = log.login(TB_USERNAME.Text, TB_PASSWORD.Text);
            if (table.Rows.Count > 0)
            {
                employee.InsertEmployeeEndShift(employee.GetEmployeeLastEnterShiftID(Convert.ToInt32(table.Rows[0][0])), DateTime.Now);
                Close();
                MessageBox.Show("!יציאתך נקלטה בהצלחה");
            }
            else
                MessageBox.Show("שם המשתמש או הסיסמא לא נכונים");
        }

        private void LB_CLOSE_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CB_PASSWORD_CheckedChanged(object sender, EventArgs e)//להראות סיסמא או לא
        {
            TB_PASSWORD.PasswordChar = CB_PASSWORD.Checked ? '\0' : '*';
        }
    }
}
