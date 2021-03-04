using System;
using System.Data;
using System.Windows.Forms;


namespace PC_STORE
{
    public partial class UC_MANAGE_CATEGORIES : UserControl
    {
        public UC_MANAGE_CATEGORIES()
        {
            DB db = new DB();
            InitializeComponent();

            DataTable table = db.GetData("spr_get_categories", null);
            DGV_CATEGORIES.DataSource = table;
            DGV_CATEGORIES.Columns[0].HeaderText = "קוד קטגוריה";
            DGV_CATEGORIES.Columns[1].HeaderText = "שם";
        }
        //כפתור להכניס קטגוריה
        private void BTN_INSERT_CTG_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            Category category = new Category();

            db.OpenConnection();
            if (TB_CATG_NAME.Text != string.Empty)
            {
                DataTable table = category.CheckDup(TB_CATG_NAME.Text);
                if (table.Rows.Count == 0)
                {
                    category.InsertCategory(TB_CATG_NAME.Text);
                    MessageBox.Show("קטגוריה חדשה נוצרה בהצלחה", "יצירת קטגוריה", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DGV_CATEGORIES.DataSource = category.GetCategories();
                }
                else
                    MessageBox.Show("הקטגוריה כבר קיימת", "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("השדה ריק", "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        //כפתור עידכון קטגוריה
        private void BTN_UPDATE_CTG_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            Category category = new Category();

            if (TB_CATG_ID.Text != string.Empty || TB_CATG_NAME.Text != string.Empty)
            {
                try
                {
                    db.OpenConnection();
                    category.UpdateCategory(Convert.ToInt16(TB_CATG_ID.Text), TB_CATG_NAME.Text);
                    MessageBox.Show("קטגוריה עודכנה בהצלחה", "עידכון קטגוריה", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DGV_CATEGORIES.DataSource = category.GetCategories();
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("השדה ריק", "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //כפתור מחיקת קטגוריה
        private void BTN_DELETE_CTG_Click(object sender, EventArgs e)
        {
            Category category = new Category();

            if (TB_CATG_ID.Text != string.Empty)
            {
                if (MessageBox.Show("למחוק את הקטגוריה?", "הסרת קטגוריה", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        category.DeleteCategory(Convert.ToInt32(TB_CATG_ID.Text));
                        DataTable table = category.GetCategories();
                        DGV_CATEGORIES.DataSource = table;
                        MessageBox.Show("הקטגוריה הוסרה בהצלחה", "הסרת קטגוריה");
                        TB_CATG_ID.Text = "";
                        TB_CATG_NAME.Text = "";
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            else
                MessageBox.Show("שדה ריק", "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        //טעינה של קטגוריה הנבחרת לתיבות טקסט
        private void DGV_CATEGORIES_Click(object sender, EventArgs e)
        {
            TB_CATG_ID.Text = DGV_CATEGORIES.CurrentRow.Cells[0].Value.ToString();
            TB_CATG_NAME.Text = DGV_CATEGORIES.CurrentRow.Cells[1].Value.ToString();
        }

    }
}
