using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace PC_STORE
{
    public partial class FORM_MANAGE_PRODUCT : Form
    {
        Product product = new Product();
        public FORM_MANAGE_PRODUCT()
        {
            InitializeComponent();
            DGV_PRODUCTS.DataSource = product.GetProducts();
            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            imageColumn = (DataGridViewImageColumn)DGV_PRODUCTS.Columns[4];
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Stretch;
            DGV_PRODUCTS.AllowUserToAddRows = false;
            DGV_PRODUCTS.RowTemplate.Height = 50;
        }

        private void BTN_NEW_PRODUCT_Click(object sender, EventArgs e)
        {
            FORM_NEW_PRODUCT fnp = new FORM_NEW_PRODUCT();
            fnp.ShowDialog();
            //DGV_PRODUCTS.DataSource = product.getProducts();
        }

        private void BTN_DELETE_PRODUCT_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("do you really want to delete this product", "Remove Product", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                product.DeleteProducts(Convert.ToInt32(DGV_PRODUCTS.CurrentRow.Cells[0].Value));
                DGV_PRODUCTS.DataSource = product.GetProducts();
                MessageBox.Show("Product Deleted Successfully", "Remove Product");
            }
        }

        private void BTN_UPDATE_PRODUCT_Click(object sender, EventArgs e)
        {
            FORM_UPDATE_PRODUCT fup = new FORM_UPDATE_PRODUCT();
            fup.LBL_PID.Text = DGV_PRODUCTS.CurrentRow.Cells[0].Value.ToString();
            fup.TB_NAME.Text = DGV_PRODUCTS.CurrentRow.Cells[1].Value.ToString();
            fup.TB_QUANTITY.Text = DGV_PRODUCTS.CurrentRow.Cells[2].Value.ToString();
            fup.TB_PRICE.Text = DGV_PRODUCTS.CurrentRow.Cells[3].Value.ToString();
            fup.TB_DESCRIPTION.Text = DGV_PRODUCTS.CurrentRow.Cells[5].Value.ToString();
            fup.COMBO_CATEGORIES.Text = DGV_PRODUCTS.CurrentRow.Cells[6].Value.ToString();

            byte[] img = (byte[])DGV_PRODUCTS.CurrentRow.Cells[4].Value;
            MemoryStream ms = new MemoryStream(img);
            fup.PB_BROWSE_IMAGE.Image = Image.FromStream(ms);
            fup.ShowDialog();
            DGV_PRODUCTS.DataSource = product.GetProducts();
        }

        private void BTN_SEARCH_Click(object sender, EventArgs e)
        {
            DGV_PRODUCTS.DataSource = product.SearchProducts(TB_SEARCH.Text);
        }
    }
}
