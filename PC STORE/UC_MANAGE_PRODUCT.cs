using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace PC_STORE
{
    public partial class UC_MANAGE_PRODUCT : UserControl
    {
        public UC_MANAGE_PRODUCT()
        {
            InitializeComponent();
            Category category = new Category();
            COMBO_CATEGORIES.DataSource = category.GetCategories();
            COMBO_CATEGORIES.DisplayMember = "CAT_NAME";
            COMBO_CATEGORIES.ValueMember = "CAT_ID";
            COMBO_CATEGORIES.SelectedIndex = 0;
            Load_hearders();
        }
        
        private void UC_MANAGE_PRODUCT_Load(object sender, EventArgs e)
        {
            COMBO_CATEGORIES_SelectedIndexChanged(null, null);
        }
        //טעינת כותרות בטבלת מוצרים
        private void Load_hearders()
        {
            DGV_PRODUCTS.Columns[0].HeaderText = "קוד מוצר";
            DGV_PRODUCTS.Columns[1].HeaderText = "שם";
            DGV_PRODUCTS.Columns[2].HeaderText = "כמות";
            DGV_PRODUCTS.Columns[3].HeaderText = "מחיר";
            DGV_PRODUCTS.Columns[4].HeaderText = "תמונה";
            DGV_PRODUCTS.Columns[5].HeaderText = "תיאור";
            DGV_PRODUCTS.Columns[6].HeaderText = "אחריות בחודשים";
            DGV_PRODUCTS.Columns[7].HeaderText = "קטגוריה";
            DataGridViewImageColumn imageColumn = (DataGridViewImageColumn)DGV_PRODUCTS.Columns[4];
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Stretch;
            DGV_PRODUCTS.RowTemplate.Height = 90;
        }
        //טעינת תיבה משולבת של קטגוריות
        private void COMBO_CATEGORIES_SelectedIndexChanged(object sender, EventArgs e)
        {
            Product product = new Product();
            if (product.GetProducts().Rows.Count != 0)//בדיקה האם יש מוצרים להראות 
            {
                Int32.TryParse(COMBO_CATEGORIES.SelectedValue.ToString(), out int val);
                DGV_PRODUCTS.DataSource = product.GetProductsByCategory(val);
            }
        }
        //כפתור עידכון מוצר
        private void BTN_UPDATE_PRODUCT_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            var tbl = product.GetProducts();
            if (tbl.Rows.Count != 0)
            {
                FORM_NEW_PRODUCT fnp = new FORM_NEW_PRODUCT();
                fnp.LBL_PID.Text = DGV_PRODUCTS.CurrentRow.Cells[0].Value.ToString();
                fnp.TB_NAME.Text = DGV_PRODUCTS.CurrentRow.Cells[1].Value.ToString();
                fnp.TB_QUANTITY.Text = DGV_PRODUCTS.CurrentRow.Cells[2].Value.ToString();
                fnp.TB_PRICE.Text = DGV_PRODUCTS.CurrentRow.Cells[3].Value.ToString();
                fnp.TB_DESCRIPTION.Text = DGV_PRODUCTS.CurrentRow.Cells[5].Value.ToString();
                fnp.TB_GUARANTEE.ReadOnly = false;
                fnp.TB_GUARANTEE.Text = DGV_PRODUCTS.CurrentRow.Cells[6].Value.ToString();
                fnp.COMBO_CATEGORIES.Text = DGV_PRODUCTS.CurrentRow.Cells[7].Value.ToString();

                fnp.BTN_UPDATE.Visible = true;

                byte[] img = (byte[])DGV_PRODUCTS.CurrentRow.Cells[4].Value;
                MemoryStream ms = new MemoryStream(img);
                fnp.PB_BROWSE_IMAGE.Image = Image.FromStream(ms);
                fnp.ShowDialog();
                DGV_PRODUCTS.DataSource = product.GetProducts();
            }
            else
                MessageBox.Show("אין מוצרים לעדכן", "עידכון מוצר");
        }
        //כפתור מחיקת מוצר
        private void BTN_DELETE_PRODUCT_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            var tbl = product.GetProducts();
            if (tbl.Rows.Count != 0)
            {
                if (MessageBox.Show("?למחוק את המוצר", "מחיקת מוצר", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    product.DeleteProducts(Convert.ToInt32(DGV_PRODUCTS.CurrentRow.Cells[0].Value));
                    DGV_PRODUCTS.DataSource = product.GetProducts();
                    MessageBox.Show("המוצר נמחק בהצלחה", "מחיקת מוצר");
                }
            }
            else
                MessageBox.Show("אין מוצרים למחוק", "מחיקת מוצר");
        }
        //כפתור מוצר חדש
        private void BTN_NEW_PRODUCT_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            FORM_NEW_PRODUCT fnp = new FORM_NEW_PRODUCT();
            fnp.BTN_UPDATE.Visible = false;
            fnp.ShowDialog();
            DGV_PRODUCTS.DataSource = product.GetProducts();
        }
        //כפתור חיפוש
        private void BTN_SEARCH_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            DGV_PRODUCTS.DataSource = product.SearchProducts(TB_SEARCH.Text);
        }

    }
}
