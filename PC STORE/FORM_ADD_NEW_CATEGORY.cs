using System;
using System.Windows.Forms;

namespace PC_STORE
{
    public partial class FORM_ADD_NEW_CATEGORY : Form
    { 
        public FORM_ADD_NEW_CATEGORY()
        {
            InitializeComponent();

        }
        private void BTN_ADD_CATEGORY_Click(object sender, EventArgs e)//הכנסת קטגוריה
        {
            DB db = new DB();
            Category category = new Category();

            if (TB_CATEGORY_NAME.Text != string.Empty)
            {
                db.OpenConnection();
                category.InsertCategory(TB_CATEGORY_NAME.Text);
                MessageBox.Show("קטגוריה חדשה נוצרה בהצלחה", "יצירת קטגוריה", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BTN_CANCEL_Click(object sender, EventArgs e)
        {
            Close();
        }



    }
}
