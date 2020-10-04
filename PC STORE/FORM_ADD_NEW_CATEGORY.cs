using System;
using System.Windows.Forms;

namespace PC_STORE
{
    public partial class FORM_ADD_NEW_CATEGORY : Form
    {
        private DB db = new DB();
        private Category category = new Category();
        public FORM_ADD_NEW_CATEGORY()
        {
            InitializeComponent();

        }
        private void BTN_ADD_CATEGORY_Click(object sender, EventArgs e)
        {
            if (TB_CATEGORY_NAME.Text != string.Empty)
            {
                db.openConnection();
                category.InsertCategory(TB_CATEGORY_NAME.Text);
                MessageBox.Show("New Category Inserted Successfully", "Insert Category", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Enter Category Name");
            }
        }

        private void BTN_CANCEL_Click(object sender, EventArgs e)
        {
            Close();
        }



    }
}
