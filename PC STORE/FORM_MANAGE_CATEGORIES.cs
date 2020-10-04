using System;
using System.Data;
using System.Windows.Forms;

namespace PC_STORE
{
    public partial class FORM_MANAGE_CATEGORIES : Form
    {
        DB db = new DB();
        Category category = new Category();
        Product product = new Product();
        DataTable table = new DataTable();

        public FORM_MANAGE_CATEGORIES()
        {
            InitializeComponent();

            table = db.getData("spr_category_products", null);
            DGV_CATEGORIES.DataSource = table;
        }
        
        private void BTN_INSERT_CTG_Click(object sender, EventArgs e)
        {
            db.openConnection();
            if (TB_CATG_NAME.Text != string.Empty)
            {
                category.InsertCategory(TB_CATG_NAME.Text);
                MessageBox.Show("New Category Inserted Successfully", "Insert Category", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DGV_CATEGORIES.DataSource = category.GetCategories();
            }
        }

        // update category
        private void BTN_UPDATE_CTG_Click(object sender, EventArgs e)
        {
            if (TB_CATG_ID.Text != string.Empty || TB_CATG_NAME.Text != string.Empty)
            {
                try
                {
                    db.openConnection();
                    category.UpdateCategory(Convert.ToInt16(TB_CATG_ID.Text), TB_CATG_NAME.Text);
                    MessageBox.Show("Category Updated Successfully", "Update Category", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DGV_CATEGORIES.DataSource = category.GetCategories();
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Empty Data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // button delete category
        private void BTN_DELETE_CTG_Click(object sender, EventArgs e)
        {
            if (TB_CATG_ID.Text != string.Empty)
            {
                if (MessageBox.Show("do you really want to delete this Category", "Remove Category", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        category.DeleteCategory(Convert.ToInt32(TB_CATG_ID.Text));
                        table = category.GetCategories();
                        DGV_CATEGORIES.DataSource = table;
                        MessageBox.Show("Category Deleted Successfully", "Remove Category");
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
            {
                MessageBox.Show("Empty Id", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // show datagridview selected row data in textboxes
        private void DGV_CATEGORIES_Click(object sender, EventArgs e)
        {
                TB_CATG_ID.Text = DGV_CATEGORIES.CurrentRow.Cells[0].Value.ToString();
                TB_CATG_NAME.Text = DGV_CATEGORIES.CurrentRow.Cells[1].Value.ToString();
        }

        // show products exist i the categorie selected
        private void DGV_CATEGORIES_DoubleClick(object sender, EventArgs e)
        {
            FORM_PRODUCTS_IN_CATEGORIES fpinc = new FORM_PRODUCTS_IN_CATEGORIES();
            fpinc.LBL_CATEGORY.Text = DGV_CATEGORIES.CurrentRow.Cells[1].Value.ToString();
            int val=Int32.Parse(DGV_CATEGORIES.CurrentRow.Cells[0].Value.ToString());
            fpinc.DGV_PRODUCTS_IN_CATEGORY.DataSource = product.GetProductsByCategory(val);
            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            imageColumn = (DataGridViewImageColumn)fpinc.DGV_PRODUCTS_IN_CATEGORY.Columns[4];
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Stretch;
            fpinc.DGV_PRODUCTS_IN_CATEGORY.AllowUserToAddRows = false;
            fpinc.DGV_PRODUCTS_IN_CATEGORY.RowTemplate.Height = 60;
            fpinc.ShowDialog();
        }
 
    }
}
