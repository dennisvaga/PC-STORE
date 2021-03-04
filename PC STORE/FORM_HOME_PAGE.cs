using System;
using System.Windows.Forms;

namespace PC_STORE
{
    public partial class FORM_HOME_PAGE : Form
    {
        public FORM_HOME_PAGE()
        {
            InitializeComponent();
            SINDE_PANEL.Height = BTN_NEW_ORDER.Height;
            SINDE_PANEL.Top = BTN_NEW_ORDER.Top;
            uC_MANAGE_ORDER1.BringToFront();
        }
        //כפתור מוצרים
        private void BTN_PRODUCTS_Click(object sender, EventArgs e)
        {
            SINDE_PANEL.Height = BTN_PRODUCTS.Height;
            SINDE_PANEL.Top = BTN_PRODUCTS.Top;
            uC_MANAGE_PRODUCT1.BringToFront();

        }
        //כפתור קטגוריות
        private void BTN_CATEGORIES_Click(object sender, EventArgs e)
        {
            SINDE_PANEL.Height = BTN_CATEGORIES.Height;
            SINDE_PANEL.Top = BTN_CATEGORIES.Top;
            uC_MANAGE_CATEGORIES1.BringToFront();
        }
        //כפתור לקוחות
        private void BTN_CUSTOMERS_Click(object sender, EventArgs e)
        {
            SINDE_PANEL.Height = BTN_CUSTOMERS.Height;
            SINDE_PANEL.Top = BTN_CUSTOMERS.Top;
            uC_MANAGE_CUSTOMERS1.BringToFront();
        }
        //כפתור הזמנה חדשה
        private void BTN_NEW_ORDER_Click(object sender, EventArgs e)
        {
            SINDE_PANEL.Height = BTN_NEW_ORDER.Height;
            SINDE_PANEL.Top = BTN_NEW_ORDER.Top;
            uC_MANAGE_ORDER1.BringToFront();
        }
        //כפתור יציאה מהמשמרת
        private void BTN_EXIT_SHIFT_Click(object sender, EventArgs e)
        {
            FORM_LOGIN flogin = new FORM_LOGIN();
            flogin.LBL_ENTER.Visible = false;
            flogin.LBL_EXIT.Visible = true;
            flogin.BTN_END_SHIFT.Visible = true;
            flogin.BTN_LOGIN_Click.Visible = false;
            this.Hide();
            flogin.ShowDialog();
            this.Close();
        }
        //כפתור ניהול עובדים
        private void BTN_EMPLOYEE_MANAGMENT_Click(object sender, EventArgs e)
        {
            SINDE_PANEL.Height = BTN_EMPLOYEE_MANAGMENT.Height;
            SINDE_PANEL.Top = BTN_EMPLOYEE_MANAGMENT.Top;
            uC_MANAGE_EMPLOYEE1.BringToFront();
        }
        //כפתור משמרות עובדים
        private void BTN_EMPLOYEE_SHIFTS_Click(object sender, EventArgs e)
        {
            SINDE_PANEL.Height = BTN_EMPLOYEE_SHIFTS.Height;
            SINDE_PANEL.Top = BTN_EMPLOYEE_SHIFTS.Top;
            uC_EMPLOYEE_SHIFTS1.BringToFront();
        }
        //כפתור כל ההזמנות
        private void BTN_ALL_ORDERS_Click(object sender, EventArgs e)
        {
            SINDE_PANEL.Top = BTN_ALL_ORDERS.Top;
            SINDE_PANEL.Height = BTN_ALL_ORDERS.Height;
            uC_ALL_ORDERS1.BringToFront();
        }
        //כפתור הכנסות של החנות
        private void BTN_INCOME_Click(object sender, EventArgs e)
        {
            SINDE_PANEL.Top = BTN_INCOME.Top;
            SINDE_PANEL.Height = BTN_INCOME.Height;
            uC_INCOME1.BringToFront();
        }
    }
}
